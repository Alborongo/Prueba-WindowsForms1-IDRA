
namespace BotoneraBananera
{
    partial class frm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1));
            this.btnPalanca = new System.Windows.Forms.Button();
            this.lblWin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPalanca
            // 
            this.btnPalanca.BackColor = System.Drawing.Color.Transparent;
            this.btnPalanca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPalanca.BackgroundImage")));
            this.btnPalanca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPalanca.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnPalanca.FlatAppearance.BorderSize = 0;
            this.btnPalanca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPalanca.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPalanca.Location = new System.Drawing.Point(458, 190);
            this.btnPalanca.Name = "btnPalanca";
            this.btnPalanca.Size = new System.Drawing.Size(32, 23);
            this.btnPalanca.TabIndex = 0;
            this.btnPalanca.UseVisualStyleBackColor = false;
            this.btnPalanca.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.BackColor = System.Drawing.Color.Transparent;
            this.lblWin.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.ForeColor = System.Drawing.Color.Navy;
            this.lblWin.Location = new System.Drawing.Point(428, 230);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(170, 31);
            this.lblWin.TabIndex = 1;
            this.lblWin.Text = "FFShhhhhhuu";
            this.lblWin.Visible = false;
            // 
            // frm1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(702, 433);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.btnPalanca);
            this.Location = new System.Drawing.Point(50, 50);
            this.MaximumSize = new System.Drawing.Size(720, 480);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "frm1";
            this.Text = "cagON \"Apretá el BOTÓN\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPalanca;
        private System.Windows.Forms.Label lblWin;
    }
}

