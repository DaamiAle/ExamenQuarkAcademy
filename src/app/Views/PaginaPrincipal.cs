

namespace ExamenQuarkAcademy.src.app.Views
{ 
    public partial class PaginaPrincipal : Form
    {
        private readonly ProjectContext database;
        private readonly Form formOrigen;
        public PaginaPrincipal(ProjectContext context,Form origen)
        {
            database = context;
            formOrigen = origen;
            InitializeComponent();
            
            
            
        }

        private void historial_Click(object sender, EventArgs e)
        {

        }

        private void PaginaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            formOrigen.Show();
        }
    }
}