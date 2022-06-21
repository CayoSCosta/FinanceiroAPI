using FinanceiroAPI._2._0.Models;
using FinanceiroAPI._2._0.ViewModels;

namespace FinanceiroAPI._2._0.Services.UsuarioServices
{
    public class UsuarioServices : IUsuarioServices
    {

        private readonly Contexto _context;

        public UsuarioServices(Contexto context)
        {
            _context = context;
        }

        public Usuario GetUser(LoginViewModel model)
        {
            try
            {
                var user = (from u in _context.Usuarios
                            where u.Username == model.UserName && u.Password == model.Password
                            select u)
                            .FirstOrDefault();

                return user;
            }
            catch (Exception ex)
            {
                throw ex;
                Console.WriteLine(ex.Message);
            }
        }
    }
}
