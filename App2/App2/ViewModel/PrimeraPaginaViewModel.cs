using System;
using System.Collections.Generic;
using System.Text;

namespace App2.ViewModel
{
    class PrimeraPaginaViewModel
    {
        public string Suma(string A, string B)
        {
            string Resultado = (Int64.Parse(A) + Int64.Parse(B)).ToString();
            return Resultado;
        }

        public string Resta(string A, string B)
        {
            string Resultado = (Int64.Parse(A) - Int64.Parse(B)).ToString();
            return Resultado;
        }
    }
}
