
namespace ExamenQuarkAcademy.src.app.Models
{
    public class CotizacionModel
    {
        public int Id { get; set; }
        public DateTime? FechaHora { get; set; }
        public VendedorModel? Vendedor { get; set; }
        public PrendaModel? Prenda { get; set; }
        public int? Cantidad { get; set; }
        public int? Total { get; set; }

        /*
        // Atributos
        [Key]
        private int id;
        [Required]
        private DateTime fechaHora;
        [Required]
        private VendedorModel vendedor;
        [Required]
        private PrendaModel prenda;
        [Required]
        private int cantidad;
        [Required]
        private int total;
        // Propiedades
        public int Id { get => id; set => id = value; }
        public DateTime FechaHora { get => fechaHora; set => fechaHora = value; }
        public VendedorModel Vendedor { get => vendedor; set => vendedor = value; }
        public PrendaModel Prenda { get => prenda; set => prenda = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Total { get => total; set => total = value; }
        */
    }
}
