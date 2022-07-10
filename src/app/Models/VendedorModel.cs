
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
    }
}
