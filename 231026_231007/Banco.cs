using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _231026_231007
{
    public class Banco
    {
        public static MySqlConnection Conexao;

        public static MySqlCommand Comando;

        public static MySqlDataAdapter Adaptador;

        public static DataTable dataTable;


        public static void AbrirConexao()
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau");
                Conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public static void FecharConexao()
        {
            try
            {
                Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void CriaBanco()
        {
            try
            {
                //ola jonas
                AbrirConexao();

                //criabanco
                Comando = new MySqlCommand("create Database If Not Exists vendas; use vendas", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("create table if not exists Cidades(id int auto_increment primary key,nome varchar(40), uf varchar(02));Create table if not exists Marcas(id int auto_increment primary key,nome varchar(40), cnpj varchar(14));create table if not exists Categorias(id int auto_increment primary key,categoria varchar(50));", Conexao);
                Comando.ExecuteNonQuery();

                FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }

}   
