
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ExamenQuarkAcademy.src.app.Models
{
    
    public class PrendaModel
    {
        public int Id { get; set; }
        public string Calidad { get; set; }
        public Decimal Precio { get; set; }
        public int Stock { get; set; }
        public TiendaModel Tienda { get; set; }
        public bool EsCamisa { get; set; }
        public string Manga { get; set; }
        public string Cuello { get; set; }
        public bool EsChupin { get; set; }
    }
}
