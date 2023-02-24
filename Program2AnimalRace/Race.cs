/*
 * Program Author: Camron Hansen
 * USM NetID: w10054393
 * Assignment: Program 2: The Tortoise and the Hare
 * 
 * Description: In this program, the classic race of the tortoise and the hare is simulated.
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Program2AnimalRace
{
    internal class Race
    {
        // private attributes
        private RaceAnimal animal1;
        private RaceAnimal animal2;
        private RaceAnimal winner;
        private bool over;

        // public methods
        // constructor
        public Race()
        {
            animal1 = new Hare();
            animal2 = new Tortoise();
            winner = null;
            over = false;
        }

        // checks the status of the race
        public void UpdateStatus()
        {
            if (animal1.position == 69 && animal2.position == 69)
            {
                over = true;
                winner = null;
            }
            else if(animal1.position == 69 && animal2.position != 69)
            {
                over = true;
                winner = animal1;
            }
            else if (animal1.position != 69 && animal2.position == 69)
            {
                over = true;
                winner = animal2;
            }
        }

        // simulates the race
        public void Simulate()
        {
            // while loop to simulate the race, calling each animal's move method until one the animals reaches
            // the end of the track
            while (over == false)
            {
                Console.Clear();
                UpdateStatus();
                Console.WriteLine(animal1.ToString());
                Console.WriteLine(animal2.ToString());
                animal1.Move();
                animal2.Move();
                Thread.Sleep(1000);
            }

            // print out the results of the race
            Console.WriteLine("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*");
            if (winner == animal1)
            {
                Console.WriteLine("The Hare Won the Race!");
            }
            else if(winner == animal2)
            {
                Console.WriteLine("The Tortoise Won the Race!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
            Console.WriteLine("*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*~~*");
        }
    }
}
