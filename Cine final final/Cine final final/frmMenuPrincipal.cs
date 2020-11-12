using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine_final_final
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportePelicula frp = new frmReportePelicula();
            frp.ShowDialog();
        }

        private void peliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fp = new Form2();
            fp.ShowDialog();

        }

        private void consultasLabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 lab = new Form1();
            lab.ShowDialog();
        }

        private void nuevoToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
                
        }

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir?", "SALIENDO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
