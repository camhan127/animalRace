/*
 * Program Author: Camron Hansen
 * USM NetID: w10054393
 * Assignment: Program 2: The Tortoise and the Hare
 * 
 * Description: In this program, the classic race of the tortoise and the hare is simulated.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2AnimalRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create the race object
            Race race = new Race();

            // simulate the race
            race.Simulate();

            // pause to prevent automatic exit
            Console.ReadKey();
        }
    }
}
