using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalInfo
{
    public class Dog:IAnimal
    {
        public string Name { get; set; }
        public string Habitat { get; set; }
        public string EatingHabit { get; set; }

        public Dog(string name,string habitat,string eatingHabit)
        {
            Name=name;
            Habitat=habitat;
            EatingHabit=eatingHabit;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("      Dog Info   ");
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Name: {Name}\nHabitat: {Habitat}\nEating Habit:{EatingHabit}");
        }
    }
}