﻿namespace IUFormularios
{
    partial class FrmMainTaller
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
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.BtnRetiro = new System.Windows.Forms.Button();
            this.TxtConsulta = new System.Windows.Forms.TextBox();
            this.TxtRetiro = new System.Windows.Forms.TextBox();
            this.txtMensajeCajero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.Location = new System.Drawing.Point(52, 50);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(75, 23);
            this.BtnConsulta.TabIndex = 0;
            this.BtnConsulta.Text = "Consulta";
            this.BtnConsulta.UseVisualStyleBackColor = true;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // BtnRetiro
            // 
            this.BtnRetiro.Location = new System.Drawing.Point(53, 93);
            this.BtnRetiro.Name = "BtnRetiro";
            this.BtnRetiro.Size = new System.Drawing.Size(75, 23);
            this.BtnRetiro.TabIndex = 1;
            this.BtnRetiro.Text = "Retiro";
            this.BtnRetiro.UseVisualStyleBackColor = true;
            this.BtnRetiro.Click += new System.EventHandler(this.BtnRetiro_Click);
            // 
            // TxtConsulta
            // 
            this.TxtConsulta.Location = new System.Drawing.Point(165, 51);
            this.TxtConsulta.Name = "TxtConsulta";
            this.TxtConsulta.Size = new System.Drawing.Size(100, 23);
            this.TxtConsulta.TabIndex = 2;
            // 
            // TxtRetiro
            // 
            this.TxtRetiro.Location = new System.Drawing.Point(165, 96);
            this.TxtRetiro.Name = "TxtRetiro";
            this.TxtRetiro.Size = new System.Drawing.Size(100, 23);
            this.TxtRetiro.TabIndex = 3;
            // 
            // txtMensajeCajero
            // 
            this.txtMensajeCajero.Location = new System.Drawing.Point(52, 143);
            this.txtMensajeCajero.Multiline = true;
            this.txtMensajeCajero.Name = "txtMensajeCajero";
            this.txtMensajeCajero.Size = new System.Drawing.Size(354, 48);
            this.txtMensajeCajero.TabIndex = 4;
            // 
            // FrmMainTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 341);
            this.Controls.Add(this.txtMensajeCajero);
            this.Controls.Add(this.TxtRetiro);
            this.Controls.Add(this.TxtConsulta);
            this.Controls.Add(this.BtnRetiro);
            this.Controls.Add(this.BtnConsulta);
            this.Name = "FrmMainTaller";
            this.Text = "Taller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.Button BtnRetiro;
        private System.Windows.Forms.TextBox TxtConsulta;
        private System.Windows.Forms.TextBox TxtRetiro;
        private System.Windows.Forms.TextBox txtMensajeCajero;
    }
}