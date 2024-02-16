using System;
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
    public partial class Consultar : Form
    {
        DAO conectar;
        public Consultar()
        {
            InitializeComponent();
            conectar = new DAO();

            ConfigurarGrid();//Configuração de layout do grid
            NomesDados();//Nomes das colunas
            conectar.PreencherVetor();//Preencher o vetor com dados do banco
            AdicionarDados();//Incluí dados na tela assim que ela é aberta
        }//fim do consultar

        public void NomesDados()
        {
            dataGridView1.Columns[0].Name = "Código";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Telefone";
            dataGridView1.Columns[3].Name = "Cidade";
            dataGridView1.Columns[4].Name = "Estado";
        }//fim do método nomeDados

        public void AdicionarDados()
        {
            for(int i=0; i < conectar.ConsultarTamanhoBD(); i++)
            {
                dataGridView1.Rows.Add(conectar.codigo[i], conectar.nome[i], conectar.telefone[i], conectar.cidade[i], conectar.estado[i]);
            }//fim do for
        }//fim do método Adicionar

        public void ConfigurarGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//Incluir linhas
            dataGridView1.AllowUserToDeleteRows = false;//Incluir linhas
            dataGridView1.AllowUserToResizeColumns = false;//Incluir linhas
            dataGridView1.AllowUserToResizeRows = false;//Incluir linhas
            dataGridView1.ColumnCount = 5;//Quantidade de colunas
            //dataGridView1.RowCount = 5;//Quantidade de linhas
        }//fim do método

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//fim do dataGrid
    }//fim da classe
}//fim do namespace 
