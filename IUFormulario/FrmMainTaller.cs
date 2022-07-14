using System;
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
        List<Modelo.Persona> _listaPersonas = new List<Modelo.Persona>();

        private const string SEPARADOR = "---";

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

        private string RetirarDinero()
        {
            string montoRetiro = TxtRetiro.Text;
            string mensajeRetorno = string.Empty;
            decimal valorRetorno = 0;
            valorRetorno = _objCajero.RetirarDinero(Convert.ToDecimal(montoRetiro), ref mensajeRetorno);
            TxtConsulta.Text = valorRetorno.ToString();
            txtMensajeCajero.Text = mensajeRetorno;
            return mensajeRetorno;
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
                string mensajeCajero = "";
                mensajeCajero = RetirarDinero();


                DateTime fechaTransaccion = DateTime.Now;
                Modelo.Persona objPersona = new Modelo.Persona
                {
                    Identificacion = TxtIdentificacion.Text,
                    Nombre = TxtNombre.Text,
                    PrimerApellido = TxtApellido1.Text,
                    SegundoApellido = TxtApellido2.Text,
                    FechaTransaccion = fechaTransaccion,
                    MontoTransaccion = Convert.ToDecimal(TxtRetiro.Text),
                    Mensaje = mensajeCajero

                };

                _listaPersonas.Add(objPersona);
                TxtListaPersonas.Text = "";
                // 4 La lista de personas vamos a agregarlo al TxtListaPersonas
                foreach (Modelo.Persona item in _listaPersonas)
                {
                    //TxtListaPersonas.Text = "";

                    TxtListaPersonas.Text += item.Identificacion + SEPARADOR;
                    TxtListaPersonas.Text += item.FechaTransaccion + SEPARADOR;
                    TxtListaPersonas.Text += item.Nombre + " " + item.PrimerApellido + " " + item.SegundoApellido + SEPARADOR;
                    TxtListaPersonas.Text += item.MontoTransaccion + SEPARADOR;
                    TxtListaPersonas.Text += item.Mensaje + SEPARADOR;
                    TxtListaPersonas.Text += "\n"; // Tarea investigar salto de linea.
                }



            }
            catch (Exception ex)
            {
                txtMensajeCajero.Text = ex.Message;
            }
        }

        private void BtnArray_Click(object sender, EventArgs e)
        {
            string[] resultadoLista;
            string mensaje = string.Empty;
            resultadoLista = LogicaNegocio.Lista.ListaArray();

            for (int i = 0; i < resultadoLista.Length; i++)
            {
                mensaje = mensaje + "--" + resultadoLista[i];
                // mensaje += resultadoLista[i];
            }

            TxtListaArray.Text = mensaje;

        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            List<string> resultadoList = LogicaNegocio.Lista.ListEjemlo();
            string mensaje = string.Empty;

            foreach (var objLista in resultadoList)
            {
                mensaje = mensaje + "--" + objLista.ToString();
            }

            TxtList.Text = mensaje;

        }

        private void TxtRetiro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
