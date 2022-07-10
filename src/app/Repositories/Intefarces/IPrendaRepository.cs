using ExamenQuarkAcademy.src.app.Models;

namespace ExamenQuarkAcademy.src.app.Repositories.Interfaces
{
    public interface IPrendaRepository
    {
        Task<PrendaModel> Add(PrendaModel prendaModel);
        Task<PrendaModel> GetById(int id);
        Task<List<PrendaModel>> GetAll();
    }
}
