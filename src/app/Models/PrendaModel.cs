
using System.ComponentModel.DataAnnotations;

namespace ExamenQuarkAcademy.src.app.Models
{
    public class PrendaModel
    {
        
        public int Id { get; set; }
        public string? Calidad { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }
        public TiendaModel? Tienda { get; set; }
        public bool EsCamisa { get; set; }
        public string? Manga { get; set; }
        public string? Cuello { get; set; }
        public bool? EsChupin { get; set; }
        

        /*
        // Atributos
        [Key]
        private int id;
        [Required]
        [MaxLength(10)]
        private string calidad;
        [Required]
        private int precio;
        [Required]
        private int stock;
        private TiendaModel tienda;
        [Required]
        private bool esCamisa;
        private string manga;
        private string cuello;
        private bool esChupin;
        
        // Propiedades
        public int Id() => id;
        public void Id(int value) => id = value;
        public string TipoPrenda() => calidad;
        public void TipoPrenda(string value) => calidad = value;
        public int Precio() => precio;
        public void Precio(int value) => precio = value;
        public int Stock() => stock;
        public void Stock(int value) => stock = value;
        public TiendaModel Tienda() => tienda;
        public void Tienda(TiendaModel value) => tienda = value;
        public bool EsCamisa() => esCamisa;
        public void EsCamisa(bool value) => esCamisa = value;
        public string Manga() => manga;
        public void Manga(string value) => manga = value;
        public string Cuello() => cuello;
        public void Cuello(string value) => cuello = value;
        public bool EsChupin() => esChupin;
        public void EsChupin(bool value) => esChupin = value;
        */
    }
}
