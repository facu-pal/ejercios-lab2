using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_ejercio_i01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbMateria.Items.Add("Programación I");
            cmbMateria.Items.Add("Laboratorio de Computación I");
            cmbMateria.Items.Add("Sistema de procesamiento de datos");
            cmbMateria.Items.Add("Inglés I");
            cmbMateria.Items.Add("Matemática");
            cmbMateria.Items.Add("Programación II");
            cmbMateria.Items.Add("Laboratorio de Computación II");
            cmbMateria.Items.Add("Inglés II");
            cmbMateria.Items.Add("Metodología de la investigación");
            cmbMateria.Items.Add("Arquitectura y sistemas operativos");
            cmbMateria.Items.Add("Estadística");
            cmbMateria.SelectedIndex = 0;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            string titulo= "¡Hola, windows form! ";
            string cuerpo = $"Soy {txt_Apellido.Text} {txt_Nombre.Text} y mi materia favorita es {cmbMateria.SelectedItem}";

          

            if (Validar())
            {
                Frm_Saludar frmSaluda = new Frm_Saludar(titulo, cuerpo);
                frmSaluda.ShowDialog();
            }

        }


        private bool Validar()
        {
            bool esValido = true;
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Se deben completar los siguientes campos:");

            if (string.IsNullOrWhiteSpace(txt_Nombre.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("Nombre");
            }

            if (string.IsNullOrWhiteSpace(txt_Apellido.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("Apellido");
            }

            if (!esValido)
            {
                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }



    }
}
