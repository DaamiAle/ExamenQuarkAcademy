using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkAcademy.src.app.DataObjects
{
    public class PrendaDTO
    {
        // Atributos
        public int Id { get; set; }
        public string Calidad { get; set; }
        public Decimal Precio { get; set; }
        public int Stock { get; set; }
        public TiendaDTO Tienda { get; set; }
        public bool EsCamisa { get; set; }
        public string Manga { get; set; }
        public string Cuello { get; set; }
        public bool EsChupin { get; set; }
        
    }
}
