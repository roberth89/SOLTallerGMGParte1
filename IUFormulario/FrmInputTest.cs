using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUFormularios
{
    public partial class FrmInputTest : Form
    {
        public FrmInputTest()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            FrmMainTaller frmMainTaller = Owner as FrmMainTaller;
            frmMainTaller.Numero1 = Convert.ToInt32(TxtNumero1.Text);
            this.Close();
        }
    }
}
