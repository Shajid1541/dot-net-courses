using System;
using System.Collections.Generic;

namespace DelegateApp
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        // Our delegate
        public delegate bool FilterDelegate(Person p);

        static void Main(string[] args)
        {
            // Create 4 Person objects
            Person p1 = new Person() { Name = "John", Age = 41 };
            Person p2 = new Person() { Name = "Jane", Age = 69 };
            Person p3 = new Person() { Name = "Jake", Age = 12 };
            Person p4 = new Person() { Name = "Jessie", Age = 25 };

            // Create a list of Person objects and fill it
            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            // Invoke DisplayPeople using appropriate delegate
            DisplayPeople("Children:", people, IsChild);
            DisplayPeople("Adults:", people, IsAdult);
            DisplayPeople("Seniors:", people, IsSenior);

            Console.Read();
        }

        // A method to filter out the people you need
        static void DisplayPeople(string category, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(category);
            foreach (var person in people)
            {
                if (filter(person))
                {
                    Console.WriteLine($"- {person.Name}");
                }
            }
        }

        static bool IsChild(Person p) => p.Age < 18;
        static bool IsAdult(Person p) => p.Age >= 18 && p.Age < 65;
        static bool IsSenior(Person p) => p.Age >= 65;
    }
}
