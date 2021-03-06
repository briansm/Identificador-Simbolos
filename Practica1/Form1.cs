﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Universidad San Carlos de Guatemala \n"+"Brian Morales \n"+"Lenguajes Formales de Programacion \n"+"Seccion A+ \n"+"Primer Semestre");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //-----Crea un objeto tip Openfile Dialog
            OpenFileDialog abrirD = new OpenFileDialog();
            //------Especifica el tipo de extension del archivo
            abrirD.Filter = "|*.lfp";
            //------Si se encuentra el archivo 
            if (abrirD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //-----obtiene la informacion y la guarda en un objeto
                StreamReader lectura = new StreamReader(abrirD.FileName);
                String inf = lectura.ReadToEnd();
                //-----Carga todo el string en un cuadro de texto
                editor.Text = inf;
            }

        }

        private void analizar_Click(object sender, EventArgs e)
        {
            int conl = 0;
            int conn = 0;
            int cons = 0;
            string texto = editor.Text;
            Char[] cadena= texto.ToCharArray();
            for (int i = 0; i < cadena.Length;i++)
            {
                if(Char.IsLetter(cadena[i]))
                {
                    resultados.Items.Add((cadena[i].ToString()) + " --> " + "LETRA");
                    conl++;
                }
                else if (Char.IsDigit(cadena[i]))
                {
                    resultados.Items.Add((cadena[i].ToString()) + " --> " + "NUMERO");
                    conn++;
                }
                else if (cadena[i] == 32 || cadena[i] == 10 || cadena[i] == 9)
                {
                    cadena[i] = cadena[i + 1];
                }

                else {
                    resultados.Items.Add((cadena[i].ToString()) + " --> " + "SIMBOLO");
                    cons++;
                }
            }
            resultados.Items.Add("-----------------------------------------------------");

            conteo.Text = "Letras: " + conl + "\n" + "Numeros: " + conn + "\n" + "Simbolo: " + cons;
            
        }
    }
}
