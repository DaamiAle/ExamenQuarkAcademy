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
        
    }
}
