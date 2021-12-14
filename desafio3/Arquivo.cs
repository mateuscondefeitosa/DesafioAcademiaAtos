using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio3
{
    class Arquivo
    {
        public void escreverArquivoClientesAntigos()
        {
            StreamWriter sw = new StreamWriter("C:\\desafio3\\ClientesAntigos.txt", true, Encoding.UTF8);

            BancoAntigo bd = new BancoAntigo();

            string sql = "SELECT * from clientes WHERE Nome != null or Nome != '';";

            DataTable dt = new DataTable();

            dt = bd.consulta(sql);


            sw.WriteLine("CPF-Nome-Telefone-Email");
            foreach (DataRow row in dt.Rows)
            {
                sw.Write(row[0].ToString());
                sw.Write("-");
                sw.Write(row[1].ToString());
                sw.Write("-");
                sw.Write(row[2].ToString());
                sw.Write("-");
                sw.Write(row[3].ToString());
                sw.WriteLine();
            }
            sw.Close();
        }

        public void escreverArquivoProdutosAntigos()
        {
            StreamWriter sw = new StreamWriter("C:\\desafio3\\ProdutosAntigos.txt", true, Encoding.UTF8);

            BancoAntigo bd = new BancoAntigo();

            string sql = "SELECT * from produtos WHERE estoque > 0;";

            DataTable dt = new DataTable();
            dt = bd.consulta(sql);


            sw.WriteLine("CodEAN-Nome-preco-estoque");
            foreach (DataRow row in dt.Rows)
            {
                sw.Write(row[0].ToString());
                sw.Write("-");
                sw.Write(row[1].ToString());
                sw.Write("-");
                sw.Write(row[2].ToString());
                sw.Write("-");
                sw.Write(row[3].ToString());
                sw.WriteLine();
            }
            sw.Close();
        }


        public void novaTabelaClientes()
        {
            StreamWriter sw = new StreamWriter("C:\\desafio3\\novosClientes.txt", true, Encoding.UTF8);

            BancoAntigo bd = new BancoAntigo();

            string sql = "SELECT * from clientes WHERE Nome != null or Nome != '';";

            DataTable dt = new DataTable();

            dt = bd.consulta(sql);

            Random rnd = new Random();
            sw.WriteLine("ID-CPF-Nome-Telefone-Email-");
            foreach (DataRow row in dt.Rows)
            {
                sw.Write(rnd.Next(1, 2000000000).ToString());
                sw.Write("-");
                sw.Write(row[0].ToString());
                sw.Write("-");
                sw.Write(row[1].ToString());
                sw.Write("-");
                sw.Write(row[2].ToString());
                sw.Write("-");
                sw.Write(row[3].ToString());
                sw.WriteLine();
            }
            sw.Close();
        }


        public void novaTabelaProdutos()
        {
            StreamWriter sw = new StreamWriter("C:\\desafio3\\novosProdutos.txt", true, Encoding.UTF8);

            BancoAntigo bd = new BancoAntigo();

            string sql = "SELECT * from produtos WHERE estoque > 0;";

            DataTable dt = new DataTable();
            dt = bd.consulta(sql);

            Random rnd = new Random();
            sw.WriteLine("ID-CodEAN-Nome-preco-estoque");
            foreach (DataRow row in dt.Rows)
            {
                sw.Write(rnd.Next(1, 2000000000).ToString());
                sw.Write("-");
                sw.Write(row[0].ToString());
                sw.Write("-");
                sw.Write(row[1].ToString());
                sw.Write("-");
                sw.Write(row[2].ToString());
                sw.Write("-");
                sw.Write(row[3].ToString());
                sw.WriteLine();
            }
            sw.Close();
        }
    }
}
