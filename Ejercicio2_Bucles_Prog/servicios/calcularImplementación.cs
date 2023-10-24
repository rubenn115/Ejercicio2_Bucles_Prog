//Ruben Bernal Ramos
//CSI1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Bucles_Prog.servicios
{
    /// <summary>
    /// Implementación de la interfaz calcular
    /// rbr - 241023
    /// </summary>
    internal class calcularImplementación : calcularInterfaz
    {
        /// <summary>
        /// Método solicitado que realizará el cálculo con multiplicación
        /// rbr - 241023
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="numVeces"></param>
        /// <returns></returns>
        public double calculoTotal(int numVeces, double numero)
        {
            double total = 0;
            double numAnterior = numero;
            //int contador = 0;

            for (int contador=0;contador<=numVeces;contador++)
            {
                total = numAnterior * numero;
            }

            /*do
            {
                total = numero * numero;
            } while (contador < numVeces);*/

            Console.WriteLine("La suma total de la multiplicación es: " + total);

            return total;
        }
    }
}
