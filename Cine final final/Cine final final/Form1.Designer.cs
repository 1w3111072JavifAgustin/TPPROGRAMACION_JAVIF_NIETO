namespace Cine_final_final
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvtipo = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cboTipoCliente = new System.Windows.Forms.ComboBox();
            this.btnConsulta6 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCajeros = new System.Windows.Forms.Button();
            this.dgvCajeros = new System.Windows.Forms.DataGridView();
            this.cboCajeros = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvconsulta4 = new System.Windows.Forms.DataGridView();
            this.btnConsultar4 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConsulta3 = new System.Windows.Forms.Button();
            this.dgvbarrios = new System.Windows.Forms.DataGridView();
            this.txtbarrio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvConsulta2 = new System.Windows.Forms.DataGridView();
            this.btnConsultar2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpconsulta1b = new System.Windows.Forms.DateTimePicker();
            this.dtpconsulta1a = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvpeliculas = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtipo)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajeros)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta4)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbarrios)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpeliculas)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage6
            // 
            this.tabPage6.BackgroundImage = global::Cine_final_final.Properties.Resources._1;
            this.tabPage6.Controls.Add(this.label13);
            this.tabPage6.Controls.Add(this.dgvtipo);
            this.tabPage6.Controls.Add(this.label12);
            this.tabPage6.Controls.Add(this.dateTimePicker2);
            this.tabPage6.Controls.Add(this.dateTimePicker1);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.cboTipoCliente);
            this.tabPage6.Controls.Add(this.btnConsulta6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(723, 397);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Consulta 6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(72, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(576, 40);
            this.label13.TabIndex = 7;
            this.label13.Text = "De acuerdo al tipo de cliente, mostrar la cantidad de veces que asistieron al cin" +
    "e \r\ny cuanto gastaron en un determinado periodo de tiempo\r\n";
            // 
            // dgvtipo
            // 
            this.dgvtipo.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvtipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtipo.Location = new System.Drawing.Point(121, 230);
            this.dgvtipo.Name = "dgvtipo";
            this.dgvtipo.Size = new System.Drawing.Size(447, 78);
            this.dgvtipo.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(358, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "----";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(408, 179);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(230, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(86, 180);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(173, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tipo de Cliente";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // cboTipoCliente
            // 
            this.cboTipoCliente.FormattingEnabled = true;
            this.cboTipoCliente.Location = new System.Drawing.Point(361, 113);
            this.cboTipoCliente.Name = "cboTipoCliente";
            this.cboTipoCliente.Size = new System.Drawing.Size(183, 21);
            this.cboTipoCliente.TabIndex = 1;
            // 
            // btnConsulta6
            // 
            this.btnConsulta6.Location = new System.Drawing.Point(290, 329);
            this.btnConsulta6.Name = "btnConsulta6";
            this.btnConsulta6.Size = new System.Drawing.Size(131, 43);
            this.btnConsulta6.TabIndex = 0;
            this.btnConsulta6.Text = "Consultar";
            this.btnConsulta6.UseVisualStyleBackColor = true;
            this.btnConsulta6.Click += new System.EventHandler(this.btnConsulta6_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackgroundImage = global::Cine_final_final.Properties.Resources._1;
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.btnCajeros);
            this.tabPage5.Controls.Add(this.dgvCajeros);
            this.tabPage5.Controls.Add(this.cboCajeros);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(723, 397);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Consulta 5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(6, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(706, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Realizar una lista de las facturas emitidas por cada cajero indicando su primer v" +
    "enta";
            // 
            // btnCajeros
            // 
            this.btnCajeros.Location = new System.Drawing.Point(269, 323);
            this.btnCajeros.Name = "btnCajeros";
            this.btnCajeros.Size = new System.Drawing.Size(242, 32);
            this.btnCajeros.TabIndex = 3;
            this.btnCajeros.Text = "Consultar";
            this.btnCajeros.UseVisualStyleBackColor = true;
            this.btnCajeros.Click += new System.EventHandler(this.btnCajeros_Click);
            // 
            // dgvCajeros
            // 
            this.dgvCajeros.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvCajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCajeros.Location = new System.Drawing.Point(159, 193);
            this.dgvCajeros.Name = "dgvCajeros";
            this.dgvCajeros.Size = new System.Drawing.Size(451, 90);
            this.dgvCajeros.TabIndex = 2;
            // 
            // cboCajeros
            // 
            this.cboCajeros.FormattingEnabled = true;
            this.cboCajeros.Location = new System.Drawing.Point(388, 113);
            this.cboCajeros.Name = "cboCajeros";
            this.cboCajeros.Size = new System.Drawing.Size(161, 21);
            this.cboCajeros.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(234, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cajero";
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::Cine_final_final.Properties.Resources._1;
            this.tabPage4.Controls.Add(this.dateTimePicker4);
            this.tabPage4.Controls.Add(this.dateTimePicker3);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.txtprecio);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.dgvconsulta4);
            this.tabPage4.Controls.Add(this.btnConsultar4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(723, 397);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Consulta 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(356, 108);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(187, 20);
            this.dateTimePicker4.TabIndex = 6;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(122, 108);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(187, 20);
            this.dateTimePicker3.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(52, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(625, 40);
            this.label10.TabIndex = 4;
            this.label10.Text = "Liste número de ticket, fecha y cliente para los casos en que \r\nlos montos del co" +
    "mprobante de pago sea menor o igual a 280 entre 2 fechas a eleccion\r\n";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(338, 147);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(225, 20);
            this.txtprecio.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(147, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Comprobante menor a:";
            // 
            // dgvconsulta4
            // 
            this.dgvconsulta4.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvconsulta4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsulta4.Location = new System.Drawing.Point(95, 206);
            this.dgvconsulta4.Name = "dgvconsulta4";
            this.dgvconsulta4.Size = new System.Drawing.Size(500, 97);
            this.dgvconsulta4.TabIndex = 1;
            // 
            // btnConsultar4
            // 
            this.btnConsultar4.Location = new System.Drawing.Point(267, 322);
            this.btnConsultar4.Name = "btnConsultar4";
            this.btnConsultar4.Size = new System.Drawing.Size(184, 49);
            this.btnConsultar4.TabIndex = 0;
            this.btnConsultar4.Text = "Consultar";
            this.btnConsultar4.UseVisualStyleBackColor = true;
            this.btnConsultar4.Click += new System.EventHandler(this.btnConsultar4_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::Cine_final_final.Properties.Resources._1;
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.btnConsulta3);
            this.tabPage3.Controls.Add(this.dgvbarrios);
            this.tabPage3.Controls.Add(this.txtbarrio);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(723, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consulta 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(112, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(509, 60);
            this.label8.TabIndex = 5;
            this.label8.Text = "Mostrar la cantidad total de tickets vendidos, el importe total vendido\r\ny la fec" +
    "ha del primer ticket por cliente siempre y cuando sean de barrios\r\nque comiencen" +
    " la letra “a”\r\n";
            // 
            // btnConsulta3
            // 
            this.btnConsulta3.Location = new System.Drawing.Point(289, 322);
            this.btnConsulta3.Name = "btnConsulta3";
            this.btnConsulta3.Size = new System.Drawing.Size(164, 42);
            this.btnConsulta3.TabIndex = 3;
            this.btnConsulta3.Text = "Consulta";
            this.btnConsulta3.UseVisualStyleBackColor = true;
            this.btnConsulta3.Click += new System.EventHandler(this.btnConsulta3_Click);
            // 
            // dgvbarrios
            // 
            this.dgvbarrios.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvbarrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbarrios.Location = new System.Drawing.Point(76, 164);
            this.dgvbarrios.Name = "dgvbarrios";
            this.dgvbarrios.Size = new System.Drawing.Size(595, 133);
            this.dgvbarrios.TabIndex = 2;
            // 
            // txtbarrio
            // 
            this.txtbarrio.Location = new System.Drawing.Point(403, 106);
            this.txtbarrio.Name = "txtbarrio";
            this.txtbarrio.Size = new System.Drawing.Size(144, 20);
            this.txtbarrio.TabIndex = 1;
            this.txtbarrio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbarrio_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(149, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Primer letra del barrio";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Cine_final_final.Properties.Resources._1;
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dgvConsulta2);
            this.tabPage2.Controls.Add(this.btnConsultar2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(723, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(144, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 60);
            this.label3.TabIndex = 4;
            this.label3.Text = "Haga un listado de los clientes que compraron entradas para\r\npeliculas de thrille" +
    "r este año, y ademas mostrar en que sala se\r\nemitieron y el precio";
            // 
            // dgvConsulta2
            // 
            this.dgvConsulta2.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvConsulta2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta2.Location = new System.Drawing.Point(95, 199);
            this.dgvConsulta2.Name = "dgvConsulta2";
            this.dgvConsulta2.Size = new System.Drawing.Size(548, 95);
            this.dgvConsulta2.TabIndex = 3;
            // 
            // btnConsultar2
            // 
            this.btnConsultar2.Location = new System.Drawing.Point(255, 322);
            this.btnConsultar2.Name = "btnConsultar2";
            this.btnConsultar2.Size = new System.Drawing.Size(207, 52);
            this.btnConsultar2.TabIndex = 2;
            this.btnConsultar2.Text = "Consultar";
            this.btnConsultar2.UseVisualStyleBackColor = true;
            this.btnConsultar2.Click += new System.EventHandler(this.btnConsultar2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(145, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Genero";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(223, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(281, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BackgroundImage = global::Cine_final_final.Properties.Resources._1;
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtpconsulta1b);
            this.tabPage1.Controls.Add(this.dtpconsulta1a);
            this.tabPage1.Controls.Add(this.btnConsultar);
            this.tabPage1.Controls.Add(this.dgvpeliculas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(723, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(372, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "-----";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(654, 60);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // dtpconsulta1b
            // 
            this.dtpconsulta1b.Location = new System.Drawing.Point(419, 122);
            this.dtpconsulta1b.Name = "dtpconsulta1b";
            this.dtpconsulta1b.Size = new System.Drawing.Size(220, 20);
            this.dtpconsulta1b.TabIndex = 3;
            // 
            // dtpconsulta1a
            // 
            this.dtpconsulta1a.Location = new System.Drawing.Point(106, 122);
            this.dtpconsulta1a.Name = "dtpconsulta1a";
            this.dtpconsulta1a.Size = new System.Drawing.Size(246, 20);
            this.dtpconsulta1a.TabIndex = 2;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(295, 332);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(160, 36);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvpeliculas
            // 
            this.dgvpeliculas.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvpeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpeliculas.Location = new System.Drawing.Point(106, 206);
            this.dgvpeliculas.Name = "dgvpeliculas";
            this.dgvpeliculas.Size = new System.Drawing.Size(533, 81);
            this.dgvpeliculas.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(2, 6);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(731, 423);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 425);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtipo)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajeros)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta4)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbarrios)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpeliculas)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvtipo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboTipoCliente;
        private System.Windows.Forms.Button btnConsulta6;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCajeros;
        private System.Windows.Forms.DataGridView dgvCajeros;
        private System.Windows.Forms.ComboBox cboCajeros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvconsulta4;
        private System.Windows.Forms.Button btnConsultar4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConsulta3;
        private System.Windows.Forms.DataGridView dgvbarrios;
        private System.Windows.Forms.TextBox txtbarrio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvConsulta2;
        private System.Windows.Forms.Button btnConsultar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpconsulta1b;
        private System.Windows.Forms.DateTimePicker dtpconsulta1a;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvpeliculas;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

