using EniWine.Investigacao.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EniWine.Investigacao.Library.Services
{
    public class CrimeService
    {
        /// <summary>
        /// Sorteia um crime
        /// </summary>
        /// <returns>Crime</returns>
        public Crime Sortear() {
            try{
                Crime crime = new Crime();

                Random random = new Random();

                SuspeitoService suspeitoService = new SuspeitoService();
                crime.Suspeito = suspeitoService.Find(random.Next(1, 7));

                ArmaService armaService = new ArmaService();
                crime.Arma = armaService.Find(random.Next(1,7));

                LocalService localService = new LocalService();
                crime.Local = localService.Find(random.Next(1, 11));

                return crime; 
            }
            catch (Exception){
                throw;
            }
        }
    }
}
