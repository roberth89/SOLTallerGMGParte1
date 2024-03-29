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

        //LogicaNegocio.Cajero _objCajero = new LogicaNegocio.Cajero();

        List<Modelo.Persona> _listaPersonas = new List<Modelo.Persona>();

        private const string SEPARADOR = "---";

        public FrmMainTaller()
        {
            InitializeComponent();
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            TxtConsulta.Text = LogicaNegocio.Cuenta.DineroActual.ToString();

        }

        private void TomarCaptura()
        {
            int cero = 0;
            decimal error = 8 / cero;
        }

        private string RetirarDinero()
        {
            decimal dineroActual = LogicaNegocio.Cuenta.DineroActual;

            LogicaNegocio.Cajero _objCajero;

            // asignar esta instancia segun un combobox.
            //CboTipoCajero.Text
            if (CboTipoCajero.SelectedValue.ToString() == "0")
            {
                _objCajero = new LogicaNegocio.Cajero(dineroActual);
            }
            else if (CboTipoCajero.SelectedValue.ToString() == "1")
            {
                _objCajero = new LogicaNegocio.CajeroDolar(dineroActual);
            }
            else  
            {
                _objCajero = new LogicaNegocio.CajeroCordoba(dineroActual);
            }      


            string montoRetiro = TxtRetiro.Text;
            string mensajeRetorno = string.Empty;
            decimal valorRetorno = 0;

            valorRetorno = _objCajero.RetirarDinero(Convert.ToDecimal(montoRetiro), ref mensajeRetorno);


            LogicaNegocio.Cuenta.DineroActual = valorRetorno;
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

        private void btnPila_Click(object sender, EventArgs e)
        {
            Stack<int> objPila = LogicaNegocio.Lista.Pila();
            // Tarea , agregar en un control tipo TextBox, para poder tener una represetacion grafica
        }

        private void BtnDiccionario_Click(object sender, EventArgs e)
        {
            var objDi = LogicaNegocio.Lista.Diccionario();
            // Tarea , agregar en un control tipo TextBox, para poder tener una represetacion grafica

        }

        private void btnLambdaSuma_Click(object sender, EventArgs e)
        {
            var primerResult = 0;
            var segundoResult = 0;

            var objFormulario1 = new FrmInputTest();
            AddOwnedForm(objFormulario1);
            objFormulario1.ShowDialog();

            primerResult = this.Numero1;

            var objFormulario2 = new FrmInputTest();
            AddOwnedForm(objFormulario2);
            objFormulario2.ShowDialog();

            segundoResult = this.Numero1;

            var objLambda = new LogicaNegocio.Lambda();
            int resultado = objLambda.LambdaSuma(primerResult, segundoResult);
            MessageBox.Show(resultado.ToString());
        }





        private void BtnLambdaMayorNumeros_Click(object sender, EventArgs e)
        {
            var objLambda = new LogicaNegocio.Lambda();
            //   Tarea permitir que LambdaSuma reciba 2 parametros
            int resultado = objLambda.LambdaMayorNumeros();
        }

        private void BtnLambdaPares_Click(object sender, EventArgs e)
        {
            var objLambda = new LogicaNegocio.Lambda();

            IEnumerable<int> resultado = objLambda.ObtenerPares();
        }

        // Variables deberia ir arriba pero es para el ejemplo del formulario
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }

        private void BtnAbrirFormulario_Click(object sender, EventArgs e)
        {

            var objFormulario = new FrmInput();
            AddOwnedForm(objFormulario);

            objFormulario.Show();
        }

        private void FrmMainTaller_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        private void LlenarCombo()
        {
            List<Tuple<Int32, String>> listaItems = new List<Tuple<int, string>>();
            listaItems.Add(Tuple.Create<Int32, String>(0, "Cajero Colones"));
            listaItems.Add(Tuple.Create<Int32, String>(1, "Cajero Dolares"));
            listaItems.Add(Tuple.Create<Int32, String>(2, "Cajero Cordoba"));
            // Asigna items a el combobox
            CboTipoCajero.DataSource = listaItems;

            /* Asigna la propiedad a desplegar en el combobox
               En un objeto tupla la propiedad que contiene
               el primer elemento es llamada Item1, el segundo Item2
               y asi sucesivamente */
            CboTipoCajero.DisplayMember = "Item2";
            // Asigna la propiedad como valores de los items del combobox
            CboTipoCajero.ValueMember = "Item1";
        }

    }


}
