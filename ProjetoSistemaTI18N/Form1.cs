﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSistemaTI18N
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }//método construtor

        private void Menu_Load(object sender, EventArgs e)
        {

        }//Faz o carregamento de conteúdos da minha tela 

        private void cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.ShowDialog();//Aparecer a tela cadastrar
        }//fim do método cadastrar

        private void consultar_Click(object sender, EventArgs e)
        {

        }//fim do consultar

        private void atualizar_Click(object sender, EventArgs e)
        {

        }//fim do atualizar

        private void excluir_Click(object sender, EventArgs e)
        {

        }//fim do excluir
    }//fim da classe
}//fim do projeto
