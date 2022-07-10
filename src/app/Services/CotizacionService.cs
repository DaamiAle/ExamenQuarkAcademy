using ExamenQuarkAcademy.src.app.DataObjects;
using ExamenQuarkAcademy.src.app.Models;
using ExamenQuarkAcademy.src.app.Repositories;
using ExamenQuarkAcademy.src.app.Repositories.Interfaces;
using ExamenQuarkAcademy.src.app.Util;

namespace ExamenQuarkAcademy.src.app.Services
{
    public class CotizacionService
    {
        private readonly ICotizacionRepository cotizacionRepository;

        public CotizacionService(ProjectContext context)
        {
            cotizacionRepository = new CotizacionRepository(context);
        }
        public CotizacionDTO AddCotizacion(CotizacionDTO cotizacionDTO)
        {
            try
            {

                cotizacionDTO.Total = cotizacionDTO.Cantidad * cotizacionDTO.Prenda.Stock;
                if (cotizacionDTO.Prenda.EsCamisa)
                { 
                    if (cotizacionDTO.Prenda.Manga == "Corta")
                    {
                        cotizacionDTO.Total *= (decimal)0.90;
                    }
                    if (cotizacionDTO.Prenda.Cuello == "Mao")
                    {
                        cotizacionDTO.Total *= (decimal)1.03;
                    }
                }
                else if (cotizacionDTO.Prenda.EsChupin)
                {
                    cotizacionDTO.Total *= (decimal)0.88;
                }
                
                if (cotizacionDTO.Prenda.Calidad == "Premium")
                {
                    cotizacionDTO.Total *= (decimal)1.30;
                }

                CotizacionModel cotizacionModel = Converter.ConvertToCotizacionModel(cotizacionDTO);

                cotizacionRepository.AddCotizacion(cotizacionModel);
            }
            catch (Exception ex)
            {
                cotizacionDTO = new CotizacionDTO();
            }
            return cotizacionDTO;
        }
    }
}
