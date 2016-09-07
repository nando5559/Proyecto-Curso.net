namespace BPeliculasActualizada
{
    partial class ActoresYDirectoresForm
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
            this.NombreText = new System.Windows.Forms.TextBox();
            this.ApellidoText = new System.Windows.Forms.TextBox();
            this.FechaDeNacimientoText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NombreText
            // 
            this.NombreText.Location = new System.Drawing.Point(340, 71);
            this.NombreText.Name = "NombreText";
            this.NombreText.Size = new System.Drawing.Size(158, 20);
            this.NombreText.TabIndex = 0;
            // 
            // ApellidoText
            // 
            this.ApellidoText.Location = new System.Drawing.Point(340, 141);
            this.ApellidoText.Name = "ApellidoText";
            this.ApellidoText.Size = new System.Drawing.Size(158, 20);
            this.ApellidoText.TabIndex = 1;
            // 
            // FechaDeNacimientoText
            // 
            this.FechaDeNacimientoText.Location = new System.Drawing.Point(340, 214);
            this.FechaDeNacimientoText.Name = "FechaDeNacimientoText";
            this.FechaDeNacimientoText.Size = new System.Drawing.Size(158, 20);
            this.FechaDeNacimientoText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha De Nacimiento bb/bb/bbbb";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(409, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ActoresYDirectoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 403);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechaDeNacimientoText);
            this.Controls.Add(this.ApellidoText);
            this.Controls.Add(this.NombreText);
            this.Name = "ActoresYDirectoresForm";
            this.Text = "ActoresYDirectoresForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreText;
        private System.Windows.Forms.TextBox ApellidoText;
        private System.Windows.Forms.TextBox FechaDeNacimientoText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}