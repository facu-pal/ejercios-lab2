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
    public partial class Frm_Saludar : Form
    {
        public Frm_Saludar(string titulo, string cuerpo)
        {
            InitializeComponent();
            lblTitulo.Text = titulo;
            lblMensaje.Text = cuerpo;
        }
    }
}
