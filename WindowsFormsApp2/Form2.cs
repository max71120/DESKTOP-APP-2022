using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Cliente miCliente = new Cliente();
        CalcularPrecio miCotizacion = new CalcularPrecio();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            miCliente.Nombre = txtNombre.Text;
            miCliente.Direccion = txtDireccion.Text;
            miCliente.Telefono = Convert.ToDecimal(txtTelefono.Text);
            //miCliente.Distancia = Convert.ToInt32(txtCargadores);
            miCliente.Distancia = Convert.ToDecimal(txtCostoVuelo.Text);
            miCotizacion.HorasRequeridas = Convert.ToInt32(txtCargadores.Text);
            MessageBox.Show("Registro guardado");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //txtMonto.Text = miCotizacion.CalculaPrecio(Convert.ToInt32(miCotizacion.HorasRequeridas),
            //    Convert.ToDecimal(miCliente.Distancia)).ToString();


        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            txtMonto.Text = miCotizacion.CalculaPrecio(Convert.ToInt32(miCotizacion.HorasRequeridas),
      Convert.ToDecimal(miCliente.Distancia)).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtMonto.Clear();
            txtDireccion.Clear();
            txtCostoVuelo.Clear();
            txtCargadores.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
