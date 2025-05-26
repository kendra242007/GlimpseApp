using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlimpseApp
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btncontactos_Click(object sender, EventArgs e)
        {
            Contactos Contactos = new Contactos();
            Contactos.Show();

            this.Hide();
        }
    }
}
