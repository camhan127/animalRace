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
    internal class Tortoise: RaceAnimal
    {
        // constructor that passes the animal name and symbol to the base constructor
        public Tortoise() : base("Tortoise", 'T') { }

        // overrides the Move method in RaceAnimal class, will update the position of the animal by calling 
        // ChangePos
        public override void Move()
        {
            // generate a random number between 1-10
            Random rand = new Random();
            int num = rand.Next(1, 11);

            // dash
            if (num < 6)
            {
                ChangePos(3);
            }
            // slip
            else if (num > 5 && num < 8)
            {
                ChangePos(-6);
            }
            // walk
            else
            {
                ChangePos(1);
            }
        }
    }
}
