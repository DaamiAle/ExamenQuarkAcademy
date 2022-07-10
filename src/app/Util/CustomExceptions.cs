using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkAcademy.src.app.Util
{
    public static class CustomExceptions
    {
        public static Exception TiendaNotFoundException() {
            return new Exception("Tienda no encontrada");
        }

        public static Exception TiendaNotCreatedException()
        {
            return new Exception("Tienda no creada");
        }

        public static Exception VendedorNotCreatedException()
        {
            return new Exception("Vendedor no creado");
        }

        public static Exception VendedorNotFoundException()
        {
            return new Exception("Vendedor no encontrado");
        }

        public static Exception CotizacionNotCreatedException()
        {
            return new Exception("Cotizacion no creada");
        }

        internal static Exception PrendaNotCreatedException()
        {
            return new Exception("Prenda no creada");
        }

        public static Exception PrendaSinStockException()
        {
            return new Exception("Prenda sin stock");
        }

        public static Exception VendedorNotUpdatedException()
        {
            return new Exception("Vendedor no actualizado");
        }
    }
}
