using ExamenQuarkAcademy.src.app.Models;

namespace ExamenQuarkAcademy.src.app.Repositories.Interfaces
{
    public interface ICotizacionRepository
    {
        Task<CotizacionModel> AddCotizacion(CotizacionModel cotizacionModel);
    }
}
