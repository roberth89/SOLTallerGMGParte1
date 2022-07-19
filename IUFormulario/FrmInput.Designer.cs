namespace IUFormularios
{
    partial class FrmInput
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
            this.TxtNumero1 = new System.Windows.Forms.TextBox();
            this.TxtNumero2 = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNumero1
            // 
            this.TxtNumero1.Location = new System.Drawing.Point(25, 33);
            this.TxtNumero1.Name = "TxtNumero1";
            this.TxtNumero1.Size = new System.Drawing.Size(100, 23);
            this.TxtNumero1.TabIndex = 0;
            // 
            // TxtNumero2
            // 
            this.TxtNumero2.Location = new System.Drawing.Point(155, 33);
            this.TxtNumero2.Name = "TxtNumero2";
            this.TxtNumero2.Size = new System.Drawing.Size(100, 23);
            this.TxtNumero2.TabIndex = 1;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(276, 33);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 2;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // FrmInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 91);
            this.ControlBox = false;
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxtNumero2);
            this.Controls.Add(this.TxtNumero1);
            this.Name = "FrmInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInput";
            this.Load += new System.EventHandler(this.FrmInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNumero1;
        private System.Windows.Forms.TextBox TxtNumero2;
        private System.Windows.Forms.Button BtnAceptar;
    }
}