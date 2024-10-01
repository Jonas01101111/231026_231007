using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _231026_231007.Models;

namespace _231026_231007.Views
{
    public partial class FormCidades : Form
    {
        Cidade c;
        public FormCidades()
        {
            InitializeComponent();
        }

        void LimpaControles()
        {
            TxtId.Clear();
            TxtCidades.Clear(); 
            TxtPesquisa.Clear();
            TxtPesquisa.Clear();
        }

        void CarregarGrid(string pesquisa)
        {
            c = new Cidade();
            {
                nome = pesquisa
            };

            DGVCidades.DataSource = c.Consultar();
        }

        private void FormCidades_Load(object sender, EventArgs e)
        {
            LimpaControles();
            CarregarGrid("");
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            if (TxtCidades.Text == String.Empty) return;

            c = new Cidade();
            {
                nome = TxtCidades.Text,
                uf = TxtUf.Text
            };
            c.Incluir();

            LimpaControles();
            CarregarGrid("");
        }

        private void DGVCidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVCidades.RowCount > 0)
            {
                TxtId.Text = DGVCidades.CurrentRow.Cells["Id"].Value.ToString();
                TxtCidades.Text = DGVCidades.CurrentRow.Cells["Nome"].Value.ToString();
                TxtUf.Text = DGVCidades.CurrentRow.Cells["Uf"].Value.ToString();
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if(TxtId.Text == String.Empty) return;

            c= new Cidade();
            {
                id = int.Parse(TxtId.Text),
                nome = TxtCidades.Text,
                uf = TxtUf.Text
            };

            c.Alterar();
            LimpaControles();
            CarregarGrid("");
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (TxtId.Text == "") return;

            if (MessageBox.Show("Deseja Excluir a Cidade", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { 
                c = new Cidade();
                {
                    id = int.Parse(TxtId.Text);
                }

                c.Excluir();

                LimpaControles();
                CarregarGrid("");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpaControles();
            CarregarGrid("");
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
