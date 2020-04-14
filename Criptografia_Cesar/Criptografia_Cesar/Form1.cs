using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criptografia_Cesar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void encriptar_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                int txtUsuario = (int)textBox1.Text[i];
                int txtCifrado = txtUsuario + 10;
                textBox3.Text += char.ConvertFromUtf32(txtCifrado);
            }
        }

        private void decriptar_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            for (int i = 0; i < textBox3.Text.Length; i++)
            {
                int txtCifrado = (int)textBox3.Text[i];
                int txtOriginal = txtCifrado - 10;
                textBox2.Text += char.ConvertFromUtf32(txtOriginal);
            }
        }
    }
}
