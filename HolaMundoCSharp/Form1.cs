using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundoCSharp
{
    public partial class TextBoxBienvenida : Form
    {
        public TextBoxBienvenida()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxNombre_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            MessageBox.Show("Hola " +nombre +" bienvenido al mundo de C#");
        }

        private void LabelPregunta_Click(object sender, EventArgs e)
        {

        }
    }
}
