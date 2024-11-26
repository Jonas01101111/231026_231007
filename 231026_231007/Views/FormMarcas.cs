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
    public partial class FormMarcas : Form
    {
        Marca m;
        public FormMarcas()
        {
            InitializeComponent();
        }
        void LimpaControles()
        {
            TxtId.Clear();
            TxtCnpj.Clear();
            TxtPesquisa.Clear();
            TxtNome.Clear();
        }

        void CarregarGrid(string pesquisa)
        {
            m = new Marca();
            {
                Marca.nome = pesquisa;
            };

            DGVMarcas.DataSource = Marca.Consultar();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMarcas_Load(object sender, EventArgs e)
        {
            LimpaControles();
            CarregarGrid("");
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            if (TxtNome.Text == String.Empty) return;

            m = new Marca();
            {
                Marca.nome = TxtNome.Text;
                Marca.cnpj = TxtCnpj.Text;
            };
            Marca.Incluir();

            LimpaControles();
            CarregarGrid("");
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (TxtId.Text == "") return;

            if (MessageBox.Show("Deseja Excluir a ", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                m = new Marca();
                {
                    Marca.id = int.Parse(TxtId.Text);
                }

                Marca.Excluir();

                LimpaControles();
                CarregarGrid("");
            }
        }

        private void DGVMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVMarcas.RowCount > 0)
            {
                TxtId.Text = DGVMarcas.CurrentRow.Cells["id"].Value.ToString();
                TxtNome.Text = DGVMarcas.CurrentRow.Cells["nome"].Value.ToString();
                TxtCnpj.Text = DGVMarcas.CurrentRow.Cells["cnpj"].Value.ToString();
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (TxtId.Text == String.Empty) return;

            m = new Marca();
            {
                Marca.id = int.Parse(TxtId.Text);
                Marca.nome = TxtNome.Text;
                Marca.cnpj = TxtCnpj.Text;
            };

            Marca.Alterar();
            LimpaControles();
            CarregarGrid("");
        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            CarregarGrid(TxtPesquisa.Text);
        }
    }
}
