using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkAcademy.src.app.DataObjects
{
    public class PrendaDTO
    {
        // Atributos
        public int Id { get; set; }
        public string Calidad { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }
        public TiendaDTO Tienda { get; set; }
        public bool EsCamisa { get; set; }
        public string Manga { get; set; }
        public string Cuello { get; set; }
        public bool EsChupin { get; set; }


        /*
        // Propiedades
        public int Id() => id;
        public void Id(int value) => id = value;
        public string TipoPrenda() => calidad;
        public void TipoPrenda(string value) => calidad = value;
        public int Precio() => precio;
        public void Precio(int value) => precio = value;
        public int Stock() => stock;
        public void Stock(int value) => stock = value;
        public Tienda Tienda() => tienda;
        public void Tienda(Tienda value) => tienda = value;
        public bool EsCamisa() => esCamisa;
        public void EsCamisa(bool value) => esCamisa = value;
        public string Manga() => manga;
        public void Manga(string value) => manga = value;
        public string Cuello() => cuello;
        public void Cuello(string value) => cuello = value;
        public bool EsChupin() => esChupin;
        public void EsChupin(bool value) => esChupin = value;


        // Constructor
        public Prenda(int id, string calidad, int precio, int stock, Tienda tienda, bool esCamisa, string manga, string cuello, bool esChupin)
        {
            this.id = id;
            this.calidad = calidad;
            this.precio = precio;
            this.stock = stock;
            this.tienda = tienda;
            this.esCamisa = esCamisa;
            this.manga = manga;
            this.cuello = cuello;
            this.esChupin = esChupin;
        }*/
    }
}
