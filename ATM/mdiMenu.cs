using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class mdiMenu : Form
    {
        public mdiMenu()
        {
            InitializeComponent();
        }

        private void cmsUsuarios_Click_1(object sender, EventArgs e)
        {
            vistaUsuarios agregarUsuario = new vistaUsuarios();
            agregarUsuario.MdiParent = this;
            agregarUsuario.Show();
        }
    }
}
