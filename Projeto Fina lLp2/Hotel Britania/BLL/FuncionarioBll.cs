using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Britania.BLL
{
    class FuncionarioBll
    {
        /// <summary>
        /// Código ID interno do Funcionário.
        /// </summary>
        public int CodigoFun { get; set; }

        /// <summary>
        /// Nome do Funcionário.
        /// </summary>
        public String NomeFun { set; get; }

        /// <summary>
        /// Cargo ocupado pelo Funcionário.
        /// </summary>
        public String CargoFun { get; set; }

        /// <summary>
        /// Nome de Usuário do Funcionário para acesso ao sistema.
        /// </summary>
        public String UsuarioFun { set; get; }

        /// <summary>
        /// Senha para autenticão.
        /// </summary>
        public String SenhaFun { get; set; }

        /// <summary>
        /// Remuneração ofertada ao  Funcionário.
        /// </summary>
        public String SalarioFun { get; set; }

        /// <summary>
        /// Registra a data que o Funcionário foi empregado.
        /// </summary>
        public DateTime DataEntradaFun { get; set; }

        /// <summary>
        /// Naturalidade do Funcionário.
        /// </summary>
        public String NaturalidadeFun { get; set; }

        /// <summary>
        /// UF do Funcionário.
        /// </summary>
        public String UFFun { get; set; }

        /// <summary>
        /// Naturalidade do Funcionário.
        /// </summary>
        public String NacionalidadeFun { get; set; }

        /// <summary>
        /// CPF do Funcionário.
        /// </summary>
        public String CPFFun { get; set; }

        /// <summary>
        /// Género do Funcionário.
        /// </summary>
        public String SexoFun { get; set; }

        /// <summary>
        /// Data de nascimento do Funcionário.
        /// </summary>
        public DateTime DataNasFun { get; set; }

        /// <summary>
        /// DDD e Telefone do Funcionário.
        /// </summary>
        public String DDDTelefoneFun { get; set; }

        /// <summary>
        /// Correio eletrónico do Funcionário.
        /// </summary>
        public String EMailFun { get; set; }
    }
}
