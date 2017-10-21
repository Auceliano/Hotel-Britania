using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Britania.BLL
{
    class CheckBll
    {
        /// <summary>
        /// Código ID Interno.
        /// </summary>
        public int CodigoIn { get; set; }

        /// <summary>
        /// Código ID Interno da Unidade.
        /// </summary>
        public int CodigoUni { get; set; }

        /// <summary>
        /// Código ID interno do Hospede.
        /// </summary>
        public int CodigoHos { get; set; }

        /// <summary>
        /// Nome do Hóspede.
        /// </summary>
        public String NomeHos { get; set; }

        /// <summary>
        /// Situação Reserva, CheckIn ou CheckOut.
        /// </summary>
        public String StatusCk { get; set; }

        /// <summary>
        /// Nome da Unidade Habitacional
        /// </summary>
        public String NomeUni { get; set; }

        /// <summary>
        /// Data de entrada do hospede.
        /// </summary>
        public DateTime DataCheckIn { get; set; }

        /// <summary>
        /// Data prevista para Check-Out.
        /// </summary>
        public DateTime DataCheckOut { get; set; }

        /// <summary>
        /// Valor da diária
        /// </summary>
        public long ValorDiaria { get; set; }

        /// <sumary>
        /// Pesquisa Nome Unidade ou Hospede
        /// </Summary>
        public String PesquisaNome { get; set; }

    }
}
