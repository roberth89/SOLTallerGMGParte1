namespace IUFormularios
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
            System.Windows.Forms.Label LblApellido2;
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.BtnRetiro = new System.Windows.Forms.Button();
            this.TxtConsulta = new System.Windows.Forms.TextBox();
            this.TxtRetiro = new System.Windows.Forms.TextBox();
            this.txtMensajeCajero = new System.Windows.Forms.TextBox();
            this.BtnArray = new System.Windows.Forms.Button();
            this.TxtListaArray = new System.Windows.Forms.TextBox();
            this.BtnList = new System.Windows.Forms.Button();
            this.TxtList = new System.Windows.Forms.TextBox();
            this.GrbPractica = new System.Windows.Forms.GroupBox();
            this.TxtApellido2 = new System.Windows.Forms.TextBox();
            this.TxtApellido1 = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.LblApellido1 = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblIdentificacion = new System.Windows.Forms.Label();
            this.TxtListaPersonas = new System.Windows.Forms.TextBox();
            LblApellido2 = new System.Windows.Forms.Label();
            this.GrbPractica.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblApellido2
            // 
            LblApellido2.AutoSize = true;
            LblApellido2.Location = new System.Drawing.Point(31, 117);
            LblApellido2.Name = "LblApellido2";
            LblApellido2.Size = new System.Drawing.Size(60, 15);
            LblApellido2.TabIndex = 3;
            LblApellido2.Text = "Apellido 2";
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.Location = new System.Drawing.Point(12, 12);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(75, 23);
            this.BtnConsulta.TabIndex = 0;
            this.BtnConsulta.Text = "Consulta";
            this.BtnConsulta.UseVisualStyleBackColor = true;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // BtnRetiro
            // 
            this.BtnRetiro.Location = new System.Drawing.Point(241, 28);
            this.BtnRetiro.Name = "BtnRetiro";
            this.BtnRetiro.Size = new System.Drawing.Size(75, 23);
            this.BtnRetiro.TabIndex = 1;
            this.BtnRetiro.Text = "Retiro";
            this.BtnRetiro.UseVisualStyleBackColor = true;
            this.BtnRetiro.Click += new System.EventHandler(this.BtnRetiro_Click);
            // 
            // TxtConsulta
            // 
            this.TxtConsulta.Location = new System.Drawing.Point(109, 12);
            this.TxtConsulta.Name = "TxtConsulta";
            this.TxtConsulta.Size = new System.Drawing.Size(100, 23);
            this.TxtConsulta.TabIndex = 2;
            // 
            // TxtRetiro
            // 
            this.TxtRetiro.Location = new System.Drawing.Point(338, 28);
            this.TxtRetiro.Name = "TxtRetiro";
            this.TxtRetiro.Size = new System.Drawing.Size(100, 23);
            this.TxtRetiro.TabIndex = 3;
            this.TxtRetiro.TextChanged += new System.EventHandler(this.TxtRetiro_TextChanged);
            // 
            // txtMensajeCajero
            // 
            this.txtMensajeCajero.Location = new System.Drawing.Point(12, 105);
            this.txtMensajeCajero.Multiline = true;
            this.txtMensajeCajero.Name = "txtMensajeCajero";
            this.txtMensajeCajero.Size = new System.Drawing.Size(354, 48);
            this.txtMensajeCajero.TabIndex = 4;
            // 
            // BtnArray
            // 
            this.BtnArray.Location = new System.Drawing.Point(12, 170);
            this.BtnArray.Name = "BtnArray";
            this.BtnArray.Size = new System.Drawing.Size(75, 23);
            this.BtnArray.TabIndex = 5;
            this.BtnArray.Text = "Lista Array";
            this.BtnArray.UseVisualStyleBackColor = true;
            this.BtnArray.Click += new System.EventHandler(this.BtnArray_Click);
            // 
            // TxtListaArray
            // 
            this.TxtListaArray.Location = new System.Drawing.Point(99, 170);
            this.TxtListaArray.Name = "TxtListaArray";
            this.TxtListaArray.Size = new System.Drawing.Size(267, 23);
            this.TxtListaArray.TabIndex = 6;
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(12, 211);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(75, 23);
            this.BtnList.TabIndex = 7;
            this.BtnList.Text = "List";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // TxtList
            // 
            this.TxtList.Location = new System.Drawing.Point(99, 212);
            this.TxtList.Name = "TxtList";
            this.TxtList.Size = new System.Drawing.Size(267, 23);
            this.TxtList.TabIndex = 8;
            // 
            // GrbPractica
            // 
            this.GrbPractica.Controls.Add(this.TxtListaPersonas);
            this.GrbPractica.Controls.Add(this.TxtApellido2);
            this.GrbPractica.Controls.Add(this.TxtApellido1);
            this.GrbPractica.Controls.Add(this.TxtNombre);
            this.GrbPractica.Controls.Add(this.TxtIdentificacion);
            this.GrbPractica.Controls.Add(LblApellido2);
            this.GrbPractica.Controls.Add(this.TxtRetiro);
            this.GrbPractica.Controls.Add(this.LblApellido1);
            this.GrbPractica.Controls.Add(this.LblNombre);
            this.GrbPractica.Controls.Add(this.BtnRetiro);
            this.GrbPractica.Controls.Add(this.LblIdentificacion);
            this.GrbPractica.Location = new System.Drawing.Point(12, 254);
            this.GrbPractica.Name = "GrbPractica";
            this.GrbPractica.Size = new System.Drawing.Size(576, 269);
            this.GrbPractica.TabIndex = 9;
            this.GrbPractica.TabStop = false;
            this.GrbPractica.Text = "Practica 3";
            // 
            // TxtApellido2
            // 
            this.TxtApellido2.Location = new System.Drawing.Point(115, 117);
            this.TxtApellido2.Name = "TxtApellido2";
            this.TxtApellido2.Size = new System.Drawing.Size(100, 23);
            this.TxtApellido2.TabIndex = 7;
            // 
            // TxtApellido1
            // 
            this.TxtApellido1.Location = new System.Drawing.Point(115, 88);
            this.TxtApellido1.Name = "TxtApellido1";
            this.TxtApellido1.Size = new System.Drawing.Size(100, 23);
            this.TxtApellido1.TabIndex = 6;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(115, 59);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 23);
            this.TxtNombre.TabIndex = 5;
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Location = new System.Drawing.Point(115, 28);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(100, 23);
            this.TxtIdentificacion.TabIndex = 4;
            // 
            // LblApellido1
            // 
            this.LblApellido1.AutoSize = true;
            this.LblApellido1.Location = new System.Drawing.Point(28, 88);
            this.LblApellido1.Name = "LblApellido1";
            this.LblApellido1.Size = new System.Drawing.Size(63, 15);
            this.LblApellido1.TabIndex = 2;
            this.LblApellido1.Text = "Apellido 1:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(37, 59);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(54, 15);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblIdentificacion
            // 
            this.LblIdentificacion.AutoSize = true;
            this.LblIdentificacion.Location = new System.Drawing.Point(6, 30);
            this.LblIdentificacion.Name = "LblIdentificacion";
            this.LblIdentificacion.Size = new System.Drawing.Size(85, 15);
            this.LblIdentificacion.TabIndex = 0;
            this.LblIdentificacion.Text = "Identificacion: ";
            // 
            // TxtListaPersonas
            // 
            this.TxtListaPersonas.Location = new System.Drawing.Point(6, 146);
            this.TxtListaPersonas.Multiline = true;
            this.TxtListaPersonas.Name = "TxtListaPersonas";
            this.TxtListaPersonas.Size = new System.Drawing.Size(564, 87);
            this.TxtListaPersonas.TabIndex = 8;
            // 
            // FrmMainTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 567);
            this.Controls.Add(this.GrbPractica);
            this.Controls.Add(this.TxtList);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.TxtListaArray);
            this.Controls.Add(this.BtnArray);
            this.Controls.Add(this.txtMensajeCajero);
            this.Controls.Add(this.TxtConsulta);
            this.Controls.Add(this.BtnConsulta);
            this.Name = "FrmMainTaller";
            this.Text = "Taller";
            this.GrbPractica.ResumeLayout(false);
            this.GrbPractica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.Button BtnRetiro;
        private System.Windows.Forms.TextBox TxtConsulta;
        private System.Windows.Forms.TextBox TxtRetiro;
        private System.Windows.Forms.TextBox txtMensajeCajero;
        private System.Windows.Forms.Button BtnArray;
        private System.Windows.Forms.TextBox TxtListaArray;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.TextBox TxtList;
        private System.Windows.Forms.GroupBox GrbPractica;
        private System.Windows.Forms.TextBox TxtApellido2;
        private System.Windows.Forms.TextBox TxtApellido1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.Label LblApellido1;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblIdentificacion;
        private System.Windows.Forms.TextBox TxtListaPersonas;
    }
}