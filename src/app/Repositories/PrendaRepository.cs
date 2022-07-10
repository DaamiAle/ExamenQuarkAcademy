using ExamenQuarkAcademy.src.app.Models;
using ExamenQuarkAcademy.src.app.Repositories.Interfaces;

namespace ExamenQuarkAcademy.src.app.Repositories
{
    public class PrendaRepository : IPrendaRepository
    {
        private readonly ProjectContext database;

        public PrendaRepository(ProjectContext context)
        {
            database = context;
        }

        public async Task<PrendaModel> Add(PrendaModel prendaModel)
        {
            return database.Prendas.Add(prendaModel).Entity;
        }

        public async Task<List<PrendaModel>> GetAll()
        {
            return await Task.FromResult(database.Prendas.ToList());
        }

        public async Task<PrendaModel> GetById(int id)
        {
            return database.Prendas.Find(id);
        }
    }

}
