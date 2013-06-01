namespace OperadorComplejos
{
    partial class VentanaSuma
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
            this.numero1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_rtado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numero2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_resul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numero1
            // 
            this.numero1.Location = new System.Drawing.Point(181, 39);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(75, 20);
            this.numero1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_rtado
            // 
            this.label_rtado.AutoSize = true;
            this.label_rtado.Location = new System.Drawing.Point(194, 127);
            this.label_rtado.Name = "label_rtado";
            this.label_rtado.Size = new System.Drawing.Size(0, 13);
            this.label_rtado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Primer Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Segundo Número";
            // 
            // numero2
            // 
            this.numero2.Location = new System.Drawing.Point(181, 75);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(75, 20);
            this.numero2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "+";
            // 
            // label_resul
            // 
            this.label_resul.AutoSize = true;
            this.label_resul.Location = new System.Drawing.Point(287, 60);
            this.label_resul.Name = "label_resul";
            this.label_resul.Size = new System.Drawing.Size(31, 13);
            this.label_resul.TabIndex = 8;
            this.label_resul.Text = "rtado";
            // 
            // VentanaSuma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 174);
            this.Controls.Add(this.label_resul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_rtado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numero1);
            this.Name = "VentanaSuma";
            this.Text = "Suma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numero1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_rtado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numero2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_resul;
    }
}