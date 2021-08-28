using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            checkLoginInfo();
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                checkLoginInfo();
            }
        }

        private void textboxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                checkLoginInfo();
            }
        }

        private void textBoxApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                checkLoginInfo();
            }
        }

        private void checkLoginInfo()
        {
            if (textBoxNombre.Text == "" || textboxApellido.Text == "" || textBoxApellidoMaterno.Text == "")
            {
                MessageBox.Show("Ningun campo puede quedar vacio", "Error");
            }
            else
                guardarDatos();
        }

        
        private void guardarDatos()
        {
            dataGridAlumnos.Rows.Add(textBoxNombre.Text, textboxApellido.Text, textBoxApellidoMaterno.Text);
            textBoxNombre.Text = "";
            textboxApellido.Text = "";
            textBoxApellidoMaterno.Text = "";
            //dataGridAlumnos.ForeColor = Color.Red;
        }

        private void LimpiarGrid(object sender, EventArgs e)
        {
            dataGridAlumnos.Rows.Clear();
        }
    }
}
