using ExamenQuarkAcademy.src.app.Models;

namespace ExamenQuarkAcademy.src.app.Repositories.Interfaces
{
    public interface IVendedorRepository
    {
        Task<VendedorModel> GetById(int id);
        Task<List<VendedorModel>> GetAll();
        Task<VendedorModel> Add(VendedorModel vendedorModel);
        Task<VendedorModel> GetByCode(string code);
    }
}
