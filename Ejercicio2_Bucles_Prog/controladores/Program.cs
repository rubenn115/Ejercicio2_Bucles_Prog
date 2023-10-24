//Ruben Bernal Ramos
//CSI1

using Ejercicio2_Bucles_Prog.servicios;

namespace Ejercicio2_Bucles_Prog.controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// rbr - 241023
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal de la aplicación
        /// rbr - 241023
        /// </summary>
        /// <param name="args"></param>
        static public void Main(string[] args)
        {
            //Declaro las variables
            int numVeces;
            double numero, total;

            //Instancio las interfaces con sus implementaciones
            solicitarInterfaz si = new solicitarImplementacion();
            calcularInterfaz ci = new calcularImplementación();

            //Solicito el número de veces a multiplicar
            numVeces = si.solicitarNumeroVeces();
            //Solicito el número a multiplicar por sí mismo
            numero = si.solicitarNumero();

            //Realizo la operación y muestro el total
            total = ci.calculoTotal(numVeces, numero);
        }
    }
}