using ExamenQuarkAcademy.src.app.DataObjects;
using ExamenQuarkAcademy.src.app.Models;
using ExamenQuarkAcademy.src.app.Repositories;
using ExamenQuarkAcademy.src.app.Repositories.Interfaces;
using ExamenQuarkAcademy.src.app.Util;

namespace ExamenQuarkAcademy.src.app.Services
{
    public class PrendaService
    {
        private IPrendaRepository prendaRepository;
        public PrendaService(ProjectContext context){
            prendaRepository = new PrendaRepository(context);
        }
        public PrendaDTO AddPrenda(PrendaDTO prendaDTO)
        {
            return Converter.ConvertToPrendaDTO(prendaRepository.Add(Converter.ConvertToPrendaModel(prendaDTO)));
            /*
             * 
            PrendaModel prendaModel = prendaRepository.GetById(prendaDTO.Id).Result;
            if (prendaModel != null)
            {
                prendaModel = prendaRepository.Add(Converter.ConvertToPrendaModel(prendaDTO)).Result ?? throw CustomExceptions.TiendaNotCreatedException();
            }
            return Converter.ConvertToPrendaDTO(prendaModel);
            /*
            PrendaModel prendaModel = prendaRepository.GetById(prendaDTO.Id).Result;
            if (prendaModel == null)
            {
                prendaModel = prendaRepository.AddPrenda(Converter.ConvertToPrendaModel(prendaDTO)).Result ?? throw CustomExceptions.PrendaNotCreatedException();
            }
            return Converter.ConvertToPrendaDTO(prendaModel);*/
        }

        public PrendaDTO GeyCamisaBy(string manga, string cuello, string calidad)
        {
            PrendaModel prendaModel = prendaRepository.GetCamisaBy(manga, cuello, calidad).Result;
            return Converter.ConvertToPrendaDTO(prendaModel);
        }

        public PrendaDTO GeyPantalonBy(bool esChupin, string calidad)
        {
            PrendaModel prendaModel = prendaRepository.GetPantalonBy(esChupin, calidad).Result;
            return Converter.ConvertToPrendaDTO(prendaModel);
        }
    }
}
