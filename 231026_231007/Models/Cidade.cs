using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _231026_231007.Models
{
    public class Cidade
    {
        public int id { get; set; }
        public string nome { get; set; }

        public string uf { get; set; }
        public static void Alterar()
        {
            try
            {
                Banco.AbrirConexao();

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

            }
            catch (Exception e)
            {
                //allyson é pro player
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void Incluir()
        {
            try
            {
                Banco.AbrirConexao();

            }
            catch (Exception e)
            {
                //allyson é pro player
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void Consultar()
        {
            try
            {
                Banco.AbrirConexao();

            }
            catch (Exception e)
            {
                //allyson é pro player e Super pro
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }


}
