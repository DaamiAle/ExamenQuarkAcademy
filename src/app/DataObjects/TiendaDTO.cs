using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkAcademy.src.app.DataObjects
{
    public class TiendaDTO
    {
        // Atributos
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<PrendaDTO> Prendas { get; set; }
        public List<VendedorDTO> Vendedores { get; set; }
        
    }
}
