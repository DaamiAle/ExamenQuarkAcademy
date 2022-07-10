using ExamenQuarkAcademy.src.app.Models;

namespace ExamenQuarkAcademy.src.app.Repositories.Interfaces
{
    public interface IPrendaRepository
    {
        PrendaModel Add(PrendaModel prendaModel);
        Task<PrendaModel> GetById(int id);
        Task<List<PrendaModel>> GetAll();
        Task<PrendaModel> GetCamisaBy(string manga, string cuello, string calidad);
    }
}
