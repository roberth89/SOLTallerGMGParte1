using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUFormularios
{
    public partial class FrmInput : Form
    {

      
        public FrmInput(
                        string titulo = "Ejemplo recibir numeros")
        {
            InitializeComponent();
            this.Text = titulo;
           
        }

        private void FrmInput_Load(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            FrmMainTaller frmMainTaller = Owner as FrmMainTaller;
            frmMainTaller.Numero1 = Convert.ToInt32(TxtNumero1.Text);
            frmMainTaller.Numero2 = Convert.ToInt32(TxtNumero2.Text);

            this.Close();

        }
    }
}
