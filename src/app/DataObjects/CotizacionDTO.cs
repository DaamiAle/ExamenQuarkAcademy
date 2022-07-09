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
        public int Total { get; set; }
        /*
        // Propiedades
        public int Id { get => id; set => id = value; }
        public DateTime FechaHora { get => fechaHora; set => fechaHora = value; }
        public Vendedor Vendedor { get => vendedor; set => vendedor = value; }
        public Prenda Prenda { get => prenda; set => prenda = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Total { get => total; set => total = value; }*/
    }
}
