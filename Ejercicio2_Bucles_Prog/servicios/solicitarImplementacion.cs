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
    /// Implementación de la interfaz solicitar
    /// rbr - 241023
    /// </summary>
    internal class solicitarImplementacion : solicitarInterfaz
    {
        /// <summary>
        /// Método que solicitará por consola un número entero para contar las veces que multiplicar el tipo double
        /// rbr - 241023
        /// </summary>
        /// <returns></returns>
        public int solicitarNumeroVeces()
        {
            int numVeces;
            
            Console.WriteLine("Introduce el número de veces que quieres multiplicar el número:");
            numVeces = Convert.ToInt32(Console.ReadLine());

            return numVeces;
        }

        /// <summary>
        /// Método que pedirá un número de tipo double para multiplicarlo por sí mismo n veces
        /// rbr - 241023
        /// </summary>
        /// <returns></returns>
        public double solicitarNumero()
        {
            double numero;

            Console.WriteLine("Introduce un número decimal (recuerda usar la coma y no el punto):");
            numero = Convert.ToDouble(Console.ReadLine());

            return numero;
        }
    }
}
