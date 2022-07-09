using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenQuarkAcademy.src.app.Views
{
    public partial class SeleccionDeTienda : Form
    {
        private readonly ProjectContext database;
        public SeleccionDeTienda(ProjectContext context)
        {
            InitializeComponent();
            database = context;
            
        }

        private void logInTab_Enter(object sender, EventArgs e)
        {
            Size = new Size(300, 250);
        }

        private void singInTab_Enter(object sender, EventArgs e)
        {
            Size = new Size(300, 300);
        }

        private void logInButtom_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            PaginaPrincipal pagina = new PaginaPrincipal(database,this);
            pagina.Show();
        }
    }
}
