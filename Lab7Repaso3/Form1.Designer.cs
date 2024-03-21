
namespace ControlPagosCondominio
{
    partial class MainForm
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
            this.dgvPropiedades = new System.Windows.Forms.DataGridView();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnCuotasAltas = new System.Windows.Forms.Button();
            this.btnPropietarioMasAlta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropiedades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPropiedades
            // 
            this.dgvPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropiedades.Location = new System.Drawing.Point(261, 34);
            this.dgvPropiedades.Name = "dgvPropiedades";
            this.dgvPropiedades.Size = new System.Drawing.Size(240, 150);
            this.dgvPropiedades.TabIndex = 0;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(202, 228);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "button1";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            // 
            // btnCuotasAltas
            // 
            this.btnCuotasAltas.Location = new System.Drawing.Point(346, 228);
            this.btnCuotasAltas.Name = "btnCuotasAltas";
            this.btnCuotasAltas.Size = new System.Drawing.Size(75, 23);
            this.btnCuotasAltas.TabIndex = 2;
            this.btnCuotasAltas.Text = "button2";
            this.btnCuotasAltas.UseVisualStyleBackColor = true;
            // 
            // btnPropietarioMasAlta
            // 
            this.btnPropietarioMasAlta.Location = new System.Drawing.Point(508, 228);
            this.btnPropietarioMasAlta.Name = "btnPropietarioMasAlta";
            this.btnPropietarioMasAlta.Size = new System.Drawing.Size(75, 23);
            this.btnPropietarioMasAlta.TabIndex = 3;
            this.btnPropietarioMasAlta.Text = "button3";
            this.btnPropietarioMasAlta.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPropietarioMasAlta);
            this.Controls.Add(this.btnCuotasAltas);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.dgvPropiedades);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropiedades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPropiedades;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnCuotasAltas;
        private System.Windows.Forms.Button btnPropietarioMasAlta;
    }
}

