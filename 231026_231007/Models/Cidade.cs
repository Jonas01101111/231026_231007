using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace _231026_231007.Models
{
    public class Cidade
    {
        string comando;
        public static int id { get; set; }
        public static string nome { get; set; }

        public static string uf { get; set; }
        public static void Alterar()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("update Cidades set nome = @nome ,uf = @uf where id = @id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@nome", nome);
                Banco.Comando.Parameters.AddWithValue("@uf", uf);
                Banco.Comando.Parameters.AddWithValue("@id", id);
                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                //allyson é pro player
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void Excluir()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("delete from Cidades where id = @id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@id", id);
                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();

            }
            catch (Exception e)
            {
                //allyson é pro player
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void Incluir()//lembrar q o id e auto incremwnt? 
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("use vendas; \n insert into cidades(nome,uf) values(@nome, @uf) ", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@nome", nome);
                Banco.Comando.Parameters.AddWithValue("@uf", uf);
                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                //allyson é pro player
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static DataTable Consultar()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("use vendas; select * from Cidades where nome like @nome order by nome", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@nome", nome + "%");
                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.dataTable = new DataTable();
                Banco.Adaptador.Fill(Banco.dataTable);
                Banco.FecharConexao();
                return Banco.dataTable;
            }
            catch (Exception e)
            {
                //allyson é pro player e Super pro
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        
    }


}
