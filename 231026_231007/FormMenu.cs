using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using _231026_231007.Views;

namespace _231026_231007
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Banco.CriaBanco();
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCidades form = new FormCidades();
            form.Show();
        }
    }
}
