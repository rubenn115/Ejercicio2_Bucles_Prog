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
    /// Interfaz para el cálculo que necesitaremos hacer
    /// rbr - 241023
    /// </summary>
    internal interface calcularInterfaz
    {
        /// <summary>
        /// Enunciado del método que tendrá la implementación
        /// rbr - 241023
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="numVeces"></param>
        /// <returns></returns>
        public double calculoTotal(int numVeces, double numero);
    }
}
