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
    public partial class FormClientes : Form
    {
        Cidade cidade;
        Cliente cliente;
        public FormClientes()
        {
            InitializeComponent();
        }
        void LimpaControles()
        {
            txtNome.Clear();
            txtNome.Clear();
            cboCidades.SelectedIndex = -1;
            txtUF.Clear();
            mskCPF.Clear();
            txtRenda.Clear();
            dtpDataNasc.Value = DateTime.Now;
            picFoto.ImageLocation = "";
            chkVenda.Checked = false;
        }
        void CarregarGrid(string pesquisa)
        {
            cidade = new Cidade();
            {
                Cidade.nome = pesquisa;
            };

            DGVCidades.DataSource = Cidade.Consultar();
        }
        private void FormClientes_Load(object sender, EventArgs e)
        {
            cidade = new Cidade();
            cboCidades.DataSource= Cidade.Consultar();
            cboCidades.DisplayMember = "nome";
            cboCidades.ValueMember = "id";

            LimpaControles();
            carregarGrid(")
        }
        private void BtnIncluir_Click(object sender, EventArgs e)
        {

        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
