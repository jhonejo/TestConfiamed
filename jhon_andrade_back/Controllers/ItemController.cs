using jhon_andrade_back.Models;
using jhon_andrade_back.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace jhon_andrade_back.Controllers
{
    [Route("api/items")]
    [ApiController]
    public class ItemController:ControllerBase
    {
        private readonly ItemService _itemService;

        public ItemController(ItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpPost]
        public async Task<IActionResult> CrearItem([FromBody] Item item)
        {
            await _itemService.CrearItem(item);
            return CreatedAtAction(nameof(CrearItem), new { id = item.Id }, item);
        }

        [HttpPost("{idItem}/asignar")]
        public async Task<IActionResult> AsignarItem(int idItem)
        {
            await _itemService.AsignarItem(idItem);
            return NoContent();
        }
    }
}
