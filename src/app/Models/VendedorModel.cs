
using Microsoft.EntityFrameworkCore;

namespace ExamenQuarkAcademy.src.app.Models
{
    [Index(nameof(CodigoVendedor), IsUnique = true)]
    public class VendedorModel
    {
        public int Id { get; set; }
        public string CodigoVendedor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<CotizacionModel> Cotizaciones { get; set; }
        public TiendaModel Tienda { get; set; }
        
        /*
        [Key]
        private int id;
        [MaxLength(20)]
        private string nombre;
        [MaxLength(20)]
        private string apellido;
        private List<CotizacionModel> cotizaciones;
        private TiendaModel tienda;
        // Propiedades
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public List<CotizacionModel> Cotizaciones { get => cotizaciones; set => cotizaciones = value; }
        public TiendaModel Tienda { get => tienda; set => tienda = value; }
        */
    }
}
