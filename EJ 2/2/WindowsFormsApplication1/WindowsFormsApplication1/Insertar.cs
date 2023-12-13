﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Insertar : Form
    {
        public Insertar()
        {
            InitializeComponent();
        }

        private void Insertar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean lleno = textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && textBox3.Text.Length != 0 && textBox4.Text.Length != 0 && textBox5.Text.Length != 0;

            if (lleno)
            {
                String ci = textBox1.Text.ToString();
                String nom = textBox2.Text.ToString();
                String app = textBox3.Text.ToString();
                String apm = textBox4.Text.ToString();
                int apr = Convert.ToInt32(textBox5.Text.ToString());

                ServiceReference1.WebServiceSoapClient ws = new ServiceReference1.WebServiceSoapClient();
                ws.insAlumno(ci, nom, app, apm, apr);

                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor llene los campos");
            }
        }
    }
}
