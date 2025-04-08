using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biblioteca
{
    public class AzarRandom:IAzar
    {
        private Random random = new Random();

        public int ObtenerSiguiente(int maximo)
        {
            return random.Next(maximo);
        }
    }
}