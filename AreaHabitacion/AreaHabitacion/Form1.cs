using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaHabitacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Area x = new Area();
            double anchura = double.Parse(textBox1.Text);
            double longitud = double.Parse(textBox2.Text);
            double area = x.CalcularArea(anchura, longitud);
            MessageBox.Show("la superficie de la habitacion es: " + area, "area habitacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult salir;
            salir = MessageBox.Show("Deseas salir de la aplicacion?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
