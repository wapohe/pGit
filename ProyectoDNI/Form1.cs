using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDNI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(textBoxDNI.Text);
            char letter = functionLetter(dni);
            textBoxChar.Text = letter.ToString();
        }

        private char functionLetter(int dni)
        {
            char letterDNI='a';

            return letterDNI;
        }
    }
}
