using FinanceiroAPI._2._0.Models;

namespace FinanceiroAPI._2._0.Services.CargoServices
{
    public interface ICargoServices
    {
        List<Cargo> GetAll();
        bool Create(Cargo cargo);
        bool Delete(Cargo cargo);
        Cargo GetById(int id);
        Cargo GetByName(string nome);
        bool Update(Cargo cargo);
    }
}