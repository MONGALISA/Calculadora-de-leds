/*  R é a resistência em ohms do resistencia adequado 
 *  para o LED, isso é o que você tem que descobrir.
    V é a fonte de tensão que você vai usar no LED.
    Vled é a tensão em volts do LED.
    I é a corrente do LED em amperes
*/
using System;

namespace Calculadora_de_leds
{
    class Program
    {
        static void Main(string[] args)
        {
            float vled;   // volts do led
            float aled;   // amperes do led
            float tensao; // tensao aplicado
            float R;      // Ohms 
            float v;
            int s;        // sair ou ficar
            do
            {
                
                Console.Write("Insira a tensao (Volts) da alimentaçao:  ");
                tensao = Convert.ToSingle(Console.ReadLine());
                Console.Write("Insira a tensao (Volts) do Led:  ");
                vled = Convert.ToSingle(Console.ReadLine());
                Console.Write("Insira a corrente (Amperes) do led:  ");
                aled = Convert.ToSingle(Console.ReadLine());
                v = tensao - vled;
                R = v / aled;
                if (R < 100)
                {
                    Console.WriteLine("Incorreto algum dos numeros esta mal.");
                }
                else
                {
                    Console.WriteLine("Resistencia para o led nessesaria: {0}", R);
                    Console.WriteLine("O valor do calculo pode ser diferente a referencia da resistencia.");
                    Console.WriteLine("Ou seja tem que se por uma resistencia aproximada a esse valor. ");
                }  
                Console.Write("Inserir 1 para continuar senao clique 0 para sair:  ");
                s = Convert.ToInt32(Console.ReadLine());
                if(s == 1 )
                {
                    Console.Clear();
                }
            } while ( s != 0);
            
        }
    }
}
