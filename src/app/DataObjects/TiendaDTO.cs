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
        /*
        // Propiedades
        public int Id() => id;
        public void Id(int value) => id = value;
        public string Nombre() => nombre;
        public void Nombre(string value) => nombre = value;
        public string Direccion() => direccion;
        public void Direccion(string value) => direccion = value;
        public List<Prenda> Prendas() => prendas;
        public void Prendas(List<Prenda> value) => prendas = value;
        public List<Vendedor> Vendedores() => vendedores;
        public void Vendedores(List<Vendedor> value) => vendedores = value;

        // Constructor

        public Tienda(int id, string nombre, string direccion, List<Prenda> prendas, List<Vendedor> vendedores)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.prendas = prendas;
            this.vendedores = vendedores;
        }*/
    }
}
