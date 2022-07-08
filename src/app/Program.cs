
namespace ExamenQuarkAcademy.src.app
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            using (var database = new ProjectContext())
            {
                database.Database.EnsureCreated();
                database.SaveChanges();
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}