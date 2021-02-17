using System;

namespace Examen1
{
    class Program
    {
        static void Main(string[] args)
        {
            int monto = 0;
            string banco;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Bienbenido al cajero FDP INVERSMENTS");
                Console.WriteLine("");
                Console.WriteLine("1. Depositar");
                Console.WriteLine("");
                Console.WriteLine("2. Retiro");
                Console.WriteLine("");
                Console.WriteLine("3. Salir");
                Console.WriteLine("");
                Console.WriteLine("Elija un numero del menu");
                int res = int.Parse(Console.ReadLine());

                if (res == 1)
                {
                    Console.WriteLine("Introduzca el monto a depositar: ");
                    int dep = int.Parse(Console.ReadLine());
                    Console.WriteLine("Usted ha depositado "+dep+" pesos");
                    
                } 

                if (res == 2)
                {
                    Console.Write("Introduzca FDP o el nombre del banco: ");
                    banco = Console.ReadLine();
                        
                    if (banco == "FDP")
                    {
                        Console.Write("Introduzca el monto a retirar: ");
                        monto = Convert.ToInt32(Console.ReadLine());
                        if (monto<20000)
                        {
                            Console.WriteLine("Usted Retiro {0} pesos", monto);
                        } 
                        else
                        {
                            Console.WriteLine("Este banco solo permite retiros de igual o menor valor de 20,000 pesos, por favor digite un monto menor");
                            Console.ReadKey();
                            
                        }
                            
                            
                    }
                    else
                    {
                       Console.Write("Introduzca el monto a retirar: ");
                        monto = Convert.ToInt32(Console.ReadLine());
                        if (monto<10000)
                        {
                            Console.WriteLine("Usted Retiro {0} pesos", monto);
                        }
                        else
                        {
                            Console.WriteLine("Este banco solo permite retiros de igual o menor valor de 10,000 pesos, por favor digite un monto menor");
                            Console.ReadKey();
                        }  
                    }

                }

                if (res == 3)
                {
                    Console.WriteLine("Gracias por visitarnos");
                    break;
                }
                    
            } while (true);
            
        }
    }
}
