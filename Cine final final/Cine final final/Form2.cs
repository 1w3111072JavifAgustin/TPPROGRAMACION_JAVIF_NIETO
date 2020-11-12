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
    public partial class Form2 : Form
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();
        const int tam = 50;
        Peliculas[] aPeliculas = new Peliculas[tam];
        bool nuevo;
        int c;
        enum accion {nuevo,editado }
        accion miAccion;


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cargarCombo(cboGenero, "Generos", "id_genero", "genero");
            cargarCombo(cboClasificacion, "Clasificion", "id_clasificacion", "clasificacion");
            CargarLista();
            nuevo = false;
            habilitar(false);
            cboClasificacion.SelectedValue = -1;
            cboGenero.SelectedValue = -1;
        }


        private void habilitar(bool x)
        {
            txtTitulo.Enabled = x;
            cboGenero.Enabled = x;
            cboClasificacion.Enabled = x;
            dtpAño.Enabled = x;
            txtActor.Enabled = x;
            txtDirector.Enabled = x;
            txtReseña.Enabled = x;
            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnBorrar.Enabled = !x;
            btnGrabar.Enabled = x;
            btnCancelar.Enabled = x;
            txtID.Enabled = x;
        }

        private void limpiar()
        {
            txtTitulo.Text = "";
            cboGenero.SelectedIndex = -1;
            cboClasificacion.SelectedIndex = -1;
            txtActor.Text = "";
            txtDirector.Text = "";
            txtReseña.Text = "";
        }

        private void cargarCombo(ComboBox combo, string nombreTabla, string pk, string display)
        {
            conexion.ConnectionString = "Data Source = (local); Initial Catalog = cinejn; Integrated Security = True";
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM " + nombreTabla;

            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());

            conexion.Close();

            combo.DataSource = tabla;
            combo.DisplayMember = display;
            combo.ValueMember = pk;

        }

        private void CargarLista()
        {
            conexion.ConnectionString = "Data Source = (local); Initial Catalog = cinejn; Integrated Security = True";
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Peliculas";
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            int c = 0;
            while (lector.Read())
            {
                Peliculas p = new Peliculas();
                if (!lector.IsDBNull(1))
                    p.pTitulo = lector.GetString(1);
                if (!lector.IsDBNull(2))
                    p.pGenero = lector.GetInt32(2);
                if (!lector.IsDBNull(7))
                    p.pClasificacion = lector.GetInt32(7);
                if (!lector.IsDBNull(3))
                    p.pAño = lector.GetDateTime(3);
                if (!lector.IsDBNull(6))
                    p.pActor = lector.GetString(6);
                if (!lector.IsDBNull(5))
                    p.pDirector = lector.GetString(5);
                if (!lector.IsDBNull(4))
                    p.pReseña = lector.GetString(4);
                if (!lector.IsDBNull(0))
                    p.pId = lector.GetInt32(0);


                aPeliculas[c] = p;
                c++;
            }
            conexion.Close();
            lstPeliculas.Items.Clear();
            for (int i = 0; i < c; i++)
            {
                lstPeliculas.Items.Add(aPeliculas[i].toStringPelicula());
            }
        }

        private void CargarCampos(int posicionArreglo)
        {
            txtTitulo.Text = aPeliculas[posicionArreglo].pTitulo;
            cboGenero.SelectedValue = aPeliculas[posicionArreglo].pGenero;
            cboClasificacion.SelectedValue = aPeliculas[posicionArreglo].pClasificacion;
            txtActor.Text = aPeliculas[posicionArreglo].pActor;
            txtDirector.Text = aPeliculas[posicionArreglo].pDirector;
            txtReseña.Text = aPeliculas[posicionArreglo].pReseña;
            txtID.Text = aPeliculas[posicionArreglo].pId.ToString();
            dtpAño.Value = aPeliculas[posicionArreglo].pAño;
        }

        private void lstPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CargarCampos(lstPeliculas.SelectedIndex);

        }

        private bool existe(int pk)
        {
            bool x = false;

            for (int i = 0; i < c; i++)
            {
                if (aPeliculas[i].pId == pk)
                    x = true;


            }
            return false;
        }

        private void Limpiar()
        {
            txtTitulo.Text = "";
            txtTitulo.Clear();
            txtReseña.Text = string.Empty;
            cboClasificacion.SelectedIndex = -1;
            cboGenero.SelectedIndex = -1;
            txtActor.Text = ""; ;
            txtActor.Clear();
            txtDirector.Text = "";
            txtDirector.Clear();
            txtID.Text = "";
            txtID.Clear();

        }

       
             
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitar(true);
            nuevo = true;
            Limpiar();
            txtTitulo.Focus();
            miAccion = accion.nuevo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            nuevo = false;
            habilitar(false);
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar esta pelicula?", "ELIMINANDO..",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                string consultaSql = "DELETE FROM Peliculas WHERE id_peliculas=" + aPeliculas[lstPeliculas.SelectedIndex].pId;
                conexion.ConnectionString = "Data Source = (local); Initial Catalog = cinejn; Integrated Security = True";
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = consultaSql;
                comando.ExecuteNonQuery();
                conexion.Close();
                CargarLista();
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                string consultaSql = "";

                if (miAccion==accion.nuevo)
                {

                    Peliculas p = new Peliculas();
                    p.pTitulo = txtTitulo.Text;
                    p.pGenero = (int)cboGenero.SelectedValue;
                    p.pClasificacion = (int)cboClasificacion.SelectedValue;
                    p.pAño = dtpAño.Value;
                    p.pActor = txtActor.Text;
                    p.pReseña = txtReseña.Text;
                    p.pDirector = txtDirector.Text;



                    if (!existe(p.pId))
                    {
                        consultaSql = "set dateformat dmy INSERT INTO Peliculas(titulo, id_genero, Año, reseña, Direccion, Actores, id_clasificacion)" +
                                      " VALUES('" + p.pTitulo + "'," +
                                                   p.pGenero + ",'" +
                                                   p.pAño + "','" +
                                                   p.pReseña + "','" +
                                                   p.pDirector + "','"+
                                                   p.pActor +"'," +
                                                   p.pClasificacion+")";

                        conexion.ConnectionString = "Data Source = (local); Initial Catalog = cinejn; Integrated Security = True";
                        conexion.Open();
                        comando.Connection = conexion;
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = consultaSql;
                        comando.ExecuteNonQuery();
                        conexion.Close();

                    }
                }

                else
                {
                    int i = lstPeliculas.SelectedIndex;                   
                    aPeliculas[i].pTitulo = txtTitulo.Text;
                    aPeliculas[i].pGenero = (int)cboGenero.SelectedValue;
                    aPeliculas[i].pAño = dtpAño.Value;
                    aPeliculas[i].pReseña = txtReseña.Text;
                    aPeliculas[i].pDirector = txtDirector.Text;
                    aPeliculas[i].pActor = txtActor.Text;
                    aPeliculas[i].pClasificacion = (int)cboClasificacion.SelectedValue;

                    consultaSql = "set dateformat dmy UPDATE Peliculas SET "
                                                                    + "titulo='" + aPeliculas[i].pTitulo + "',"
                                                                    + "id_genero=" + aPeliculas[i].pGenero + ","
                                                                    + "Año='" + aPeliculas[i].pAño +"',"
                                                                    + "reseña='"+aPeliculas[i].pReseña+"',"
                                                                    + "direccion='"+aPeliculas[i].pDirector+"',"
                                                                    + "actores='"+aPeliculas[i].pActor+"',"
                                                                    + "id_clasificacion="+aPeliculas[i].pClasificacion +
                                                                    " WHERE id_peliculas=" + aPeliculas[i].pId;

                    conexion.ConnectionString = "Data Source = (local); Initial Catalog = cinejn; Integrated Security = True";
                    conexion.Open();
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = consultaSql;
                    comando.ExecuteNonQuery();
                    conexion.Close();


                }

                CargarLista();

            }

            habilitar(false);

        }

        private bool ValidarDatos()
        {
            if (txtTitulo.Text == "")
            {
                MessageBox.Show("Ingrese titulo");
                txtTitulo.Focus();
                return false;
            }
            if (txtDirector.Text == "")
            {
                MessageBox.Show("Ingrese director");
                txtDirector.Focus();
                return false;
            }
            if (txtReseña.Text == "")
            {
                MessageBox.Show("Ingrese reseña");
                txtReseña.Focus();
                return false;
            }
            if (cboClasificacion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione tipo de clasificacion");
                cboClasificacion.Focus();
                return false;
            }
            if (cboGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Genero de la pelicula");
                cboGenero.Focus();
                return false;
            }

            return true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstPeliculas.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una pelicula");
                lstPeliculas.Focus();

            }
            else
            {
                habilitar(true);
                txtTitulo.Enabled = false;
                txtDirector.Focus();
                miAccion = accion.editado;
            }
                       
        }

        private void txtReseña_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void txtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtActor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96))
            {
                MessageBox.Show("No se permiten numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDirector_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96))
            {
                MessageBox.Show("No se permiten numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
