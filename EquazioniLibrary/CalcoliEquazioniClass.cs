using System;

namespace EquazioniLibrary
{
    public class CalcoliEquazioniClass
    {
        public static long Fattoriale(long n)
        {
            if (n < 1)
            {
                return n = 1;
                throw new Exception("il numero non deve essere negativo quindi non può essere calcolato");
            }

            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Fattoriale(n - 1);
            }
        }
    }
}
