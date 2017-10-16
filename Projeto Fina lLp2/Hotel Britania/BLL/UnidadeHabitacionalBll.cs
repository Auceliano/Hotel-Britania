using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Britania.BLL
{
    class UnidadeHabitacionalBll
    {
        /// <summary>
        /// Codigo ID interno da Unidade Habitacional.
        /// </summary> 
        public int Codigo { get; set; }

        /// <summary>
        /// Nome atribuido a Unidade Habitacional.
        /// </summary>
        public String NomeUni { get; set; }

        /// <summary>
        /// Número da Unidade.
        /// </summary>
        public String NumeroUni { get; set; }

        /// <summary>
        /// Valor da diária da Unidade.
        /// </summary>
        public String ValorDiariaUni { get; set; }

        /// <summary>
        /// Descrição adicional.
        /// </summary>
        public String DescricaoUni { get; set; }

        /// <summary>
        /// Unidade Com Suite e Cama de Casal.
        /// </summary>
        public bool SuiteMarried { get; set; }

        /// <summary>
        /// Unidade Com Suite e Cama Solteiro.
        /// </summary>
        public bool SuiteSingle { get; set; }

        /// <summary>
        /// Quantidade de Camas.
        /// </summary>
        public bool DuasCamas { get; set; }

        /// <summary>
        /// Climatizador disponível.
        /// </summary>
        public bool Climatizador { get; set; }

        /// <summary>
        /// Frigobar disponível.
        /// </summary>
        public bool Frigobar { get; set; }

        /// <summary>
        /// Internet Wireless.
        /// </summary>
        public bool Wireless { get; set; }
    }
}
