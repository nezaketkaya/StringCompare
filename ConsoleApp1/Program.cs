using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

                int[] alice = new int[3];
                int[] bob = new int[3];
                int alc = 0;
                int boby = 0;

                for (int i = 0; i < alice.Length; i++)
                {
                    Console.WriteLine("Alice için sayı gir: ");
                    int dgr1 = Convert.ToInt32(Console.ReadLine());
                    alice[i] = dgr1;
                }

                for (int j = 0; j < bob.Length; j++)
                {
                    Console.WriteLine("Bob için sayı gir: ");
                    int dgr2 = Convert.ToInt32(Console.ReadLine());
                    bob[j] = dgr2;
                }

                for (int i = 0; i < alice.Length; i++)
                {
                    Console.WriteLine("Alice: " + alice[i]);
                }
                for (int j = 0; j < bob.Length; j++)
                {
                    Console.WriteLine("Bob: " + bob[j]);
                }

                for (int i = 0; i < alice.Length; i++)
                {
                    if (alice[i] > bob[i])
                    {
                        alc++;
                    }
                    else if (alice[i] < bob[i])
                    {
                        boby++;
                    }
                   
                }

                Console.WriteLine("Alice: " + alc + " Bob: " + boby);
            }
        }

    }
