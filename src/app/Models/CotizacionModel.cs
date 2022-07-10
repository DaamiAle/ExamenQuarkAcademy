
namespace ExamenQuarkAcademy.src.app.Models
{
    public class CotizacionModel
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public VendedorModel Vendedor { get; set; }
        public PrendaModel Prenda { get; set; }
        public int Cantidad { get; set; }
        public Decimal Total { get; set; }
    }
}
