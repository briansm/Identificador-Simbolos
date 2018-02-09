using System;
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
                StreamReader lectura = new StreamReader(abrirD.FileName);
                String inf = lectura.ReadToEnd();
                editor.Text = inf;
            }

        }
    }
}
