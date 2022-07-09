using System;
using System.Collections.Generic;
using System.Linq;
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

        internal static Exception VendedorNotCreatedException()
        {
            return new Exception("Vendedor no creado");
        }

        internal static Exception VendedorNotFoundException()
        {
            return new Exception("Vendedor no encontrado");
        }
    }
}
