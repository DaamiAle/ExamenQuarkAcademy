
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
    }
}
