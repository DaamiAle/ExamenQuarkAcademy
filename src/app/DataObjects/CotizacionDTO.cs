using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkAcademy.src.app.DataObjects
{
    public class CotizacionDTO
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public VendedorDTO Vendedor { get; set; }
        public PrendaDTO Prenda { get; set; }
        public int Cantidad { get; set; }
        public Decimal Total { get; set; }
        
    }
}
