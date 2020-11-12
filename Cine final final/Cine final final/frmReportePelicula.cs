using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Cine_final_final
{
    public partial class frmReportePelicula : Form
    {
        Datos oBD = new Datos("Data Source = (local); Initial Catalog = cinejn; Integrated Security = True");
        SqlConnection conexion = new SqlConnection("Data Source = (local); Initial Catalog = cinejn; Integrated Security = True");

        public frmReportePelicula()
        {
            InitializeComponent();
        }

        private void frmReportePelicula_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cinejnDataSet1.Peliculas' Puede moverla o quitarla según sea necesario.
            //this.PeliculasTableAdapter.Fill(this.cinejnDataSet1.Peliculas);

            //this.reportViewer1.RefreshReport();

            cargarCombo(cboGeneros2, "Generos", "id_genero", "genero");
            cboGeneros2.SelectedIndex=- 1;
            
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Peliculas WHERE Titulo like '%" + txtBuscar.Text + "%'";

            PeliculasBindingSource.DataSource=oBD.consultar(sql) ;
            reportViewer1.RefreshReport();
            txtBuscar.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Peliculas";
            PeliculasBindingSource.DataSource = oBD.consultar(sql);
            reportViewer1.RefreshReport();
            txtBuscar.Clear();
        }

        private void cargarCombo(ComboBox combo, string nombreTabla, string pk, string display)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("Select * from " + nombreTabla, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;

            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());

            conexion.Close();
            combo.DataSource = tabla;
            combo.DisplayMember = display;
            combo.ValueMember = pk;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Peliculas WHERE id_genero='" + cboGeneros2.SelectedValue + "'";

            PeliculasBindingSource.DataSource = oBD.consultar(sql);
            reportViewer1.RefreshReport();
        }

        private void Limpiar()
        {
            txtBuscar.Clear();

        }
    }
}
