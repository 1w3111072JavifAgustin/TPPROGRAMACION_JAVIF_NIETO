namespace Cine_final_final
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peliculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasLabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::Cine_final_final.Properties.Resources._1;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.informesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(112, 274);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.nuevoToolStripMenuItem.BackgroundImage = global::Cine_final_final.Properties.Resources._1;
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peliculaToolStripMenuItem});
            this.nuevoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Paint += new System.Windows.Forms.PaintEventHandler(this.nuevoToolStripMenuItem_Paint);
            // 
            // peliculaToolStripMenuItem
            // 
            this.peliculaToolStripMenuItem.BackgroundImage = global::Cine_final_final.Properties.Resources._1;
            this.peliculaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.peliculaToolStripMenuItem.Name = "peliculaToolStripMenuItem";
            this.peliculaToolStripMenuItem.Size = new System.Drawing.Size(149, 30);
            this.peliculaToolStripMenuItem.Text = "Pelicula";
            this.peliculaToolStripMenuItem.Click += new System.EventHandler(this.peliculaToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasLabToolStripMenuItem});
            this.consultasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultasLabToolStripMenuItem
            // 
            this.consultasLabToolStripMenuItem.BackgroundImage = global::Cine_final_final.Properties.Resources._1;
            this.consultasLabToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.consultasLabToolStripMenuItem.Name = "consultasLabToolStripMenuItem";
            this.consultasLabToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.consultasLabToolStripMenuItem.Text = "Consultas Lab";
            this.consultasLabToolStripMenuItem.Click += new System.EventHandler(this.consultasLabToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peliculasToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.cajerosToolStripMenuItem});
            this.informesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.informesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // peliculasToolStripMenuItem
            // 
            this.peliculasToolStripMenuItem.BackgroundImage = global::Cine_final_final.Properties.Resources._1;
            this.peliculasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.peliculasToolStripMenuItem.Name = "peliculasToolStripMenuItem";
            this.peliculasToolStripMenuItem.Size = new System.Drawing.Size(157, 30);
            this.peliculasToolStripMenuItem.Text = "Peliculas";
            this.peliculasToolStripMenuItem.Click += new System.EventHandler(this.peliculasToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.BackgroundImage = global::Cine_final_final.Properties.Resources._1;
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(157, 30);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // cajerosToolStripMenuItem
            // 
            this.cajerosToolStripMenuItem.BackgroundImage = global::Cine_final_final.Properties.Resources._1;
            this.cajerosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cajerosToolStripMenuItem.Name = "cajerosToolStripMenuItem";
            this.cajerosToolStripMenuItem.Size = new System.Drawing.Size(157, 30);
            this.cajerosToolStripMenuItem.Text = "Cajeros";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = global::Cine_final_final.Properties.Resources._1;
            this.btnSalir.ForeColor = System.Drawing.Color.Transparent;
            this.btnSalir.Location = new System.Drawing.Point(384, 214);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(134, 48);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cine_final_final.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(557, 274);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuPrincipal";
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peliculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peliculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasLabToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.Button btnSalir;
    }
}