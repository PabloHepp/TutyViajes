﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaViajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //IMPORTAR ARCHIVO

            //FileStream letras = null;
            //StreamReader leyendo = null;
            //try
            //{
            //    #region algoritmo

            //    //crear archivo
            //    OpenFileDialog docu = new OpenFileDialog();

            //    //abrir la dirección del archivo

            //    if (docu.ShowDialog() == DialogResult.OK)
            //    {
            //        //crear el flujo de bytes
            //        letras = new FileStream(docu.FileName, FileMode.Open, FileAccess.ReadWrite);
            //        //crear el lector de líneas
            //        leyendo = new StreamReader(letras);
            //        //leo la primera linea

            //        string linea;
            //        linea = leyendo.ReadLine();

            //        //recorro el archivo leyendo línea por línea
            //        while (leyendo.EndOfStream == false) //mientras el lector encuentre algo, recorre
            //        {
            //            //lee todas las lineas del documeto importado
            //            linea = leyendo.ReadLine();
            //            //hacer un vector para cada línea y sus datos
            //            string[] campos = linea.Split(';');
            //            //dividir y asignar cada campo
            //            int dni = Convert.ToInt32(campos[0].Trim());
            //            string nombre = campos[1].Trim();
            //            int cuenta = Convert.ToInt32(campos[2].Trim());
            //            double saldo = Convert.ToDouble(campos[3].Trim());
            //            //crear un objeto con los campos adquiridos de la línea leída (comprueba si los datos ya han sido ingresados)
            //            Cuenta c;
            //            c = b.AgregarCuenta(cuenta, dni, nombre);
            //            c.Saldo += saldo;
            //        }


            //        btnShow.PerformClick();
            //    }
            //    #endregion
            //}
            //catch (Exception ex)
            //{
            //}
            //finally
            //{
            //    if (leyendo != null) leyendo.Close();
            //    if (letras != null) letras.Close();
            //}

            //EXPORTAR ARCHIVO

            //FileStream letras = null;
            //StreamWriter escribiendo = null;
            //try
            //{
            //    #region algoritmo


            //    //guardar archivo
            //    //SaveFileDialog docu = new SaveFileDialog();

            //    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        //crear el flujo de bytes
            //        letras = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
            //        //crear el lector de líneas
            //        escribiendo = new StreamWriter(letras);
            //        //leo la primera linea

            //        for (int idx = 0; idx < b.CantidadCuentas; idx++)
            //        {
            //            Cuenta c = b[idx];
            //            string linea = $"{c}";
            //            escribiendo.WriteLine(linea);
            //        }

            //    }
            //    #endregion
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    if (escribiendo != null) escribiendo.Close();
            //    if (letras != null) letras.Close();
            //}
        }
    }
}
