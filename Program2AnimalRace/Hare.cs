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
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Program2AnimalRace
{
    internal class Hare: RaceAnimal
    {
        // constructor that passes the animal name and symbol to the base constructor
        public Hare() : base("Hare", 'H') { }

        // overrides the Move method in RaceAnimal class, will update the position of the animal by calling 
        // ChangePos
        public override void Move()
        {
            // generate a random number from 1-10
            Random rand = new Random();
            int num = rand.Next(1, 11);

            // sleep
            if (num < 3)
            {
                ChangePos(0);
            }
            // large hop
            else if (num > 2 && num < 5)
            {
                ChangePos(9);
            }
            // large slip
            else if (num > 4 && num < 6)
            {
                ChangePos(-12);
            }
            // small hop
            else if (num > 5 && num < 9)
            {
                ChangePos(1);
            }
            // small slip
            else
            {
                ChangePos(-2);
            }
        }
    }
}
