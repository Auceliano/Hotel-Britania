using Hotel_Britania.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Britania.DAL
{
    class UnidadeHabitacionalDal
    {
        public void Salva(UnidadeHabitacionalBll unidade)
        {
            //1 - Criar uma conexão com BD
            SqlConnection conexao = new SqlConnection();

            //2 - Configurara a conexão
            conexao.ConnectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;

            //3 - Criar um comando
            SqlCommand comando = conexao.CreateCommand();

            //4 - Especificar o tipo de comando
            comando.CommandType = System.Data.CommandType.Text;

            //5 - Especificar o comando
            comando.CommandText = "INSERT INTO tbUnidadeHabitacional (UNI_NOME,UNI_NUMERO,UNI_VALORDIARIA,UNI_DESCRICAO,UNI_SUITEMARIED,UNI_SUITESINGLE,UNI_DUASCAMAS,UNI_CLIMATIZADOR,UNI_FRIGOBAR,UNI_WIRELESS) " +
                                              "VALUES (@UNI_NOME,@UNI_NUMERO,@UNI_VALORDIARIA,@UNI_DESCRICAO,@UNI_SUITEMARIED,@UNI_SUITESINGLE,@UNI_DUASCAMAS,@UNI_CLIMATIZADOR,@UNI_FRIGOBAR,@UNI_WIRELESS)";

            comando.Parameters.AddWithValue("@UNI_NOME", unidade.NomeUni);
            comando.Parameters.AddWithValue("@UNI_NUMERO", unidade.NumeroUni);
            comando.Parameters.AddWithValue("@UNI_VALORDIARIA", unidade.ValorDiariaUni);
            comando.Parameters.AddWithValue("@UNI_DESCRICAO", unidade.DescricaoUni);
            comando.Parameters.AddWithValue("@UNI_SUITEMARIED", unidade.SuiteMarried);
            comando.Parameters.AddWithValue("@UNI_SUITESINGLE", unidade.SuiteSingle);
            comando.Parameters.AddWithValue("@UNI_DUASCAMAS", unidade.DuasCamas);
            comando.Parameters.AddWithValue("@UNI_CLIMATIZADOR", unidade.Climatizador);
            comando.Parameters.AddWithValue("@UNI_FRIGOBAR", unidade.Frigobar);
            comando.Parameters.AddWithValue("@UNI_WIRELESS", unidade.Wireless);

            //6 - Abrir  a conexão
            conexao.Open();

            //7 - Executar o comando
            comando.ExecuteNonQuery();

            //8 - Fexar a conexão
            conexao.Close();
        }


        //Exclui conteudo do Banco de Dados
        public void Exclui(int codigo)
        {
            //1 - Criar uma conexão com BD
            SqlConnection conexao = new SqlConnection();

            //2 - Configurara a conexão
            conexao.ConnectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;

            //3 - Criar um comando
            SqlCommand comando = conexao.CreateCommand();

            //4 - Especificar o tipo de comando
            comando.CommandType = System.Data.CommandType.Text;

            //5 - Especificar o comando
            comando.CommandText = "DELETE  FROM tbUnidadeHabitacional WHERE UNI_ID = @UNI_ID";

            comando.Parameters.AddWithValue("@UNI_ID", codigo);


            //6 - Abrir  a conexão
            conexao.Open();

            //7 - Executar o comando
            comando.ExecuteNonQuery();

            //8 - Fexar a conexão
            conexao.Close();
        }



        //Pesquisa Rápida
        public UnidadeHabitacionalBll pesquisaRapida(String nome)
        {
            //1 - Criar uma conexão com BD
            SqlConnection conexao = new SqlConnection();

            //2 - Configurara a conexão
            conexao.ConnectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;

            //3 - Criar um comando
            SqlCommand comando = conexao.CreateCommand();

            //4 - Especificar o tipo de comando
            comando.CommandType = System.Data.CommandType.Text;

            //5 - Especificar o comando
            comando.CommandText = "select * from tbUnidadeHabitacional where Uni_NOME = @UNI_NOME ";
            comando.Parameters.AddWithValue("@UNI_NOME", nome);


            //6 - Abrir  a conexão
            conexao.Open();

            //7 - Executar o comando
            SqlDataReader reader = comando.ExecuteReader();
            UnidadeHabitacionalBll unidade = null;
            while (reader.Read())
            {
                unidade = new UnidadeHabitacionalBll();
                //Leitura de cada coluna
                unidade.Codigo = Convert.ToInt32(reader["UNI_ID"].ToString());
                unidade.NomeUni = reader["UNI_NOME"].ToString();
                unidade.NumeroUni = reader["UNI_NUMERO"].ToString();
                unidade.ValorDiariaUni = reader["UNI_VALORDIARIA"].ToString();
                unidade.DescricaoUni = reader["UNI_DESCRICAO"].ToString();
                unidade.SuiteMarried = Convert.ToBoolean(reader["UNI_SUITEMARIED"].ToString());
                unidade.SuiteSingle = Convert.ToBoolean(reader["UNI_SUITESINGLE"].ToString());
                unidade.DuasCamas = Convert.ToBoolean(reader["UNI_DUASCAMAS"].ToString());
                unidade.Climatizador = Convert.ToBoolean(reader["UNI_CLIMATIZADOR"].ToString());
                unidade.Frigobar = Convert.ToBoolean(reader["UNI_FRIGOBAR"].ToString());
                unidade.Wireless = Convert.ToBoolean(reader["UNI_WIRELESS"].ToString());

            }

            //8 - Fexar a conexão
            conexao.Close();

            return unidade;
        }

        public void Altera(UnidadeHabitacionalBll unidade)
        {
            //1 - Criar uma conexão com BD
            SqlConnection conexao = new SqlConnection();

            //2 - Configurara a conexão
            conexao.ConnectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;

            //3 - Criar um comando
            SqlCommand comando = conexao.CreateCommand();

            //4 - Especificar o tipo de comando
            comando.CommandType = System.Data.CommandType.Text;

            //5 - Especificar o comando
            comando.CommandText = "UPDATE tbUnidadeHabitacional " +
                "SET UNI_NOME = @UNI_NOME, " +
                    "UNI_NUMERO = @UNI_NUMERO, " +
                    "UNI_VALORDIARIA = @UNI_VALORDIARIA, " +
                    "UNI_DESCRICAO = @UNI_DESCRICAO, " +
                    "UNI_SUITEMARIED = @UNI_SUITEMARIED, " +
                    "UNI_SUITESINGLE = @UNI_SUITESINGLE, " +
                    "UNI_DUASCAMAS = @UNI_DUASCAMAS, " +
                    "UNI_CLIMATIZADOR = @UNI_CLIMATIZADOR, " +
                    "UNI_FRIGOBAR = @UNI_FRIGOBAR, " +
                    "UNI_WIRELESS = @UNI_WIRELESS " +
              "WHERE UNI_ID = @UNI_ID";


            comando.Parameters.AddWithValue("@UNI_ID", unidade.Codigo);
            comando.Parameters.AddWithValue("@UNI_NOME", unidade.NomeUni);
            comando.Parameters.AddWithValue("@UNI_NUMERO", unidade.NumeroUni);
            comando.Parameters.AddWithValue("@UNI_VALORDIARIA", unidade.ValorDiariaUni);
            comando.Parameters.AddWithValue("@UNI_DESCRICAO", unidade.DescricaoUni);
            comando.Parameters.AddWithValue("@UNI_SUITEMARIED", unidade.SuiteMarried);
            comando.Parameters.AddWithValue("@UNI_SUITESINGLE", unidade.SuiteSingle);
            comando.Parameters.AddWithValue("@UNI_DUASCAMAS", unidade.DuasCamas);
            comando.Parameters.AddWithValue("@UNI_CLIMATIZADOR", unidade.Climatizador);
            comando.Parameters.AddWithValue("@UNI_FRIGOBAR", unidade.Frigobar);
            comando.Parameters.AddWithValue("@UNI_WIRELESS", unidade.Wireless);

            //6 - Abrir  a conexão
            conexao.Open();

            //7 - Executar o comando
            comando.ExecuteNonQuery();

            //8 - Fexar a conexão
            conexao.Close();
        }

        //Pesquisa Rápida
        public UnidadeHabitacionalBll Obter(int id)
        {
            //1 - Criar uma conexão com BD
            SqlConnection conexao = new SqlConnection();

            //2 - Configurara a conexão
            conexao.ConnectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;

            //3 - Criar um comando
            SqlCommand comando = conexao.CreateCommand();

            //4 - Especificar o tipo de comando
            comando.CommandType = System.Data.CommandType.Text;

            //5 - Especificar o comando
            comando.CommandText = "select * from tbUnidadeHabitacional where UNI_ID = @UNI_ID ";
            comando.Parameters.AddWithValue("@UNI_ID", id);


            //6 - Abrir  a conexão
            conexao.Open();

            //7 - Executar o comando
            SqlDataReader reader = comando.ExecuteReader();
            UnidadeHabitacionalBll unidade = null;
            while (reader.Read())
            {
                unidade = new UnidadeHabitacionalBll();

                //Leitura de cada coluna
                unidade.Codigo = id;
                unidade.NomeUni = reader["UNI_NOME"].ToString();
                unidade.NumeroUni = reader["UNI_NUMERO"].ToString();
                unidade.ValorDiariaUni = reader["UNI_VALORDIARIA"].ToString();
                unidade.DescricaoUni = reader["UNI_DESCRICAO"].ToString();
                unidade.SuiteMarried = Convert.ToBoolean(reader["UNI_SUITEMARIED"].ToString());
                unidade.SuiteSingle = Convert.ToBoolean(reader["UNI_SUITESINGLE"].ToString());
                unidade.DuasCamas = Convert.ToBoolean(reader["UNI_DUASCAMAS"].ToString());
                unidade.Climatizador = Convert.ToBoolean(reader["UNI_CLIMATIZADOR"].ToString());
                unidade.Frigobar = Convert.ToBoolean(reader["UNI_FRIGOBAR"].ToString());
                unidade.Wireless = Convert.ToBoolean(reader["UNI_WIRELESS"].ToString());
            }

            //8 - Fexar a conexão
            conexao.Close();

            return unidade;
        }
    }
}
