﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolarMusicApp
{
    public partial class FrmMatricula : Form
    {
        public FrmMatricula()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMatricula_Load(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            var listaAluno = aluno.ListarTodos();
            cmbAluno.DataSource = listaAluno;
            cmbAluno.DisplayMember = "Nome";
            cmbAluno.ValueMember = "Id";

            Curso curso = new Curso();
            var listaCurso = curso.ListarTodos();
            cmbCurso.DataSource = listaCurso;
            cmbCurso.DisplayMember = "Nome";
            cmbCurso.ValueMember = "Id";

        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.ObterPorId(Convert.ToInt32(cmbAluno.SelectedValue));
            Curso curso = new Curso();
            curso.ObterPorId(Convert.ToInt32(cmbCurso.SelectedValue));
            Matricula matricula = new Matricula();
            matricula.Inserir(aluno,curso, Program.usuarioLogado);
            MessageBox.Show("Matrícula realizada com sucesso.");
                
        }
    }
}
