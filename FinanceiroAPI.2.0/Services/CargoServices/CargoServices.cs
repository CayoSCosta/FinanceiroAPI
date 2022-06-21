using FinanceiroAPI._2._0.Models;

namespace FinanceiroAPI._2._0.Services.CargoServices
{
    public class CargoServices : ICargoServices
    {
        private readonly Contexto _context;

        public CargoServices(Contexto context)
        {
            _context = context;
        }

        public List<Cargo> GetAll()
        {
            try
            {
                return _context.Cargos.ToList();
            }
            catch (Exception ex)
            {
                return null;
                Console.WriteLine(ex);
            }
        }
        public Cargo GetById(int id)
        {
            try
            {
                var cargo = (from c in _context.Cargos
                             where c.Id == id
                             select c)
                             .FirstOrDefault();

                return cargo;
            }
            catch (Exception ex)
            {
                return null;
                Console.WriteLine(ex.Message);
            }
        }
        public Cargo GetByName(string nome)
        {
            try
            {
                var cargo = (from c in _context.Cargos
                             where c.Nome == nome
                             select c)
                             .FirstOrDefault();

                return cargo;

            }
            catch (Exception ex)
            {
                return null;
                Console.WriteLine(ex.Message);
            }
        }
        public bool Create(Cargo cargo)
        {
            try
            {
                _context.Add(cargo);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                Console.WriteLine(ex.Message);
            }

        }
        public bool Update(Cargo cargo)
        {
            try
            {
                var c = GetById(cargo.Id);

                c.Nome = cargo.Nome;
                c.DataInativado = cargo.DataInativado;
                c.Ativo = cargo.Ativo;
                c.CriadoPor = cargo.CriadoPor;

                _context.Update(c);
                _context.SaveChangesAsync();
                return true;

            }
            catch (Exception ex)
            {
                return false;
                Console.WriteLine(ex.Message);
            }
        }
        public bool Delete(Cargo cargo)
        {
            try
            {
                _context.Remove(cargo);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                Console.WriteLine(ex.Message);
            }

        }

    }
}
