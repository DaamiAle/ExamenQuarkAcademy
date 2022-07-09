using ExamenQuarkAcademy.src.app.Models;
using ExamenQuarkAcademy.src.app.Repositories.Interfaces;

namespace ExamenQuarkAcademy.src.app.Repositories
{
    public class VendedorRepository : IVendedorRepository
    {
        private readonly ProjectContext database;
        public VendedorRepository(ProjectContext context)
        {
            database = context;
        }
        public async Task<VendedorModel> Add(VendedorModel vendedorModel)
        {
            return database.Vendedores.Add(vendedorModel).Entity;
        }

        public async Task<List<VendedorModel>> GetAll()
        {
            return await Task.FromResult(database.Vendedores.ToList());
        }

        public async Task<VendedorModel> GetByCode(string code)
        {
            return await Task.FromResult(database.Vendedores.FirstOrDefault(x => x.CodigoVendedor == code));
        }

        public async Task<VendedorModel> GetById(int id)
        {
            return await database.Vendedores.FindAsync(id);
        }
    }
}