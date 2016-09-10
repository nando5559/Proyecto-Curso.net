namespace BPeliculasActualizada
{
    partial class MostrarPersonasForm
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
            this.MostrarPersonas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // MostrarPersonas
            // 
            this.MostrarPersonas.AllowUserToOrderColumns = true;
            this.MostrarPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MostrarPersonas.Location = new System.Drawing.Point(49, 44);
            this.MostrarPersonas.Name = "MostrarPersonas";
            this.MostrarPersonas.Size = new System.Drawing.Size(761, 316);
            this.MostrarPersonas.TabIndex = 0;
            // 
            // MostrarPersonasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 416);
            this.Controls.Add(this.MostrarPersonas);
            this.Name = "MostrarPersonasForm";
            this.Text = "MostrarPersonasForm";
            this.Load += new System.EventHandler(this.MostrarPersonasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MostrarPersonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MostrarPersonas;
    }
}