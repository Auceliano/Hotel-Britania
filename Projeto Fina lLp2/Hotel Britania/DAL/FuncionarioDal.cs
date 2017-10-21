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
    class FuncionarioDal
    {
        public void Salva(FuncionarioBll funcionario)
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
            comando.CommandText = "INSERT INTO tbFuncionario (FUN_NOME,FUN_DATAENTRADA,FUN_CARGO,FUN_USUARIO,FUN_SENHA,FUN_SALARIO,FUN_NATURALIDADE,FUN_UF,FUN_NACIONALIDADE,FUN_CPF,FUN_SEXO,FUN_DATANASCIMENTO,FUN_TELEFONE,FUN_EMAIL) " +
            "VALUES (@FUN_NOME,@FUN_DATAENTRADA,@FUN_CARGO,@FUN_USUARIO,@FUN_SENHA,@FUN_SALARIO,@FUN_NATURALIDADE,@FUN_UF,@FUN_NACIONALIDADE,@FUN_CPF,@FUN_SEXO,@FUN_DATANASCIMENTO,@FUN_TELEFONE,@FUN_EMAIL)";

            comando.Parameters.AddWithValue("@FUN_NOME", funcionario.NomeFun);
            comando.Parameters.AddWithValue("@FUN_DATAENTRADA", funcionario.DataEntradaFun);
            comando.Parameters.AddWithValue("@FUN_CARGO", funcionario.CargoFun);
            comando.Parameters.AddWithValue("@FUN_USUARIO", funcionario.UsuarioFun);
            comando.Parameters.AddWithValue("@FUN_SENHA", funcionario.SenhaFun);
            comando.Parameters.AddWithValue("@FUN_SALARIO", funcionario.SalarioFun);
            comando.Parameters.AddWithValue("@FUN_NATURALIDADE", funcionario.NaturalidadeFun);
            comando.Parameters.AddWithValue("@FUN_UF", funcionario.UFFun);
            comando.Parameters.AddWithValue("@FUN_NACIONALIDADE", funcionario.NacionalidadeFun);
            comando.Parameters.AddWithValue("@FUN_CPF", funcionario.CPFFun);
            comando.Parameters.AddWithValue("@FUN_SEXO", funcionario.SexoFun);
            comando.Parameters.AddWithValue("@FUN_DATANASCIMENTO", funcionario.DataNasFun);
            comando.Parameters.AddWithValue("@FUN_TELEFONE", funcionario.DDDTelefoneFun);
            comando.Parameters.AddWithValue("@FUN_EMAIL", funcionario.EMailFun);

            //6 - Abrir  a conexão
            conexao.Open();

            //7 - Executar o comando
            comando.ExecuteNonQuery();

            //8 - Fexar a conexão
            conexao.Close();
        }

        //Exclui dados do BD
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
            comando.CommandText = "DELETE FROM tbFuncionario WHERE FUN_ID = @FUN_ID";

            comando.Parameters.AddWithValue("@FUN_ID", codigo);


            //6 - Abrir  a conexão
            conexao.Open();

            //7 - Executar o comando
            comando.ExecuteNonQuery();

            //8 - Fexar a conexão
            conexao.Close();
        }

        public void Altera(FuncionarioBll funcionario)
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
            comando.CommandText = "UPDATE tbFuncionario " +
                "SET FUN_NOME = @FUN_NOME, " +
                    "FUN_DATAENTRADA = @FUN_DATAENTRADA, " +
                    "FUN_CARGO = @FUN_CARGO, " +
                    "FUN_USUARIO = @FUN_USUARIO, " +
                    "FUN_SENHA = @FUN_SENHA, " +
                    "FUN_SALARIO = @FUN_SALARIO, " +
                    "FUN_NATURALIDADE = @FUN_NATURALIDADE, " +
                    "FUN_UF = @FUN_UF, " +
                    "FUN_NACIONALIDADE = @FUN_NACIONALIDADE, " +
                    "FUN_CPF = @FUN_CPF, " +
                    "FUN_SEXO = @FUN_SEXO, " +
                    "FUN_DATANASCIMENTO = @FUN_DATANASCIMENTO, " +
                    "FUN_TELEFONE = @FUN_TELEFONE, " +
                    "FUN_EMAIL = @FUN_EMAIL " +
              "WHERE FUN_ID = @FUN_ID";


            comando.Parameters.AddWithValue("@FUN_ID", funcionario.CodigoFun);
            comando.Parameters.AddWithValue("@FUN_NOME", funcionario.NomeFun);
            comando.Parameters.AddWithValue("@FUN_DATAENTRADA", funcionario.DataEntradaFun);
            comando.Parameters.AddWithValue("@FUN_CARGO", funcionario.CargoFun);
            comando.Parameters.AddWithValue("@FUN_USUARIO", funcionario.UsuarioFun);
            comando.Parameters.AddWithValue("@FUN_SENHA", funcionario.SenhaFun);
            comando.Parameters.AddWithValue("@FUN_SALARIO", funcionario.SalarioFun);
            comando.Parameters.AddWithValue("@FUN_NATURALIDADE", funcionario.NaturalidadeFun);
            comando.Parameters.AddWithValue("@FUN_UF", funcionario.UFFun);
            comando.Parameters.AddWithValue("@FUN_NACIONALIDADE", funcionario.NacionalidadeFun);
            comando.Parameters.AddWithValue("@FUN_CPF", funcionario.CPFFun);
            comando.Parameters.AddWithValue("@FUN_SEXO", funcionario.SexoFun);
            comando.Parameters.AddWithValue("@FUN_DATANASCIMENTO", funcionario.DataNasFun);
            comando.Parameters.AddWithValue("@FUN_TELEFONE", funcionario.DDDTelefoneFun);
            comando.Parameters.AddWithValue("@FUN_EMAIL", funcionario.EMailFun);

            //6 - Abrir  a conexão
            conexao.Open();

            //7 - Executar o comando
            comando.ExecuteNonQuery();

            //8 - Fexar a conexão
            conexao.Close();
        }

    }
}
