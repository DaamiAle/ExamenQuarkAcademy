using ExamenQuarkAcademy.src.app.DataObjects;
using ExamenQuarkAcademy.src.app.Models;
using ExamenQuarkAcademy.src.app.Repositories;
using ExamenQuarkAcademy.src.app.Repositories.Interfaces;
using ExamenQuarkAcademy.src.app.Util;

namespace ExamenQuarkAcademy.src.app.Services
{
    public class VendedorService
    {
        private IVendedorRepository vendedorRepository;

        public VendedorService(ProjectContext context)
        {
            vendedorRepository = new VendedorRepository(context);
        }
        


        /// <summary>
        /// Aqui Hay que revisar!!!!!!!
        /// </summary>
        /// <param name="vendedorDTO"></param>
        /// <returns></returns>
        public VendedorDTO AddVededor(VendedorDTO vendedorDTO)
        {
            VendedorModel vendedorModel = vendedorRepository.GetByCode(vendedorDTO.CodigoVendedor).Result;
            if (vendedorModel == null)
            {
                vendedorModel = vendedorRepository.Add(Converter.ConvertToVendedorModel(vendedorDTO)).Result ?? throw CustomExceptions.VendedorNotCreatedException();
            }
            return Converter.ConvertToVendedorDTO(vendedorModel);
        }
        
        public VendedorDTO GetByCodigo(string codigo)
        {
            VendedorModel vendedorModel = vendedorRepository.GetByCode(codigo).Result;
            return vendedorModel != null ? Converter.ConvertToVendedorDTO(vendedorModel) : throw CustomExceptions.VendedorNotFoundException();
        }
        public VendedorDTO GetById(int id)
        {
            VendedorModel vendedorModel = vendedorRepository.GetById(id).Result;
            return vendedorModel != null ? Converter.ConvertToVendedorDTO(vendedorModel) : throw CustomExceptions.VendedorNotFoundException();
        }
    }
}
