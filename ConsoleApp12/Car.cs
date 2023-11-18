using System;

namespace Hometask1 
{ 
    public class Person
    {
        private int birthYear;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int BirthYear
        {
            get { return birthYear; }
            set { birthYear = value; }
        }

        public static int Age(int birthYear)
        {
            return 2023 - birthYear;
        }

        public static bool operator == (Person a, Person b)
        {
            return (a.name == b.name);
        }

        public static bool operator != (Person a, Person b)
        {
            return !(a == b);
        }
            

        public void Input()
        {
            this.Name = Console.ReadLine();
            this.BirthYear = int.Parse(Console.ReadLine());
        }

        public Person()
        {
            Input();
        }

        public static void Output(Person[] people)
        {
            for(int i = 0; i < 6; i++) 
            {
                Console.WriteLine($"{people[i].name} is {Age(people[i].birthYear)} years old.");
            }

            Console.WriteLine("\nInformation about all persons:\r");

            for (int j = 0; j < people.Length; j++)
            {
                if (Age(people[j].birthYear) < 16)
                {
                    people[j].name = "Very Young";
                    Console.WriteLine($"Name: {people[j].name}, Year of Birth: {people[j].birthYear}");
                }
                else
                {
                    Console.WriteLine($"Name: {people[j].name}, Year of Birth: {people[j].birthYear}");
                }
            }

            Console.WriteLine("\nPersons with the same names:\r");

            for (int k = 0; k < people.Length; k++)
            {
                for (int l = k + 1; l < people.Length; l++)
                {
                    if (people[k] == people[l])
                    {
                        Console.WriteLine($"Name: {people[k].name}, Year of Birth: {people[k].birthYear}");
                        Console.WriteLine($"Name: {people[l].name}, Year of Birth: {people[l].birthYear}");
                    }
                    else
                    {
                        continue;
                    }
                }   
            }
        }
    }
}
