namespace _231026_231007.Views
{
    partial class FormCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategorias));
            this.BtnPesquisa = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.DGVCategorias = new System.Windows.Forms.DataGridView();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCategorias = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPesquisa
            // 
            this.BtnPesquisa.Font = new System.Drawing.Font("Roboto Lt", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisa.Location = new System.Drawing.Point(799, 231);
            this.BtnPesquisa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnPesquisa.Name = "BtnPesquisa";
            this.BtnPesquisa.Size = new System.Drawing.Size(83, 20);
            this.BtnPesquisa.TabIndex = 29;
            this.BtnPesquisa.Text = "Pesquisa";
            this.BtnPesquisa.UseVisualStyleBackColor = true;
            // 
            // BtnFechar
            // 
            this.BtnFechar.BackColor = System.Drawing.SystemColors.Menu;
            this.BtnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnFechar.BackgroundImage")));
            this.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnFechar.FlatAppearance.BorderSize = 0;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.Location = new System.Drawing.Point(1050, -83);
            this.BtnFechar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(70, 60);
            this.BtnFechar.TabIndex = 28;
            this.BtnFechar.UseVisualStyleBackColor = false;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(653, 121);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(167, 56);
            this.BtnExcluir.TabIndex = 27;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(467, 122);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(160, 56);
            this.BtnCancelar.TabIndex = 26;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterar.Location = new System.Drawing.Point(276, 121);
            this.BtnAlterar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(156, 57);
            this.BtnAlterar.TabIndex = 25;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click_1);
            // 
            // DGVCategorias
            // 
            this.DGVCategorias.AllowUserToAddRows = false;
            this.DGVCategorias.AllowUserToDeleteRows = false;
            this.DGVCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCategorias.Location = new System.Drawing.Point(14, 279);
            this.DGVCategorias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DGVCategorias.Name = "DGVCategorias";
            this.DGVCategorias.ReadOnly = true;
            this.DGVCategorias.Size = new System.Drawing.Size(868, 232);
            this.DGVCategorias.TabIndex = 24;
            this.DGVCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCategorias_CellClick);
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIncluir.Location = new System.Drawing.Point(78, 121);
            this.BtnIncluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(173, 57);
            this.BtnIncluir.TabIndex = 23;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Location = new System.Drawing.Point(14, 231);
            this.TxtPesquisa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(778, 21);
            this.TxtPesquisa.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Categoria (Digite o nome da categoria para pesquisar):";
            // 
            // TxtCategorias
            // 
            this.TxtCategorias.Location = new System.Drawing.Point(14, 72);
            this.TxtCategorias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtCategorias.Name = "TxtCategorias";
            this.TxtCategorias.Size = new System.Drawing.Size(867, 21);
            this.TxtCategorias.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Categoria:";
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(-178, -52);
            this.TxtId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(109, 21);
            this.TxtId.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-186, -78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Código:";
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 548);
            this.Controls.Add(this.BtnPesquisa);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.DGVCategorias);
            this.Controls.Add(this.BtnIncluir);
            this.Controls.Add(this.TxtPesquisa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtCategorias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto Lt", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormCategorias";
            this.Text = "Categorias";
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPesquisa;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.DataGridView DGVCategorias;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCategorias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label1;
    }
}