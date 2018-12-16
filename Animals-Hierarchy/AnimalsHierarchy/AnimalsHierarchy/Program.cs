using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace AnimalsHierarchy
{
    class Program
    {
        //Calculate the average age for all animals.

        public static double AverageAge(List<Animal> list)
        {
            double avg = 0;
            int counter = 0;
            foreach(Animal animal in list)
            {
                avg = avg + animal.Age;
                counter++;
            }
            return avg / counter;
        }
        public static double AverageAgeDogs(List<Animal> list)
        {
            double avg = 0;
            int counter = 0;
            foreach (Animal animal in list)
            {
                if (animal.getSound() == "Woof!")
                {
                    avg = avg + animal.Age;
                    counter++;
                }
            }
            return avg / counter;
        }
        public static double AverageAgeCats(List<Animal> list)
        {
            double avg = 0;
            int counter = 0;
            foreach (Animal animal in list)
            {
                if (animal.getSound() == "Meow!") ;
                {
                    avg = avg + animal.Age;
                    counter++;
                }
            }
            return avg / counter;
        }
        public static double AverageAgeFrogs(List<Animal> list)
        {
            double avg = 0;
            int counter = 0;
            foreach (Animal animal in list)
            {
                if (animal.getSound() == "Ribbit!")
                {
                    avg = avg + animal.Age;
                    counter++;
                }
            }
            return avg / counter;
        }

        static void Main(string[] args)
        {
            List<Animal> Animals = new List<Animal>();

            List<Dog> Dogs = new List<Dog>();
            List<Cat> Cats = new List<Cat>();
            List<Frog> Frogs = new List<Frog>();

            Dog dog1 = new Dog("Sparky",2,"male"); Animals.Add(dog1);
            Dog dog2 = new Dog("Hugo", 3, "male"); Animals.Add(dog2);
            Dog dog3 = new Dog("Luna", 4, "female"); Animals.Add(dog3);

            Cat cat1 = new Cat("Calypso", 1, "female"); Animals.Add(cat1);
            Kitten cat2 = new Kitten("Maya", 2); Animals.Add(cat2);
            Tomcat cat3 = new Tomcat("Thomas", 3); Animals.Add(cat3);

            Frog frog1 = new Frog("Kenen", 5, "male"); Animals.Add(frog1);
            Frog frog2 = new Frog("Giraya", 4, "male"); Animals.Add(frog2);

            
            foreach(Animal animal in Animals)
            {
                Console.WriteLine($"Name: {animal.Name}; Age: {animal.Age}; Gender: {animal.Gender}; Sound: {animal.getSound()}");
            }

            Console.WriteLine();

            
            Console.WriteLine($"The average age for animals is: {AverageAge(Animals)}");
            Console.WriteLine($"The average age for dogs is: {AverageAgeDogs(Animals)}");
            Console.WriteLine($"The average age for cats is: {AverageAgeCats(Animals)}");
            Console.WriteLine($"The average age for frogs is: {AverageAgeFrogs(Animals)}");

            Console.ReadKey();
        }
    }
}
