using EniWine.Investigacao.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EniWine.Investigacao.Library.Services
{
    public class JogoService
    {
        public Crime Crime { get; set; }

        public JogoService(Crime crime)
        {
            this.Crime = crime;
        }
        /// <summary>
        /// Verifica se uma determinada teoria desvendou o crime
        /// </summary>
        /// <param name="suspeito">código do suspeito</param>
        /// <param name="arma">código da arma</param>
        /// <param name="local">código do local</param>
        /// <returns>
        /// 1 indica que o assassino está incorreto; 
        /// 2 indica que o local está incorreto; 
        /// 3 indica que a arma está incorreta. 
        /// todos corretos, você solucionou o caso
        /// </returns>
        public int VerificarTeoria(int suspeito, int arma, int local) {
            try{

                if (suspeito != this.Crime.Suspeito.Id)
                    return 1;

                if (local != this.Crime.Local.Id)
                    return 2;

                if (arma != this.Crime.Arma.Id)
                    return 3;

                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
