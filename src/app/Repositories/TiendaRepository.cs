using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenQuarkAcademy.src.app;
using ExamenQuarkAcademy.src.app.DataObjects;
using ExamenQuarkAcademy.src.app.Models;
using ExamenQuarkAcademy.src.app.Repositories.Interfaces;
using ExamenQuarkAcademy.src.app.Util;

namespace ExamenQuarkAcademy.src.app.Repositories
{
    public class TiendaRepository : ITiendaRepository
    {
        private readonly ProjectContext database;
        public TiendaRepository(ProjectContext context)
        {
            database = context;
        }

        public async Task<TiendaModel> Add(TiendaModel tiendaModel)
        {
            return database.Tiendas.Add(tiendaModel).Entity;
        }

        public async Task<TiendaModel> GetByName(string name)
        {
            return await Task.FromResult(database.Tiendas.FirstOrDefault(x => x.Nombre == name));
        }

        public async Task<TiendaModel> GetTiendaById(int id)
        {
            return database.Tiendas.Find(id);

        }
    }
}
