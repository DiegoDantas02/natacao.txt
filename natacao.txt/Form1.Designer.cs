namespace natacao.txt
{
    partial class Natação
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBotao = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.categ = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNascimento = new System.Windows.Forms.TextBox();
            this.txtAnoUltimoAniversario = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBotao
            // 
            this.txtBotao.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBotao.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.txtBotao.FlatAppearance.BorderSize = 2;
            this.txtBotao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.txtBotao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.txtBotao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtBotao.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtBotao.ForeColor = System.Drawing.Color.Gold;
            this.txtBotao.Location = new System.Drawing.Point(92, 229);
            this.txtBotao.Name = "txtBotao";
            this.txtBotao.Size = new System.Drawing.Size(133, 36);
            this.txtBotao.TabIndex = 0;
            this.txtBotao.Text = "IDENTIFICAR CATEGORIA";
            this.txtBotao.UseVisualStyleBackColor = false;
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtNome.Location = new System.Drawing.Point(34, 94);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(49, 15);
            this.txtNome.TabIndex = 1;
            this.txtNome.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(34, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ano Nascimento:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(296, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ano Último Aniversario:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // categ
            // 
            this.categ.AutoSize = true;
            this.categ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.categ.Location = new System.Drawing.Point(380, 236);
            this.categ.Name = "categ";
            this.categ.Size = new System.Drawing.Size(65, 13);
            this.categ.TabIndex = 4;
            this.categ.Text = "Categoria:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(123, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(488, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(143, 169);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(146, 20);
            this.txtNascimento.TabIndex = 6;
            this.txtNascimento.TextChanged += new System.EventHandler(this.textNascimento_TextChanged);
            // 
            // txtAnoUltimoAniversario
            // 
            this.txtAnoUltimoAniversario.Location = new System.Drawing.Point(441, 165);
            this.txtAnoUltimoAniversario.Name = "txtAnoUltimoAniversario";
            this.txtAnoUltimoAniversario.Size = new System.Drawing.Size(170, 20);
            this.txtAnoUltimoAniversario.TabIndex = 7;
            this.txtAnoUltimoAniversario.TextChanged += new System.EventHandler(this.textAnoUltimoAniversario_TextChanged);
            this.txtAnoUltimoAniversario.Enter += new System.EventHandler(this.textAnoUltimoAniversario_Enter);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(441, 229);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(170, 20);
            this.txtCategoria.TabIndex = 8;
            // 
            // Natação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 439);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtAnoUltimoAniversario);
            this.Controls.Add(this.txtNascimento);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.categ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtBotao);
            this.MaximizeBox = false;
            this.Name = "Natação";
            this.ShowIcon = false;
            this.Text = "Natação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtBotao;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label categ;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNascimento;
        private System.Windows.Forms.TextBox txtAnoUltimoAniversario;
        private System.Windows.Forms.TextBox txtCategoria;
    }
}

