﻿using System;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //criar uma instância de Form1 (FrmAluno)
            FrmAluno frmAluno = new FrmAluno();
            frmAluno.MdiParent = this;
            frmAluno.Show();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfessor frmProfessor = new FrmProfessor();
            frmProfessor.MdiParent = this;
            frmProfessor.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            if (Program.usuarioLogado!=null)
            {
                Text = "FrmPrincipal - " + Program.usuarioLogado.Nome;
            }
            else
            {
                Application.Exit();
            }
           
        }

        private void matrículaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMatricula frmMatricula = new FrmMatricula();
            frmMatricula.MdiParent = this;
            frmMatricula.Show();
        }
    }
}
