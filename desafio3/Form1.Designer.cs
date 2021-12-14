
namespace desafio3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_arquivo_clientes = new System.Windows.Forms.Button();
            this.btn_arquivo_produtos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_novaTabela_Clientes = new System.Windows.Forms.Button();
            this.btn_novaTabela_Produtos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_arquivo_clientes
            // 
            this.btn_arquivo_clientes.BackColor = System.Drawing.Color.Red;
            this.btn_arquivo_clientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_arquivo_clientes.ForeColor = System.Drawing.Color.Black;
            this.btn_arquivo_clientes.Location = new System.Drawing.Point(12, 12);
            this.btn_arquivo_clientes.Name = "btn_arquivo_clientes";
            this.btn_arquivo_clientes.Size = new System.Drawing.Size(385, 61);
            this.btn_arquivo_clientes.TabIndex = 0;
            this.btn_arquivo_clientes.Text = "Gerar arquivo dos clientes ANTIGOS";
            this.btn_arquivo_clientes.UseVisualStyleBackColor = false;
            this.btn_arquivo_clientes.Click += new System.EventHandler(this.btn_arquivo_clientes_Click);
            // 
            // btn_arquivo_produtos
            // 
            this.btn_arquivo_produtos.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_arquivo_produtos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_arquivo_produtos.ForeColor = System.Drawing.Color.Black;
            this.btn_arquivo_produtos.Location = new System.Drawing.Point(12, 110);
            this.btn_arquivo_produtos.Name = "btn_arquivo_produtos";
            this.btn_arquivo_produtos.Size = new System.Drawing.Size(385, 61);
            this.btn_arquivo_produtos.TabIndex = 1;
            this.btn_arquivo_produtos.Text = "Gerar arquivo dos produtos ANTIGOS";
            this.btn_arquivo_produtos.UseVisualStyleBackColor = false;
            this.btn_arquivo_produtos.Click += new System.EventHandler(this.btn_arquivo_produtos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "consulta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(715, 188);
            this.dataGridView1.TabIndex = 3;
            // 
            // btn_novaTabela_Clientes
            // 
            this.btn_novaTabela_Clientes.BackColor = System.Drawing.Color.Salmon;
            this.btn_novaTabela_Clientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_novaTabela_Clientes.ForeColor = System.Drawing.Color.Black;
            this.btn_novaTabela_Clientes.Location = new System.Drawing.Point(489, 12);
            this.btn_novaTabela_Clientes.Name = "btn_novaTabela_Clientes";
            this.btn_novaTabela_Clientes.Size = new System.Drawing.Size(299, 61);
            this.btn_novaTabela_Clientes.TabIndex = 4;
            this.btn_novaTabela_Clientes.Text = "Nova Tabela Clientes";
            this.btn_novaTabela_Clientes.UseVisualStyleBackColor = false;
            this.btn_novaTabela_Clientes.Click += new System.EventHandler(this.btn_novaTabela_Clientes_Click);
            // 
            // btn_novaTabela_Produtos
            // 
            this.btn_novaTabela_Produtos.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_novaTabela_Produtos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_novaTabela_Produtos.ForeColor = System.Drawing.Color.Black;
            this.btn_novaTabela_Produtos.Location = new System.Drawing.Point(489, 110);
            this.btn_novaTabela_Produtos.Name = "btn_novaTabela_Produtos";
            this.btn_novaTabela_Produtos.Size = new System.Drawing.Size(299, 61);
            this.btn_novaTabela_Produtos.TabIndex = 5;
            this.btn_novaTabela_Produtos.Text = "Nova Tabela Produtos";
            this.btn_novaTabela_Produtos.UseVisualStyleBackColor = false;
            this.btn_novaTabela_Produtos.Click += new System.EventHandler(this.btn_novaTabela_Produtos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_novaTabela_Produtos);
            this.Controls.Add(this.btn_novaTabela_Clientes);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_arquivo_produtos);
            this.Controls.Add(this.btn_arquivo_clientes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_arquivo_clientes;
        private System.Windows.Forms.Button btn_arquivo_produtos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_novaTabela_Clientes;
        private System.Windows.Forms.Button btn_novaTabela_Produtos;
    }
}

