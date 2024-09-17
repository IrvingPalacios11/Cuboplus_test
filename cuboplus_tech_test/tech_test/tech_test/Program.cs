using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tech_test
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Declaracion de Variables
            double totalBitcoins = 0;
            int totalReduccion = 32; // muestra el total de reducciones a la mitad que se realizaran
            int blocksHalves = 210000; // es el numero de bloques en cada reduccion por mitades
            double initialBitcoin = 50; // esta es la recompensa inicial por bloque
            double suministroMaxB = 21000000; // Suministro maximo de Bitcoins 
            double recompensaBitcoin = 0; // aqui se guardara cada una de las recompensa que se reducen a la mitad
            double bitcoinExtraidos = 0;
            double porcentajeTotal = 0;

            //Creamos lo que es un bucle para que se hagan el total de reducciones que se han pedido
            for (int i = 0; i <= totalReduccion; i++)
            {
                //Aqui se calcula lo que es la recompensa actual que se tendria despues de hacer
                //cada una de las reducciones a la mitad
                recompensaBitcoin = initialBitcoin / Math.Pow(2, i); //initialBitcoin /= 2;

                //Aqui calcularemos  la recompensa de Bitcoins o de bloque en cada una de las estapas
                // se multiplica lo que es el numero total de bloques 210000 entre mitades por el numero
                // de bitcoins emitidos por bloque
                bitcoinExtraidos = blocksHalves * recompensaBitcoin;

                //en la variable total bitcoin se agregan los valores de los bitcoins que se extrajeron
                totalBitcoins += bitcoinExtraidos;

                //Calcular el porcentaje total de los 21 millones de bitcoins en cada una
                //de las extracciones
                porcentajeTotal = (totalBitcoins / suministroMaxB) * 100;

                //Imprimir los resultados
                Console.WriteLine("N° Reducciones:{0,3}   Recompensa: {1,10:F8}    Bitcoin Extraido:{2,15:F2}    Porcentaje{3,10:F2}%", i, recompensaBitcoin, bitcoinExtraidos, porcentajeTotal);
            }

        
        }
    }
}