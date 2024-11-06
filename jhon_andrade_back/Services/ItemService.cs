using jhon_andrade_back.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace jhon_andrade_back.Services
{
    public class ItemService
    {
        private readonly TestDbContext _context;

        public ItemService(TestDbContext context ) {
            _context = context;
        }

        public async Task AsignarItem(int idItem)
        {
            var item = await _context.Items.FindAsync(idItem);
            if (item == null) return;

            var usuarios = await _context.Usuarios.ToListAsync();
            var usuarioDisponible = usuarios
                .Where(u => u.ItemPendiente < 3 && u.ItemRelevante > 3)
                .OrderBy(u => u.ItemPendiente)
                .FirstOrDefault();

            if(usuarioDisponible == null)
            {
                usuarioDisponible.ItemPendiente += 1;
                item.Estado = "Pendiente";
                await _context.SaveChangesAsync();
            }
        }

        public async Task CrearItem(Item item)
        {
            _context.Items.Add(item);
            await _context.SaveChangesAsync();
        }
    }
}
