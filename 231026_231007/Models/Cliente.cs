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
    internal class Cliente
    {
        string comando;
        public static int id { get; set; }
        public static string nome { get; set; }
        public static int idCidade { get; set; }
        public static DateTime dataNasci { get; set; }
        public static double renda { get; set; }
        public static string cpf { get; set; }
        public static string foto { get; set; }
        public static bool venda { get; set; }
        public static void Alterar()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("update Clientes set nome = @nome ,uf = @uf where id = @id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@nome", nome);
                Banco.Comando.Parameters.AddWithValue("@id", id);
                Banco.Comando.Parameters.AddWithValue("@idCidade", idCidade);
                Banco.Comando.Parameters.AddWithValue("@dataNasc", dataNasci);
                Banco.Comando.Parameters.AddWithValue("@renda", renda);
                Banco.Comando.Parameters.AddWithValue("@cpf", cpf);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);
                Banco.Comando.Parameters.AddWithValue("@venda", venda);
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
                Banco.Comando = new MySqlCommand("delete from Clientes where id = @id", Banco.Conexao);
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
                Banco.Comando = new MySqlCommand("use vendas;insert into clientes(nome,idCidade,dataNasc,renda,cpf,foto,venda) values(@nome, @idCidade,@dataNasc,@renda,@cpf,@foto,@venda) ", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@nome", nome);
                Banco.Comando.Parameters.AddWithValue("@idCidade", idCidade);
                Banco.Comando.Parameters.AddWithValue("@dataNasc", dataNasci);
                Banco.Comando.Parameters.AddWithValue("@renda", renda);
                Banco.Comando.Parameters.AddWithValue("@cpf", cpf);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);
                Banco.Comando.Parameters.AddWithValue("@venda", venda);
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
                Banco.Comando = new MySqlCommand("use vendas; select Clientes.*, cidades.nome, cidades.uf from Clientes inner join Cidadeson (cidades.id = Clientes.idCidade) where clientes.nome like ?nome order by Clientes.nome", Banco.Conexao);
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
