using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4g_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                        * Пользователь вводит номер планеты Солнечной системы
                      - (счет от 1 до 8 по порядку начиная с Меркурия) . 

                      Необходимо вывести на экран его название.
                       */
            string Mercury = "Mercury";
            string Venus = "Venus";
            string Earth = "Earth";
            string Mars = "Mars";
            string Jupiter = "Jupiter";
            string Saturn = "Saturn";
            string Uranus = "Uranus";
            string Neptune = "Neptune";

            int numberPlanet = Convert.ToInt32(Console.ReadLine());

            if (numberPlanet == 1)
            {
                Console.WriteLine(Mercury);
            }
            else if (numberPlanet == 2)
            {
                Console.WriteLine();
            }
           }
      }
 }

