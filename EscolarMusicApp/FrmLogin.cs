using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolarMusicApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(textBox1.Text,textBox2.Text);
            if (usuario.EfetuarLogin(usuario))
            {
                this.Close();
                Program.usuarioLogado = usuario;
            }
            else 
            {
                MessageBox.Show("Usuário ou senha incorreto!");
            }
        }
    }
}
