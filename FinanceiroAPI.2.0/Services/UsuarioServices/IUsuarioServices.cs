using FinanceiroAPI._2._0.Models;
using FinanceiroAPI._2._0.ViewModels;

namespace FinanceiroAPI._2._0.Services.UsuarioServices
{
    public interface IUsuarioServices
    {
        Usuario GetUser(LoginViewModel model);
    }
}