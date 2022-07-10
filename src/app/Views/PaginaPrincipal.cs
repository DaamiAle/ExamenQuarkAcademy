using ExamenQuarkAcademy.src.app.Services;
using ExamenQuarkAcademy.src.app.DataObjects;

namespace ExamenQuarkAcademy.src.app.Views
{
    public partial class PaginaPrincipal : Form
    {
        private readonly ProjectContext database;
        private readonly PrendaService prendaService;
        private readonly TiendaService tiendaService;
        private readonly VendedorService vendedorService;
        private readonly CotizacionService cotizacionService;
        public PaginaPrincipal(ProjectContext context)
        {
            database = context;
            prendaService = new PrendaService(context);
            tiendaService = new TiendaService(context);
            vendedorService = new VendedorService(context);
            cotizacionService = new CotizacionService(context);
            InitializeComponent();
            AgregarValoresDefault();
            //CargarPrendas();



        }
        private void AgregarValoresDefault()
        {
            vendedorService.AddVededor(new VendedorDTO()
            {
                CodigoVendedor = "VDR001",
                Nombre = "Damian",
                Apellido = "Bruque",
                Tienda = new TiendaDTO()
                {
                    Nombre = "Tienda Los Buenos Vendedores",
                    Direccion = "Calle Falsa 123"
                }
            });

            database.SaveChanges();
        }
        private void CargarPrendas()
        {

            int contador = 0;
            PrendaDTO prenda = new PrendaDTO()
            {
                Tienda = new TiendaDTO()
                {
                    Nombre = "Tienda Los Buenos Vendedores",
                    Direccion = "Calle Falsa 123"
                },
                EsCamisa = true,
            };
            while (contador < 8)
            {
                switch (contador)
                {
                    case 0:
                        prenda.Manga = "Corta";
                        prenda.Cuello = "Mao";
                        prenda.Stock = 100;
                        prenda.Calidad = "Standar";
                        break;
                    case 1:
                        prenda.Calidad = "Premium";
                        break;
                    case 2:
                        prenda.Cuello = "Comun";
                        prenda.Stock = 150;
                        prenda.Calidad = "Standar";
                        break;
                    case 3:
                        prenda.Calidad = "Premium";
                        break;
                    case 4:
                        prenda.Manga = "Larga";
                        prenda.Cuello = "Mao";
                        prenda.Stock = 75;
                        prenda.Calidad = "Standar";
                        break;
                    case 5:
                        prenda.Calidad = "Premium";
                        break;
                    case 6:
                        prenda.Cuello = "Comun";
                        prenda.Stock = 175;
                        prenda.Calidad = "Standar";
                        break;
                    case 7:
                        prenda.Calidad = "Premium";
                        break;
                    default:
                        break;
                }
                contador++;
                prendaService.AddPrenda(prenda);
                database.SaveChanges();
            }
        }

        private void historial_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            VendedorDTO vendedor = vendedorService.GetById(1);
            label1.Text = $"VENDEDOR: {vendedor.Nombre} {vendedor.Apellido} \nCOD: {vendedor.CodigoVendedor}";
            TiendaDTO tienda = tiendaService.GetTiendaById(1);
            label2.Text = tienda.Nombre;
            label3.Text = $"Direccion: {tienda.Direccion}";

        }

        private void selectorCamisa_CheckedChanged(object sender, EventArgs e)
        {
            selectorManga.Enabled = true;
            selectorCuello.Enabled = true;
            verificadorChupin.Enabled = false;
        }

        private void selectorPantalon_CheckedChanged(object sender, EventArgs e)
        {
            verificadorChupin.Enabled = true;
            selectorManga.Enabled = false;
            selectorCuello.Enabled = false;
        }

        private void verificadorStock_Click(object sender, EventArgs e)
        {
            if (selectorCamisa.Checked)
            {
                string calidad = verificadorPremium.Checked == true ? "Premium" : "Standard";
                prendaService.GeyCamisaBy(selectorManga.Text, selectorCuello.Text, calidad);
            }
        }
    }
}