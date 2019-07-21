using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenI_ChrisAndino
{
    class Program
    {
        static void Main(string[] args)
        {
            //INstancia de la clase
            FuncionesGenerales Funcio = new FuncionesGenerales();

            //Decalracion de variables
            int numero1 = 0, numero2 = 0, numero3 = 0, numero4 = 0, Multiplicacion = 0; ;
            decimal Division = 0;
            decimal Promedio = 0;
            bool esPar = false;

            //Lectura de datos en consola
            Console.Write("Ingrese el numero 1: ");
            numero1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Ingrese el numero 2: ");
            numero2 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Ingrese el numero 3: ");
            numero3 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Ingrese el numero 4: ");
            numero4 = Convert.ToInt16(Console.ReadLine());

            try
            {
                //Funcion de promedio
              
                Funcio.promedio(numero1, numero2, numero3, numero4, out Promedio);
                Console.Write("pro: ");
                //Funcion que verifica si es par
                esPar = Funcio.EsPar(numero1);
                //Funcion que multiplica los 4 numeros
                Multiplicacion = Funcio.Multiplicacion(numero1, numero2, numero3, numero4);
                //Bloque try para controlar posibles errores
                //Funcion de division
                Division = Funcio.Division(numero1, numero2);
            }
            catch(Exception ex)
            {
                ex.Message.ToString();
            }
            Console.ReadLine();
        }
    }
}
