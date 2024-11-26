using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _231026_231007.Models
{
    internal class Categoria
    {
        string comando;
        public static int id { get; set; }
        public static string categoria { get; set; }

        public static void Alterar()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("update Categorias set categoria = @categoria where id = @id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@categoria", categoria);
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
                Banco.Comando = new MySqlCommand("delete from Categorias where id = @id", Banco.Conexao);
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
                Banco.Comando = new MySqlCommand("use vendas; \n insert into categorias(categoria) values(@categoria) ", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@categoria", categoria);
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
                Banco.Comando = new MySqlCommand("use vendas; select * from Categorias where categoria like @categoria order by categoria", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@categoria", categoria + "%");
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
