using System;
using System.Collections.Generic;
using System.Linq;

using ExamenQuarkAcademy.src.app.DataObjects;
using ExamenQuarkAcademy.src.app.Models;
using ExamenQuarkAcademy.src.app.Repositories;
using ExamenQuarkAcademy.src.app.Repositories.Interfaces;
using ExamenQuarkAcademy.src.app.Util;

namespace ExamenQuarkAcademy.src.app.Services
{
    class TiendaService
    {
        private readonly ITiendaRepository tiendaRepository;
        public TiendaService(ProjectContext context)
        {
            tiendaRepository = new TiendaRepository(context);
        }
        public TiendaDTO GetTiendaById(int id)
        {
            TiendaModel tiendaModel = tiendaRepository.GetTiendaById(id).Result;
            return tiendaModel != null ? Converter.ConvertToTiendaDTO(tiendaModel) : throw CustomExceptions.TiendaNotFoundException();
        }


        public TiendaDTO AddTienda(TiendaDTO tiendaDTO)
        {
            TiendaModel tiendaModel = tiendaRepository.GetByName(tiendaDTO.Nombre).Result;
            if (tiendaModel == null)
            {
               tiendaModel = tiendaRepository.Add(Converter.ConvertToTiendaModel(tiendaDTO)).Result ?? throw CustomExceptions.TiendaNotCreatedException();
            }
            return Converter.ConvertToTiendaDTO(tiendaModel);
        }
        
        public TiendaDTO GetByName(string name)
        {
            TiendaModel tiendaModel = tiendaRepository.GetByName(name).Result;
            return tiendaModel != null ? Converter.ConvertToTiendaDTO(tiendaModel) : throw CustomExceptions.TiendaNotFoundException();
        }
    }
}
