using ComerciPlus.Data;

namespace ComerciPlus.Services
{
    public class UsuarioService
    {
        private readonly ApplicationDbContext _context;

        public UsuarioService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Usuario? ValidateUser(string correo, string clave)
        {
            return _context.Usuario.FirstOrDefault(u => u.Correo == correo && u.Clave == clave);
        }
    }
}
