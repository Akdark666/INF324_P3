using System;
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
    public partial class Editar : Form
    {

        String car, nam, app, dep;
        int apr;

        public Editar(String ci, String nom, String pat, String depto, int pra)
        {
            InitializeComponent();

            car = ci;
            nam = nom;
            app = pat;
            dep = depto;
            apr = pra;
       
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            textBox2.Text = nam;
            textBox3.Text = app;
            textBox4.Text = dep;
            textBox5.Text = apr + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean lleno = textBox2.Text.Length != 0 && textBox3.Text.Length != 0 && textBox4.Text.Length != 0 && textBox5.Text.Length != 0;

            if (lleno)
            {
                nam = textBox2.Text.ToString();
                app = textBox3.Text.ToString();
                dep = textBox4.Text.ToString();
                int apr = Convert.ToInt32(textBox5.Text.ToString());

                ServiceReference1.WebServiceSoapClient ws = new ServiceReference1.WebServiceSoapClient();
                ws.actAlumno(car, nam, app, dep, apr);

                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor llene los campos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
