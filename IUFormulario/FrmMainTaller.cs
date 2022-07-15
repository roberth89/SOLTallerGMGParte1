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
                    TxtListaPersonas.Text += item.Identificacion + SEPARADOR;
                    TxtListaPersonas.Text += item.FechaTransaccion + SEPARADOR;
                    TxtListaPersonas.Text += item.Nombre + " " + item.PrimerApellido + " " + item.SegundoApellido + SEPARADOR;
                    TxtListaPersonas.Text += item.MontoTransaccion + SEPARADOR;
                    TxtListaPersonas.Text += item.Mensaje + SEPARADOR;
                    TxtListaPersonas.Text += "\r\n";
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

        private void BtnEjemploObjeto_Click(object sender, EventArgs e)
        {
            try
            {
                LlamarEjemploNoGenerico();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnGenerico_Click(object sender, EventArgs e)
        {
            try
            {
                LlamarEjemploGenerico();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void LlamarEjemploNoGenerico()
        {
            LogicaNegocio.AlmacenaObjetoNormal objAlmacenaObjetoNormal = new LogicaNegocio.AlmacenaObjetoNormal(4);

            objAlmacenaObjetoNormal.Agregar("Roberto"); //0
            objAlmacenaObjetoNormal.Agregar("Fernando");
            objAlmacenaObjetoNormal.Agregar("Ray");
            objAlmacenaObjetoNormal.Agregar("Nestor"); // 3
                                                       // int nombrePersona = (int)objAlmacenaObjetoNormal.GetElemento(1);
            string nombrePersona = (string)objAlmacenaObjetoNormal.GetElemento(1);
            MessageBox.Show(nombrePersona);

            LogicaNegocio.AlmacenaObjetoNormal objAlmacenaObjetoNormalPersonas = new LogicaNegocio.AlmacenaObjetoNormal(4);
            objAlmacenaObjetoNormalPersonas.Agregar(new Modelo.Persona { Identificacion = "01", Nombre = "Roberto" });
            objAlmacenaObjetoNormalPersonas.Agregar(new Modelo.Persona { Identificacion = "02", Nombre = "Fernando" });
            objAlmacenaObjetoNormalPersonas.Agregar(new Modelo.Persona { Identificacion = "03", Nombre = "Ray" });
            objAlmacenaObjetoNormalPersonas.Agregar(new Modelo.Persona { Identificacion = "04", Nombre = "Nestor" });

            Modelo.Persona objPersona = (Modelo.Persona)objAlmacenaObjetoNormalPersonas.GetElemento(1);
            MessageBox.Show(objPersona.Nombre + " " + objPersona.Identificacion);

        }

        private void LlamarEjemploGenerico()
        {
            // Ejemplo de clase generica String.
            LogicaNegocio.AlmacenaObjetoGenerico<string> objAlmacenaObjetoGenerico 
                = new LogicaNegocio.AlmacenaObjetoGenerico<string>(4);

            objAlmacenaObjetoGenerico.Agregar("Roberto"); 
            objAlmacenaObjetoGenerico.Agregar("Fernando");
            objAlmacenaObjetoGenerico.Agregar("Ray");
            objAlmacenaObjetoGenerico.Agregar("Nestor"); 
            string nombrePersona = objAlmacenaObjetoGenerico.GetElemento(3);
            MessageBox.Show(nombrePersona);

            // Ejemplo de generico que recibe un objeto persona
            LogicaNegocio.AlmacenaObjetoGenerico<Modelo.Persona> objAlmacenaObjetoGenericoPersonas 
                = new LogicaNegocio.AlmacenaObjetoGenerico<Modelo.Persona>(4);
            objAlmacenaObjetoGenericoPersonas.Agregar(new Modelo.Persona { Identificacion = "01", Nombre = "Roberto" });
            objAlmacenaObjetoGenericoPersonas.Agregar(new Modelo.Persona { Identificacion = "02", Nombre = "Fernando" });
            objAlmacenaObjetoGenericoPersonas.Agregar(new Modelo.Persona { Identificacion = "03", Nombre = "Ray" });
            objAlmacenaObjetoGenericoPersonas.Agregar(new Modelo.Persona { Identificacion = "04", Nombre = "Nestor" });

            Modelo.Persona objPersona = objAlmacenaObjetoGenericoPersonas.GetElemento(3);
            MessageBox.Show(objPersona.Nombre + " " + objPersona.Identificacion);

        }

        private void BtnLinkedList_Click(object sender, EventArgs e)
        {
            var objLinkedList = LogicaNegocio.Lista.LinkedListEjemplo();
            // Tarea , agregar en un control tipo TextBox, para poder tener una represetacion grafica.


        }

        private void BtnCola_Click(object sender, EventArgs e)
        {
            var objCola = LogicaNegocio.Lista.Cola();
            // Tarea , agregar en un control tipo TextBox, para poder tener una represetacion grafica.

        }
    }
}
