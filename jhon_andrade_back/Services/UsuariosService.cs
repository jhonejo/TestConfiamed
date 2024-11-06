using jhon_andrade_back.Models;
using Microsoft.EntityFrameworkCore;

namespace jhon_andrade_back.Services
{
    public class UsuariosService
    {
        private readonly TestDbContext _context;

        public UsuariosService(TestDbContext context) { 
            _context = context;
        }

        public async Task<List<Usuarios>> GetUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }
    }
}
