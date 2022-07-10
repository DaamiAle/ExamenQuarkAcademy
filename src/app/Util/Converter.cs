using ExamenQuarkAcademy.src.app.Models;
using ExamenQuarkAcademy.src.app.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkAcademy.src.app.Util
{
    public static class Converter
    {
        // TO DTO
        public static TiendaDTO ConvertToTiendaDTO(TiendaModel tiendaModel)
        {
            TiendaDTO tiendaDTO = new TiendaDTO
            {
                Id = tiendaModel.Id,
                Nombre = tiendaModel.Nombre,
                Direccion = tiendaModel.Direccion,
                Prendas = tiendaModel.Prendas != null ? tiendaModel.Prendas.Select(p => ConvertToPrendaDTO(p)).ToList() : new List<PrendaDTO>(),
                Vendedores = tiendaModel.Vendedores != null ? tiendaModel.Vendedores.Select(v => ConvertToVendedorDTO(v)).ToList() : new List<VendedorDTO>()
            };
            return tiendaDTO;

        }
        public static PrendaDTO ConvertToPrendaDTO(PrendaModel prendaModel)
        {
            PrendaDTO prendaDTO = new PrendaDTO
            {
                Id = prendaModel.Id,
                Calidad = prendaModel.Calidad,
                Precio = prendaModel.Precio,
                Stock = prendaModel.Stock,
                EsCamisa = prendaModel.EsCamisa,
                Manga = prendaModel.Manga,
                Cuello = prendaModel.Cuello,
                EsChupin = (bool)prendaModel.EsChupin
            };
            return prendaDTO;
        }
        public static CotizacionDTO ConvertToCotizacionDTO(CotizacionModel cotizacionModel)
        {
            CotizacionDTO cotizacionDTO = new CotizacionDTO
            {
                Id = cotizacionModel.Id,
                FechaHora = cotizacionModel.FechaHora,
                Prenda = ConvertToPrendaDTO(cotizacionModel.Prenda),
                Cantidad = cotizacionModel.Cantidad,
                Total = cotizacionModel.Total                
            };
            return cotizacionDTO;
        }
        public static VendedorDTO ConvertToVendedorDTO(VendedorModel vendedorModel)
        {
            VendedorDTO vendedorDTO = new VendedorDTO
            {
                Id = vendedorModel.Id,
                CodigoVendedor = vendedorModel.CodigoVendedor,
                Nombre = vendedorModel.Nombre,
                Apellido = vendedorModel.Apellido,
                Cotizaciones = vendedorModel.Cotizaciones != null ? vendedorModel.Cotizaciones.Select(c => ConvertToCotizacionDTO(c)).ToList() : new List<CotizacionDTO>()
            };
            return vendedorDTO;
        }


        // TO MODEL
        public static TiendaModel ConvertToTiendaModel(TiendaDTO tiendaDTO)
        {
            TiendaModel tiendaModel = new TiendaModel
            {
                Id = tiendaDTO.Id,
                Nombre = tiendaDTO.Nombre,
                Direccion = tiendaDTO.Direccion
            };
            return tiendaModel;
        }
        
        public static VendedorModel ConvertToVendedorModel(VendedorDTO vendedorDTO)
        {
            VendedorModel vendedorModel = new VendedorModel
            {
                Id = vendedorDTO.Id,
                CodigoVendedor = vendedorDTO.CodigoVendedor,
                Nombre = vendedorDTO.Nombre,
                Apellido = vendedorDTO.Apellido,
                Tienda = vendedorDTO.Tienda != null ? ConvertToTiendaModel(vendedorDTO.Tienda) : null
            };
            return vendedorModel;
        }
        
        public static PrendaModel ConvertToPrendaModel(PrendaDTO prendaDTO)
        {
            PrendaModel prenda = new PrendaModel
            {
                Id = prendaDTO.Id,
                Calidad = prendaDTO.Calidad,
                Precio = prendaDTO.Precio,
                Stock = prendaDTO.Stock,
                Tienda = prendaDTO != null ? ConvertToTiendaModel(prendaDTO.Tienda) : null,
                EsCamisa = prendaDTO.EsCamisa,
                Manga = prendaDTO.Manga,
                Cuello = prendaDTO.Cuello,
                EsChupin = prendaDTO.EsChupin
            };
            return prenda;
        }
        public static CotizacionModel ConvertToCotizacionModel(CotizacionDTO cotizacionDTO)
        {
            CotizacionModel cotizacion = new CotizacionModel
            {
                Id = cotizacionDTO.Id,
                FechaHora = cotizacionDTO.FechaHora,
                Vendedor = cotizacionDTO.Vendedor != null ? ConvertToVendedorModel(cotizacionDTO.Vendedor) : null,
                Prenda = cotizacionDTO.Prenda != null ? ConvertToPrendaModel(cotizacionDTO.Prenda) : null,
                Cantidad = cotizacionDTO.Cantidad,
                Total = cotizacionDTO.Total
            };
            return cotizacion;
        }
    }
}
