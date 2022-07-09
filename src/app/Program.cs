using ExamenQuarkAcademy.src.app.Services;
using ExamenQuarkAcademy.src.app.Views;
using ExamenQuarkAcademy.src.app.DataObjects;

namespace ExamenQuarkAcademy.src.app
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ProjectContext database = new ProjectContext();
            database.Database.EnsureCreated();
            database.SaveChanges();
            AgregadorDefault agregador = new AgregadorDefault(database);
            //agregador.AgregarTienda();
            agregador.AgregarVendedor();
            //agregador.AgregarPrendaPreestablecidas();
            


            ApplicationConfiguration.Initialize();
            Application.Run(new ExamenQuarkAcademy.src.app.Views.SeleccionDeTienda(database));
        }
    }
}