using System;

namespace _01._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputPokePower = int.Parse(Console.ReadLine()); // N
            int inputDistance = int.Parse(Console.ReadLine()); // M
            int inputExhaustionFactor = int.Parse(Console.ReadLine()); // Y
            int targetsPoked = 0;


            int exactlyExhaust = inputPokePower;

            while (inputPokePower >= inputDistance)
            {
                
                if(((double)inputPokePower / exactlyExhaust) == 0.5)
                {
                    
                    if(inputPokePower > inputExhaustionFactor)
                    {
                        if(inputExhaustionFactor != 1 && inputExhaustionFactor != 0)
                        {
                            inputPokePower /= inputExhaustionFactor;
                        }
                        else
                        {
                            inputPokePower -= inputDistance;
                            targetsPoked++;
                        }
                        
                    }
  
                }
                else
                {
                    inputPokePower -= inputDistance;
                    targetsPoked++;

                }

            }
            Console.WriteLine(inputPokePower);
            Console.WriteLine(targetsPoked);
        }
    }
}
