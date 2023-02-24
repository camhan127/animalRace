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
    internal abstract class RaceAnimal
    {
        // private attributes
        private char[] track = new char[70];
        private char symbol;
        public int position;
        private string name;

        // public & protected methods
        // constructor
        public RaceAnimal(string name, char symbol)
        {
            this.name = name;
            this.symbol = symbol;
            for (int i = 0; i < track.Length; i++)
            {
                track[i] = '-';
                track[0] = symbol;
            }
        }

        // overrides the ToString method to output the animals' track in the race
        public override string ToString()
        {
            string trackString = "";
            for(int i = 0; i < track.Length; i++)
            {
                trackString += track[i];
            }
            return trackString;
        }

        // takes in the number of steps and applies it to the race track
        protected void ChangePos(int steps)
        {
            track[position] = '-';
            if (position + steps < 0)
            {
                position = 0;
                track[position] = symbol;
            }
            else if (position + steps > 69)
            {
                position = 69;
                track[position] = symbol;
            }
            else
            {
                position += steps;
                track[position] = symbol;
            }
        }

        // abstract method to move the animals along the track when called
        public abstract void Move();
    }
}
