using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Britania.BLL
{
    public class HospedeBll
    {
        /// <summary>
        /// Código ID interno do Hospede.
        /// </summary>
        public int CodigoHos { get; set; }

        /// <summary>
        /// Nome do Hóspede.
        /// </summary>
        public String NomeHos { get; set; }

        /// <summary>
        /// Naturalidade do Hópede.
        /// </summary>
        public String NaturalidadeHos { get; set; }

        /// <summary>
        /// UF do Hóspede.
        /// </summary>
        public String UFHos { get; set; }

        /// <summary>
        /// Nacionalidade do Hóspede
        /// </summary>
        public String NacionalidadeHos { get; set; }

        /// <summary>
        /// CPF do Hóspede.
        /// </summary>
        public String CPFHos { get; set; }

        /// <summary>
        /// Gênero do Hóspede.
        /// </summary>
        public String SexoHos { get; set; }

        /// <summary>
        /// Data de nascimento do Hóspede.
        /// </summary>
        public DateTime DataNascHos { get; set; }

        /// <summary>
        /// DDD e Telefone de contato do Hóspede.
        /// </summary>
        public String DDDTelefoneHos { get; set; }

        /// <summary>
        /// Correio eletrónico do Hópede.
        /// </summary>
        public String EMail { get; set; }
    }
}
