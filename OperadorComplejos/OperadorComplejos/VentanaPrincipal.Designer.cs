namespace OperadorComplejos
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cocienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.potenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fasoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(419, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaToolStripMenuItem,
            this.restaToolStripMenuItem,
            this.mulToolStripMenuItem,
            this.cocienteToolStripMenuItem,
            this.potenciaToolStripMenuItem,
            this.radicaciónToolStripMenuItem,
            this.fasoresToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // sumaToolStripMenuItem
            // 
            this.sumaToolStripMenuItem.Name = "sumaToolStripMenuItem";
            this.sumaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sumaToolStripMenuItem.Text = "Suma";
            this.sumaToolStripMenuItem.Click += new System.EventHandler(this.sumaToolStripMenuItem_Click);
            // 
            // restaToolStripMenuItem
            // 
            this.restaToolStripMenuItem.Name = "restaToolStripMenuItem";
            this.restaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.restaToolStripMenuItem.Text = "Resta";
            this.restaToolStripMenuItem.Click += new System.EventHandler(this.restaToolStripMenuItem_Click);
            // 
            // mulToolStripMenuItem
            // 
            this.mulToolStripMenuItem.Name = "mulToolStripMenuItem";
            this.mulToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mulToolStripMenuItem.Text = "Multiplicación";
            this.mulToolStripMenuItem.Click += new System.EventHandler(this.mulToolStripMenuItem_Click);
            // 
            // cocienteToolStripMenuItem
            // 
            this.cocienteToolStripMenuItem.Name = "cocienteToolStripMenuItem";
            this.cocienteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cocienteToolStripMenuItem.Text = "Cociente";
            this.cocienteToolStripMenuItem.Click += new System.EventHandler(this.cocienteToolStripMenuItem_Click);
            // 
            // potenciaToolStripMenuItem
            // 
            this.potenciaToolStripMenuItem.Name = "potenciaToolStripMenuItem";
            this.potenciaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.potenciaToolStripMenuItem.Text = "Potencia";
            this.potenciaToolStripMenuItem.Click += new System.EventHandler(this.potenciaToolStripMenuItem_Click);
            // 
            // radicaciónToolStripMenuItem
            // 
            this.radicaciónToolStripMenuItem.Name = "radicaciónToolStripMenuItem";
            this.radicaciónToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.radicaciónToolStripMenuItem.Text = "Radicación";
            this.radicaciónToolStripMenuItem.Click += new System.EventHandler(this.radicaciónToolStripMenuItem_Click);
            // 
            // fasoresToolStripMenuItem
            // 
            this.fasoresToolStripMenuItem.Name = "fasoresToolStripMenuItem";
            this.fasoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fasoresToolStripMenuItem.Text = "Fasores";
            this.fasoresToolStripMenuItem.Click += new System.EventHandler(this.fasoresToolStripMenuItem_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 257);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaPrincipal";
            this.Text = "WesselSoft";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cocienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem potenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fasoresToolStripMenuItem;
    }
}