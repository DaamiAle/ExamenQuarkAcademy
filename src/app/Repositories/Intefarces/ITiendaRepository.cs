using ExamenQuarkAcademy.src.app.Models;

namespace ExamenQuarkAcademy.src.app.Repositories.Interfaces
{
    public interface ITiendaRepository
    {
        Task<TiendaModel> GetTiendaById(int id);
        Task<TiendaModel> Add(TiendaModel tiendaModel);
        Task<TiendaModel> GetByName(string name);
    }
}
