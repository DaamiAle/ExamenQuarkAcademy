using ExamenQuarkAcademy.src.app.DataObjects;
using ExamenQuarkAcademy.src.app.Services;

namespace ExamenQuarkAcademy.src.app
{
    public class AgregadorDefault
    {
        private readonly ProjectContext database;
        public AgregadorDefault(ProjectContext context)
        {
            database = context;
        }
        public void AgregarVendedor()
        {
            VendedorService vendedorService = new VendedorService(database);
            vendedorService.AddVededor(new VendedorDTO
            {
                CodigoVendedor = "VDR001",
                Nombre = "Damian",
                Apellido = "Bruque"//,
                //Cotizaciones = new List<CotizacionDTO>()
            });
            database.SaveChanges();
            //new TiendaService(database).GetTiendaById(1).Vendedores.Add(vendedorService.GetByCodigo("VDR001"));
            //database.SaveChanges();
        }

        public void AgregarTienda()
        {
            TiendaService tiendaService = new TiendaService(database);
            tiendaService.AddTienda(new TiendaDTO
            {
                Nombre = "Tienda Los Buenos Vendedores",
                Direccion = "Calle Falsa 123",
                Prendas = new List<PrendaDTO>(),
                Vendedores = new List<VendedorDTO>()
            });
            database.SaveChanges();
        }

        public void AgregarPrendaPreestablecidas()
        {
            
        }
    }
}
