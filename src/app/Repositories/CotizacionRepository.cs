using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenQuarkAcademy.src.app.Models;
using ExamenQuarkAcademy.src.app.Repositories.Interfaces;

namespace ExamenQuarkAcademy.src.app.Repositories
{
    public class CotizacionRepository : ICotizacionRepository
    {
        private readonly ProjectContext database;
        public CotizacionRepository(ProjectContext context)
        {
            database = context;
        }

        public async Task<CotizacionModel> AddCotizacion(CotizacionModel cotizacionModel)
        {
            return database.Cotizaciones.Add(cotizacionModel).Entity;
        }
    }
}
