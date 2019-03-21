using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;


namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>()
            {
                new Person("Nathanael", "Holt", 20, Job.Choreographer),
                new Person("Jabari", "Chapman", 35, Job.Dentist),
                new Person("Oswaldo", "Wilson", 19, Job.Developer),
                new Person("Kody", "Walton", 43, Job.Sculptor),
                new Person("Andreas", "Weeks", 17, Job.Developer),
                new Person("Kayla", "Douglas", 28, Job.Developer),
                new Person("Xander", "Campbell", 19, Job.Waiter),
                new Person("Soren", "Velasquez", 33, Job.Interpreter),
                new Person("August", "Rubio", 21, Job.Developer),
                new Person("Malakai", "Mcgee", 57, Job.Barber),
                new Person("Emerson", "Rollins", 42, Job.Choreographer),
                new Person("Everett", "Parks", 39, Job.Sculptor),
                new Person("Amelia", "Moody", 24, Job.Waiter),
                new Person("Emilie", "Horn", 16, Job.Waiter),
                new Person("Leroy", "Baker", 44, Job.Interpreter),
                new Person("Nathen", "Higgins", 60, Job.Archivist),
                new Person("Erin", "Rocha", 37, Job.Developer),
                new Person("Freddy", "Gordon", 26, Job.Sculptor),
                new Person("Valeria", "Reynolds", 26, Job.Dentist),
                new Person("Cristofer", "Stanley", 28, Job.Dentist)
            };

            var dogs = new List<Dog>()
            {
                new Dog("Charlie", "Black", 3, Race.Collie),
                new Dog("Buddy", "Brown", 1, Race.Doberman),
                new Dog("Max", "Olive", 1, Race.Plott),
                new Dog("Archie", "Black", 2, Race.Mutt),
                new Dog("Oscar", "White", 1, Race.Mudi),
                new Dog("Toby", "Maroon", 3, Race.Bulldog),
                new Dog("Ollie", "Silver", 4, Race.Dalmatian),
                new Dog("Bailey", "White", 4, Race.Pointer),
                new Dog("Frankie", "Gray", 2, Race.Pug),
                new Dog("Jack", "Black", 5, Race.Dalmatian),
                new Dog("Chanel", "Black", 1, Race.Pug),
                new Dog("Henry", "White", 7, Race.Plott),
                new Dog("Bo", "Maroon", 1, Race.Boxer),
                new Dog("Scout", "Olive", 2, Race.Boxer),
                new Dog("Ellie", "Brown", 6, Race.Doberman),
                new Dog("Hank", "Silver", 2, Race.Collie),
                new Dog("Shadow", "Silver", 3, Race.Mudi),
                new Dog("Diesel", "Brown", 1, Race.Bulldog),
                new Dog("Abby", "Black", 1, Race.Dalmatian),
                new Dog("Trixie", "White", 8, Race.Pointer),
            };

            //==============================
            // TODO Homework requirements
            //==============================

            //PART 1
            // 1. Structure the solution (create class library and move classes and enums accordingly)

            //PART 2
            // 1. Take person Cristofer and add Jack, Ellie and Hank as his dogs.
            // 2. Take person Freddy and add Oscar, Toby, Chanel, Bo and Scout as his dogs.
            // 3. Add Trixie, Archie and Max as dogs from Erin
            // 4. Give Abby and Shadow to Amelia

            //PART 3 - LINQ
            // 1. Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER
            // 2. Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER
            // 3. Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER
            // 4. Find and print all Freddy`s dogs names older than 1 year
            // 5. Find and print Nathen`s first dog
            // 6. Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER

            //PART 4 - Be Creative, PLAY with LINQ :) 

            Console.WriteLine("PART 1");
            Console.WriteLine("DONE :) ");
            Console.WriteLine("\n");

            Console.WriteLine("PART 2");

            Console.WriteLine("1.Take person Cristofer and add Jack, Ellie and Hank as his dogs:");

            var filterCristofer = people.Where(p => p.FirstName == "Cristofer").FirstOrDefault();            
            var jackDog = dogs.Where(d => d.Name == "Jack").FirstOrDefault();
            var ellieDog = dogs.Where(d => d.Name == "Ellie").FirstOrDefault();
            var hankDog = dogs.Where(d => d.Name == "Hank").FirstOrDefault();

            filterCristofer.Dogs = new List<Dog>();

            filterCristofer.Dogs.Add(jackDog);
            filterCristofer.Dogs.Add(ellieDog);
            filterCristofer.Dogs.Add(hankDog);

            foreach (var dog in filterCristofer.Dogs)
            {
                Console.WriteLine($"- {dog.Name} \n");
            }
      
            Console.WriteLine("2.Take person Freddy and add Oscar, Toby, Chanel, Bo and Scout as his dogs:");

            var filterFreddy = people.Where(p => p.FirstName == "Freddy").FirstOrDefault();

            filterFreddy.Dogs = new List<Dog>();

            var dogOscar = dogs.Where(d => d.Name == "Oscar").FirstOrDefault();
            var dogToby = dogs.Where(d => d.Name == "Toby").FirstOrDefault();
            var dogChanel = dogs.Where(d => d.Name == "Chanel").FirstOrDefault();
            var dogBo = dogs.Where(d => d.Name == "Bo").FirstOrDefault();
            var dogScout = dogs.Where(d => d.Name == "Scout").FirstOrDefault();

            filterFreddy.Dogs.Add(dogOscar);
            filterFreddy.Dogs.Add(dogToby);
            filterFreddy.Dogs.Add(dogChanel);
            filterFreddy.Dogs.Add(dogBo);
            filterFreddy.Dogs.Add(dogScout);

            foreach (var dog in filterFreddy.Dogs)
            {
                Console.WriteLine($"- {dog.Name} \n");
            }

            Console.WriteLine("3.Add Trixie, Archie and Max as dogs from Erin:");

            var filterErin = people.Where(p => p.FirstName == "Erin").FirstOrDefault();
            var dogTrixie = dogs.Where(d => d.Name == "Trixie").FirstOrDefault();
            var dogArchie = dogs.Where(d => d.Name == "Archie").FirstOrDefault();
            var dogMax = dogs.Where(d => d.Name == "Max").FirstOrDefault();

            filterErin.Dogs = new List<Dog>();

            filterErin.Dogs.Add(dogTrixie);
            filterErin.Dogs.Add(dogArchie);
            filterErin.Dogs.Add(dogMax);

            foreach (var dog in filterErin.Dogs)
            {
                Console.WriteLine($"- {dog.Name} \n");
            }
    
            Console.WriteLine("4.Give Abby and Shadow to Amelia:");

            var filterAmelia = people.Where(p => p.FirstName == "Amelia").FirstOrDefault();
            var dogAbby = dogs.Where(d => d.Name == "Abby").FirstOrDefault();
            var dogShadow = dogs.Where(d => d.Name == "Shadow").FirstOrDefault();

            filterAmelia.Dogs = new List<Dog>();

            filterAmelia.Dogs.Add(dogAbby);
            filterAmelia.Dogs.Add(dogShadow);

            foreach (var dog in filterAmelia.Dogs)
            {
                Console.WriteLine($"- {dog.Name} \n");
            }

            Console.WriteLine("\n");

            Console.WriteLine("PART 3");

            Console.WriteLine("1. All persons firstnames starting with 'R', ordered by Age-DESCENDING ORDER:");
            var filterNameStartingWithR = people.Where(p => p.FirstName.StartsWith("R")).OrderByDescending(p => p.Age).ToList();
            Console.WriteLine("NONE!");

            Console.WriteLine("2. All brown dogs names and ages older than 3 years, ordered by Age-ASCENDING ORDER:");

            var brownDogs = dogs.Where(d => d.Color == "Brown").Where(d => d.Age > 3).OrderBy(d => d.Age).Select(d => d.Name).ToList();

            foreach (var dog in brownDogs)
            {
                if(brownDogs.Count == 1)
                {
                    Console.WriteLine($"There is only one brown dog older than 3 years: {dog}!");
                }
                else
                {
                    Console.WriteLine($"- {dog} \n");
                }             
            }

            Console.WriteLine("3. All persons with more than 2 dogs, ordered by Name-DESCENDING ORDER:");

            var personsWithMoreThan2Dogs = people.Where(p => p.Dogs.Count > 2).OrderByDescending(p => p.FirstName).ToList();
            foreach (var person in personsWithMoreThan2Dogs)
            {
                Console.WriteLine($"- {person.FirstName} \n");

            }

            Console.WriteLine("4. All Freddy`s dogs names older than 1 year:");

            var freddyDogs = filterFreddy.Dogs.Where(d => d.Age > 1).ToList();

            foreach (var dog in freddyDogs)
            {
                Console.WriteLine($"- {dog.Name} \n");
            }
            Console.WriteLine("5. Find and print Nathen`s first dog:");

            Console.WriteLine("NONE!");


            Console.WriteLine("6.All white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER:");

            var whiteDogs = new List<Dog>();

            whiteDogs.Add(jackDog);
            whiteDogs.Add(ellieDog);
            whiteDogs.Add(hankDog);
            whiteDogs.Add(dogOscar);
            whiteDogs.Add(dogToby);
            whiteDogs.Add(dogChanel);
            whiteDogs.Add(dogBo);
            whiteDogs.Add(dogScout);
            whiteDogs.Add(dogTrixie);
            whiteDogs.Add(dogArchie);
            whiteDogs.Add(dogMax);
            whiteDogs.Add(dogAbby);
            whiteDogs.Add(dogShadow);
          
            var orderedByName = whiteDogs.Where(d => d.Color == "White").OrderBy(d => d.Name);
            foreach (var dog in orderedByName)
            {
                Console.WriteLine($"{dog.Name}");
            }

            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine();
















        }
    }
}
