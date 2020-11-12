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
    public partial class Form1 : Form
    {

        SqlConnection conexion = new SqlConnection("Data Source = (local); Initial Catalog = cinejn; Integrated Security = True");


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarCombo(comboBox1, "Generos", "id_genero", "genero");
            cargarCombo(cboCajeros, "Cajeros", "id_cajero", "ape_cajero");
            cargarCombo(cboTipoCliente, "Tipos_cliente", "id_tipclte", "tipo");

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

        private void cargarCombo2(ComboBox combo, string nombreTabla, string pk, string display, string display2)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string query = "";
            query += "select nom_cliente +','+ ape_cliente 'CLIENTE', c.id_cliente 'Codigo', FORMAT(fecha,'dd/MM/yy')'fecha', hora 'Hora', sum(pre_unitario) 'Monto total'";
            query += " from clientes c join tickets t on c.id_cliente=t.id_cajero join detalles_ticket d on t.Nro_ticket=d.Nro_ticket";
            query += " where fecha between '" + dtpconsulta1a.Value.ToString("yyyy/MM/dd") + "' and '" + dtpconsulta1b.Value.ToString("yyyy/MM/dd") + "' and hora>'22:00:00'";
            query += " group by c.id_cliente, fecha, hora, nom_cliente, ape_cliente";
            query += " having sum(pre_unitario)>( select avg(pre_unitario)";
            query += " from detalles_ticket)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);

            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;

            DataTable tabla = new DataTable();
            //tabla.Load(comando.ExecuteReader());
            conexion.Close();
            adaptador.Fill(tabla);
            dgvpeliculas.DataSource = tabla;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar2_Click(object sender, EventArgs e)
        {
            string query2 = "";
            query2 += "SELECT c.Id_cliente 'Codigo',c.nom_cliente+' '+c.ape_cliente Cliente, id_pelicula, titulo,s.Nro_sala,f.Id_funcion, d.pre_unitario";
            query2 += " FROM clientes c JOIN tickets t ON c.id_cliente=t.id_cliente";
            query2 += " JOIN Detalles_ticket d ON t.Nro_ticket = d.Nro_ticket";
            query2 += " JOIN funciones f ON f.Id_funcion=d.Id_funcion";
            query2 += " JOIN peliculas p ON f.Id_pelicula=p.id_peliculas";
            query2 += " JOIN generos g ON g.Id_genero=p.id_genero";
            query2 += " JOIN salas s ON f.Nro_sala=s.Nro_sala";
            query2 += " WHERE year(t.Fecha)= year(getdate())";
            query2 += " and " + comboBox1.SelectedValue + "=p.id_genero";

            conexion.Open();
            SqlCommand comando = new SqlCommand(query2, conexion);

            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;

            DataTable tabla = new DataTable();
            //tabla.Load(comando.ExecuteReader());
            conexion.Close();
            adaptador.Fill(tabla);
            dgvConsulta2.DataSource = tabla;
        }

        private void btnConsulta3_Click(object sender, EventArgs e)
        {
            string query3 = "";
            query3 += "select c.id_cliente Codigo , c.ape_cliente+' '+c.nom_cliente 'Cliente', b.barrio 'Barrio',";
            query3 += " count (t.Nro_ticket) 'Cantidad de tickets vendidos', sum (pre_unitario) 'Importe Total', min (fecha) 'primer ticket'";
            query3 += " from tickets t, detalles_ticket d, clientes c, Barrios b";
            query3 += " where t.Nro_ticket = d.Nro_ticket";
            query3 += " and c.id_cliente=t.id_cliente and c.id_barrio = b.id_barrio and barrio like '" + txtbarrio.Text + "%'";
            query3 += " group by c.id_cliente, c.ape_cliente+' '+c.nom_cliente, b.barrio";

            conexion.Open();
            SqlCommand comando = new SqlCommand(query3, conexion);

            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;

            DataTable tabla = new DataTable();
            //tabla.Load(comando.ExecuteReader());
            conexion.Close();
            adaptador.Fill(tabla);
            dgvbarrios.DataSource = tabla;
        }

        private void btnConsultar4_Click(object sender, EventArgs e)
        {
            string query4 = "";
            query4 += "SELECT t.Nro_ticket 'Numero de ticket', FORMAT(fecha,'dd/MM/yy') Fecha, SUM(dt.Pre_unitario) 'Importe Total', c.nom_cliente+','+c.ape_cliente 'Cliente'";
            query4 += " FROM Clientes c join tickets t on c.id_cliente=t.id_cliente join Detalles_ticket dt on t.Nro_ticket=dt.Nro_ticket";
            query4 += " WHERE fecha between '" + dateTimePicker3.Value + "' and '" + dateTimePicker4.Value + "'";
            query4 += " GROUP BY t.Nro_ticket, t.fecha, c.nom_cliente,c.ape_cliente";
            query4 += " HAVING SUM(dt.Pre_unitario)<=" + txtprecio.Text + " ORDER BY 2";

            conexion.Open();
            SqlCommand comando = new SqlCommand(query4, conexion);

            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;

            DataTable tabla = new DataTable();

            conexion.Close();
            adaptador.Fill(tabla);
            dgvconsulta4.DataSource = tabla;


        }

        private void btnCajeros_Click(object sender, EventArgs e)
        {
            string query5 = "";
            query5 += "SELECT ca.Id_cajero 'Codigo', ca.nom_cajero+' '+ca.ape_cajero 'Vendedor',";
            query5 += " count(Nro_ticket)'Cant. de Ticket', min(FORMAT(fecha,'dd/MM/yy')) 'Primer ticket'";
            query5 += " FROM cajeros ca join tickets t on ca.id_cajero=t.id_cajero";
            query5 += " WHERE ca.id_cajero=" + cboCajeros.SelectedValue + "";
            query5 += " group by ca.Id_cajero, ca.nom_cajero+' '+ca.ape_cajero";

            conexion.Open();
            SqlCommand comando = new SqlCommand(query5, conexion);

            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;

            DataTable tabla = new DataTable();

            conexion.Close();
            adaptador.Fill(tabla);
            dgvCajeros.DataSource = tabla;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnConsulta6_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "exec sp_nombre_procedimiento " + cboTipoCliente.SelectedValue + ",'" + dateTimePicker1.Value + "','" + dateTimePicker2.Value + "'";
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            dgvtipo.DataSource = tabla;

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtbarrio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private bool ValidarDatos()
        {
            if (txtbarrio.Text == "")
            {
                MessageBox.Show("Ingrese barrio");
                txtbarrio.Focus();
                return false;
            }
            if (txtprecio.Text == "")
            {
                MessageBox.Show("Ingrese precio");
                txtprecio.Focus();
                return false;
            }

            return true;
        }
    }
}
