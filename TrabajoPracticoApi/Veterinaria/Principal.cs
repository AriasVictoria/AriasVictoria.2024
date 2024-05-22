using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal();
            animal.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Historial historiales = new Historial();
            historiales.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Medicamentos medicamentos = new Medicamentos();
            medicamentos.Show();
            this.Hide();
        }
    }
}
