using _231026_231007.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _231026_231007.Views
{
    public partial class FormCategorias : Form
    {
        Categoria c;
        public FormCategorias()
        {
            InitializeComponent();
        }
        void LimpaControles()
        {
            TxtCategorias.Clear();
            TxtPesquisa.Clear();
        }

        void CarregarGrid(string pesquisa)
        {
            c = new Categoria();
            {
                Categoria.categoria = pesquisa;
            };

            DGVCategorias.DataSource = Categoria.Consultar();
        }

        private void FormCidades_Load(object sender, EventArgs e)
        {
            LimpaControles();
            CarregarGrid("");
        } 
        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            if (TxtCategorias.Text == String.Empty) return;

            c = new Categoria();
            {
                Categoria.categoria = TxtCategorias.Text;
            };
            Categoria.Incluir();

            LimpaControles();
            CarregarGrid("");
        }

        private void DGVCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DGVCategorias.SelectedRows.Count == 0)
            {
                TxtCategorias.Text = DGVCategorias.CurrentRow.Cells["categoria"].Value.ToString();
            }
        }

        private void BtnAlterar_Click_1(object sender, EventArgs e)
        {
            if (TxtCategorias.Text == String.Empty) return;

            c = new Categoria();
            {
                Categoria.categoria = TxtCategorias.Text;
            };

            Categoria.Alterar();
            LimpaControles();
            CarregarGrid("");
        }
    }
}
