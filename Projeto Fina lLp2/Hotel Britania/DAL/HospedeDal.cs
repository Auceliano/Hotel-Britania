using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Hotel_Britania.BLL;

namespace Hotel_Britania.DAL
{
    public class HospedeDal
    {
        public void Salvar(HospedeBll hospede)
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
            comando.CommandText = "INSERT INTO tbHospede (HOS_NOME,HOS_NATURALIDADE,HOS_UF,HOS_NACIONALIDADE,HOS_CPF,HOS_SEXO,HOS_DATANASCIMENTO,HOS_TELEFONE,HOS_EMAIL) " +
                                              "VALUES (@HOS_NOME,@HOS_NATURALIDADE,@HOS_UF,@HOS_NACIONALIDADE,@HOS_CPF,@HOS_SEXO,@HOS_DATANASCIMENTO,@HOS_TELEFONE,@HOS_EMAIL)";

            comando.Parameters.AddWithValue("@HOS_NOME", hospede.NomeHos);
            comando.Parameters.AddWithValue("@HOS_NATURALIDADE", hospede.NaturalidadeHos);
            comando.Parameters.AddWithValue("@HOS_UF", hospede.UFHos);
            comando.Parameters.AddWithValue("@HOS_NACIONALIDADE", hospede.NacionalidadeHos);
            comando.Parameters.AddWithValue("@HOS_CPF", hospede.CPFHos);
            comando.Parameters.AddWithValue("@HOS_SEXO", hospede.SexoHos);
            comando.Parameters.AddWithValue("@HOS_DATANASCIMENTO", hospede.DataNascHos);
            comando.Parameters.AddWithValue("@HOS_TELEFONE", hospede.DDDTelefoneHos);
            comando.Parameters.AddWithValue("@HOS_EMAIL", hospede.EMail);

            //6 - Abrir  a conexão
            conexao.Open();

            //7 - Executar o comando
            comando.ExecuteNonQuery();

            //8 - Fexar a conexão
            conexao.Close();
        }

        public void Alterar(HospedeBll hospede)
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
            comando.CommandText = "UPDATE tbHospede " +
                "SET HOS_NOME = @HOS_NOME, " +
                    "HOS_NATURALIDADE = @HOS_NATURALIDADE, " +
                    "HOS_UF = @HOS_UF, " +
                    "HOS_NACIONALIDADE = @HOS_NACIONALIDADE, " +
                    "HOS_CPF = @HOS_CPF, " +
                    "HOS_SEXO = @HOS_SEXO, " +
                    "HOS_DATANASCIMENTO = @HOS_DATANASCIMENTO, " +
                    "HOS_TELEFONE = @HOS_TELEFONE, " +
                    "HOS_EMAIL = @HOS_EMAIL " +
                    "WHERE HOS_ID = @HOS_ID";


            comando.Parameters.AddWithValue("@HOS_ID", hospede.CodigoHos);
            comando.Parameters.AddWithValue("@HOS_NOME", hospede.NomeHos);
            comando.Parameters.AddWithValue("@HOS_NATURALIDADE", hospede.NaturalidadeHos);
            comando.Parameters.AddWithValue("@HOS_UF", hospede.UFHos);
            comando.Parameters.AddWithValue("@HOS_NACIONALIDADE", hospede.NacionalidadeHos);
            comando.Parameters.AddWithValue("@HOS_CPF", hospede.CPFHos);
            comando.Parameters.AddWithValue("@HOS_SEXO", hospede.SexoHos);
            comando.Parameters.AddWithValue("@HOS_DATANASCIMENTO", hospede.DataNascHos);
            comando.Parameters.AddWithValue("@HOS_TELEFONE", hospede.DDDTelefoneHos);
            comando.Parameters.AddWithValue("@HOS_EMAIL", hospede.EMail);

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
            comando.CommandText = "DELETE FROM tbHospede WHERE HOS_ID = @HOS_ID";

            comando.Parameters.AddWithValue("@HOS_ID", codigo);


            //6 - Abrir  a conexão
            conexao.Open();

            //7 - Executar o comando
            comando.ExecuteNonQuery();

            //8 - Fexar a conexão
            conexao.Close();
        }

        //Pesquisa Rápida
        public HospedeBll Obter(int id)
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
            comando.CommandText = "select * from tbHospede where HOS_ID = @HOS_ID ";
            comando.Parameters.AddWithValue("@HOS_ID", id);


            //6 - Abrir  a conexão
            conexao.Open();

            //7 - Executar o comando
            SqlDataReader reader = comando.ExecuteReader();
            HospedeBll hospede = null;
            while (reader.Read())
            {
                hospede = new HospedeBll();
                //Leitura de cada coluna
                hospede.CodigoHos = Convert.ToInt32(reader["HOS_ID"].ToString());
                hospede.NomeHos = reader["HOS_NOME"].ToString();
                hospede.NaturalidadeHos = reader["HOS_NATURALIDADE"].ToString();
                hospede.UFHos = reader["HOS_UF"].ToString();
                hospede.NacionalidadeHos = reader["HOS_NACIONALIDADE"].ToString();
                hospede.CPFHos = reader["HOS_CPF"].ToString();
                hospede.SexoHos = reader["HOS_SEXO"].ToString();
                hospede.DataNascHos = Convert.ToDateTime(reader["HOS_DATANASCIMENTO"].ToString());
                hospede.DDDTelefoneHos = reader["HOS_TELEFONE"].ToString();
                hospede.EMail = reader["HOS_EMAIL"].ToString();
            }

            //8 - Fexar a conexão
            conexao.Close();

            return hospede;
        }

    }
    
}
