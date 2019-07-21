using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenI_ChrisAndino
{
    class FuncionesGenerales
    {
        public void promedio(int numero1, int numero2, int numero3, int numero4, out decimal Promedio)
        {
            Promedio = 0;
            Promedio = Convert.ToDecimal(numero1 + numero2 + numero3 + numero4) / 4;
        }

        public bool EsPar(int numero)
        {
            if (numero % 2 == 0)
                return true;
            else
                return false;
        }

        public int Multiplicacion(int numero1, int numero2, int numero3, int numero4)
        {
            int Resultado = 0;
            Resultado = numero1 * numero2 * numero3 * numero4;
            return Resultado;
        }

        public decimal Division(int numero1,int numero2)
        {
            return Convert.ToDecimal(numero1) / Convert.ToDecimal(numero2);
        }
    }
}
