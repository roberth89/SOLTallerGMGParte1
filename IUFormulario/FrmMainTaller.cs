﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IUFormularios
{
    public partial class FrmMainTaller : Form
    {

        LogicaNegocio.Cajero _objCajero = new LogicaNegocio.Cajero();

        public FrmMainTaller()
        {
            InitializeComponent();
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            TxtConsulta.Text = _objCajero.DineroActual.ToString();

        }

        private void TomarCaptura()
        {
            int cero = 0;
            decimal error = 8 / cero;
        }

        private void RetirarDinero()
        {
            string montoRetiro = TxtRetiro.Text;
            string mensajeRetorno = string.Empty;
            decimal valorRetorno = 0;
            valorRetorno = _objCajero.RetirarDinero(Convert.ToDecimal(montoRetiro), ref mensajeRetorno);
            TxtConsulta.Text = valorRetorno.ToString();
            txtMensajeCajero.Text = mensajeRetorno;
        }
            

        private void BtnRetiro_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    TomarCaptura();
                }
                catch (Exception ex)
                {
                    txtMensajeCajero.Text = ex.Message;
                }
                RetirarDinero();
            }            
            catch (Exception ex)
            {
                txtMensajeCajero.Text = ex.Message;
            }
        }
    }
}