using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231026_231007.Models
{
    public class Cidade
    {
        public int id { get; set; }
        public string nome { get; set; }
            
        public string uf { get; set; }
    }

    public void Alterar()
    {
        try
        {
            Banco.AbrirConexao();
        }
        catch
        {
            //allyson é pro player
        }
    }
}
