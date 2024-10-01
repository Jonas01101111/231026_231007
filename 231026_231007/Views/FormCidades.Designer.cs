namespace _231026_231007.Views
{
    partial class FormCidades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtCidades = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.DGVCidades = new System.Windows.Forms.DataGridView();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnPesquisa = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCidades)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Códigos:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(25, 43);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(236, 30);
            this.TxtId.TabIndex = 1;
            // 
            // TxtCidades
            // 
            this.TxtCidades.Location = new System.Drawing.Point(25, 145);
            this.TxtCidades.Name = "TxtCidades";
            this.TxtCidades.Size = new System.Drawing.Size(762, 30);
            this.TxtCidades.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cidades:";
            // 
            // TxtUf
            // 
            this.TxtUf.Location = new System.Drawing.Point(866, 145);
            this.TxtUf.Name = "TxtUf";
            this.TxtUf.Size = new System.Drawing.Size(178, 30);
            this.TxtUf.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(862, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Uf:";
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Location = new System.Drawing.Point(27, 342);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(903, 30);
            this.TxtPesquisa.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(432, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cidade (Digite o nome da cidade para pesquisar):";
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Location = new System.Drawing.Point(27, 210);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(115, 56);
            this.BtnIncluir.TabIndex = 8;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // DGVCidades
            // 
            this.DGVCidades.AllowUserToAddRows = false;
            this.DGVCidades.AllowUserToDeleteRows = false;
            this.DGVCidades.AllowUserToOrderColumns = true;
            this.DGVCidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.uf});
            this.DGVCidades.Location = new System.Drawing.Point(26, 397);
            this.DGVCidades.Name = "DGVCidades";
            this.DGVCidades.ReadOnly = true;
            this.DGVCidades.Size = new System.Drawing.Size(1048, 232);
            this.DGVCidades.TabIndex = 9;
            this.DGVCidades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCidades_CellClick);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(198, 210);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(115, 56);
            this.BtnAlterar.TabIndex = 10;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(418, 210);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(115, 56);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(608, 210);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(115, 56);
            this.BtnExcluir.TabIndex = 12;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(772, 210);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(115, 56);
            this.BtnFechar.TabIndex = 13;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnPesquisa
            // 
            this.BtnPesquisa.Location = new System.Drawing.Point(972, 328);
            this.BtnPesquisa.Name = "BtnPesquisa";
            this.BtnPesquisa.Size = new System.Drawing.Size(115, 56);
            this.BtnPesquisa.TabIndex = 14;
            this.BtnPesquisa.Text = "Pesquisa";
            this.BtnPesquisa.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // uf
            // 
            this.uf.HeaderText = "Uf";
            this.uf.Name = "uf";
            this.uf.ReadOnly = true;
            // 
            // FormCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1152, 641);
            this.ControlBox = false;
            this.Controls.Add(this.BtnPesquisa);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.DGVCidades);
            this.Controls.Add(this.BtnIncluir);
            this.Controls.Add(this.TxtPesquisa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtUf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCidades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(1168, 657);
            this.Name = "FormCidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cidades";
            this.Load += new System.EventHandler(this.FormCidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtCidades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.DataGridView DGVCidades;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf;
    }
}