using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio3
{
    class BancoAntigo
    {
        private string stringConexao = "Data Source=localhost; Initial Catalog=desafio3; USER ID=sa; password=1234; language=Portuguese ";

        private SqlConnection conectaBanco;

        private void conexao()
        {
            conectaBanco = new SqlConnection(stringConexao);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                conexao();
                conectaBanco.Open();
                return conectaBanco;
            }
            catch (Exception err)
            {
                return null;
            }
        }

        public void fecharConexao()
        {
            try
            {
                conectaBanco.Close();
            }
            catch (Exception err)
            {
                return;
            }
        }

        public DataTable consulta(string sql)
        {
            try
            {
                abrirConexao();

                SqlCommand command = new SqlCommand(sql, conectaBanco);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception err)
            {
                return null;
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}
