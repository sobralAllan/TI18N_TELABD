using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProjetoSistemaTI18N
{
    class DAO
    {
        MySqlConnection conexao;
        public string dados;
        public string sql;
        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=ti18n;Uid=root;Password=");
            try 
            {
                conexao.Open();
                MessageBox.Show("Conectado com sucesso!");//Temporariamente             
            }catch(Exception erro)
            {
                MessageBox.Show(erro + "\n\nAlgo deu errado!");
                conexao.Close();
            }//fim do catch
        }//fim do construtor

        public void Inserir(int codigo, string nome, string telefone, string cidade, string estado)
        {
            dados = "('" + codigo + "','" + nome + "','" + telefone + "','" + cidade + "','" + estado + "')";
            sql   = "insert into pessoa(codigo, nome, telefone, cidade, estado) values" + dados;

            try
            {
                MySqlCommand conn = new MySqlCommand(sql, conexao);
                MessageBox.Show(conn.ExecuteNonQuery() + " dado inserido!");
            }catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
        }//fim do método
    }//fim da classe
}//fim do projeto
