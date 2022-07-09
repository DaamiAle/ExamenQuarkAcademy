
using Microsoft.EntityFrameworkCore;

namespace ExamenQuarkAcademy.src.app.Models
{
    [Index(nameof(Nombre), IsUnique = true)]
    public class TiendaModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<PrendaModel> Prendas { get; set; }
        public List<VendedorModel> Vendedores { get; set; }
        /*
        // Atributos
        [Key]
        private int id;
        [Required]
        [MaxLength(20)]
        private string nombre;
        [Required]
        [MaxLength(30)]
        private string direccion;
        private List<PrendaModel> prendas;
        private List<VendedorModel> vendedores;

        // Propiedades
        public int Id() => id;
        public void Id(int value) => id = value;
        public string Nombre() => nombre;
        public void Nombre(string value) => nombre = value;
        public string Direccion() => direccion;
        public void Direccion(string value) => direccion = value;
        public List<PrendaModel> Prendas() => prendas;
        public void Prendas(List<PrendaModel> value) => prendas = value;
        public List<VendedorModel> Vendedores() => vendedores;
        public void Vendedores(List<VendedorModel> value) => vendedores = value;
        */
    }
}
