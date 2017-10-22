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
    class CheckDal
    {
        public void Salva(CheckBll IN)
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

            comando.CommandText = "INSERT INTO tbCheck (CK_STATUS, CK_DATACHECKIN, CK_DATACHECKOUT, FK_HOSPEDE, FK_UNIDADEHABITACIONAL)" +
                                              "VALUES (@CK_STATUS, @CK_DATACHECKIN, @CK_DATACHECKOUT, @FK_HOSPEDE, @FK_UNIDADEHABITACIONAL)";

            comando.Parameters.AddWithValue("@CK_STATUS", IN.StatusCk);
            comando.Parameters.AddWithValue("@CK_DATACHECKIN", IN.DataCheckIn);
            comando.Parameters.AddWithValue("@CK_DATACHECKOUT", IN.DataCheckOut);
            comando.Parameters.AddWithValue("@FK_HOSPEDE", IN.CodigoHos);
            comando.Parameters.AddWithValue("@FK_UNIDADEHABITACIONAL", IN.CodigoUni);
            
            //6 - Abrir  a conexão
            conexao.Open();

            //7 - Executar o comando
            comando.ExecuteNonQuery();

            //8 - Fexar a conexão
            conexao.Close();
        }

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
            comando.CommandText = "DELETE  FROM tbCheck WHERE FK_UNIDADEHABITACIONAL = @FK_UNIDADEHABITACIONAL";

            comando.Parameters.AddWithValue("@FK_UNIDADEHABITACIONAL", codigo);


            //6 - Abrir  a conexão
            conexao.Open();

            //7 - Executar o comando
            comando.ExecuteNonQuery();

            //8 - Fexar a conexão
            conexao.Close();
        }

        //Pesquisa Rápida
        public CheckBll Obter(int id)
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
            comando.CommandText = "select * from tbCheck where CK_ID = @CK_ID ";
            comando.Parameters.AddWithValue("@CK_ID", id);


            //6 - Abrir  a conexão
            conexao.Open();

            //7 - Executar o comando
            SqlDataReader reader = comando.ExecuteReader();
            CheckBll check = null;
            while (reader.Read())
            {
                check = new CheckBll();
                //Leitura de cada coluna
                check.CodigoIn = Convert.ToInt32(reader["CK_ID"].ToString());
                check.StatusCk = reader["CK_STATUS"].ToString();
                check.DataCheckIn = Convert.ToDateTime(reader["CK_DATACHECKIN"].ToString());
                check.DataCheckOut = Convert.ToDateTime(reader["CK_DATACHECKOUT"].ToString());
                check.CodigoHos = Convert.ToInt32(reader["FK_HOSPEDE"].ToString());
                check.CodigoUni = Convert.ToInt32(reader["Fk_UNIDADEHABITACIONAL"].ToString());
            }

            //8 - Fexar a conexão
            conexao.Close();

            return check;
        }

        public void Alterar(CheckBll check)
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
            comando.CommandText = "UPDATE tbCheck " +
                "SET CK_STATUS = @CK_STATUS, " +
                    "CK_DATACHECKIN = @CK_DATACHECKIN, " +
                    "CK_DATACHECKOUT = @CK_DATACHECKOUT, " +
                    "FK_HOSPEDE = @FK_HOSPEDE, " +
                    "FK_UNIDADEHABITACIONAL = @FK_UNIDADEHABITACIONAL " +
                    "WHERE CK_ID = @CK_ID";


            comando.Parameters.AddWithValue("@CK_ID", check.CodigoIn);
            comando.Parameters.AddWithValue("@CK_STATUS", check.StatusCk);
            comando.Parameters.AddWithValue("@CK_DATACHECKIN", check.DataCheckIn);
            comando.Parameters.AddWithValue("@CK_DATACHECKOUT", check.DataCheckOut);
            comando.Parameters.AddWithValue("@FK_HOSPEDE", check.CodigoHos);
            comando.Parameters.AddWithValue("@FK_UNIDADEHABITACIONAL", check.CodigoUni);

            //6 - Abrir  a conexão
            conexao.Open();

            //7 - Executar o comando
            comando.ExecuteNonQuery();

            //8 - Fexar a conexão
            conexao.Close();
        }

    }
}
