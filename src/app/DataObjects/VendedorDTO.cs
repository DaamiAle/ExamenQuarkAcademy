using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkAcademy.src.app.DataObjects
{
    public class VendedorDTO
    {
        public int Id { get; set; }
        public string CodigoVendedor { get; set; }        
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<CotizacionDTO> Cotizaciones { get; set; }
        public TiendaDTO Tienda { get; set; }
        /*
        // Propiedades
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public List<Cotizacion> Cotizaciones { get => cotizaciones; set => cotizaciones = value; }
        public Tienda Tienda { get => tienda; set => tienda = value; }*/
    }
}
