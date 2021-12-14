using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_arquivo_clientes_Click(object sender, EventArgs e)
        {
            Arquivo escreverArquivo = new Arquivo();
            escreverArquivo.escreverArquivoClientesAntigos();
        }

        private void btn_arquivo_produtos_Click(object sender, EventArgs e)
        {
            Arquivo escreverArquivo = new Arquivo();
            escreverArquivo.escreverArquivoProdutosAntigos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BancoAntigo bd = new BancoAntigo();

            string sql = "SELECT * from clientes WHERE Nome != null or Nome != '';";

            DataTable dt = new DataTable();

            dt = bd.consulta(sql);

            dataGridView1.DataSource = dt;
        }

        private void btn_novaTabela_Clientes_Click(object sender, EventArgs e)
        {
            Arquivo escreverArquivo = new Arquivo();
            escreverArquivo.novaTabelaClientes();
        }

        private void btn_novaTabela_Produtos_Click(object sender, EventArgs e)
        {
            Arquivo escreverArquivo = new Arquivo();
            escreverArquivo.novaTabelaProdutos();
        }
    }
}
