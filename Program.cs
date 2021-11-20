using System;
using System.Collections.Generic;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person("Jan", "Kowalski", 1981);
            Employee employee = new Employee("Adam", "Nowak", 2000, 5000);
            Person person2 = new Employee("Ann", "Kowalska", 1982, 6000);
            List<Person> people = new List<Person>();
            people.Add(person);
            people.Add(employee);
            people.Add(person2);

            foreach (Person p in people) 
            {
                if (p.GetType() == typeof(Person))
                {
                    p.WhoAmI();
                    Console.WriteLine("Is Person");
                }
                else if (p.GetType() == typeof(Employee))
                {
                    p.WhoAmI();
                    Console.WriteLine("Is Employee");
                    Employee e = (Employee)p;
                    Console.WriteLine($"Salary = {e.Salary}");
                }
                else 
                {
                    Console.WriteLine("No Idea?");
                }
                
            }
         
         

           

      








            /*            Person person = new Person();
                        person.WhoAmI();
                        person.FirstName = "Jan";
                        person.LastName = "Kowalski";
                        person.YearOfBirth = 1981;
                        Console.WriteLine(person.IsAdult());*/
           
     /*       Employee employee = new Employee();
            employee.FirstName = "Jan";
            employee.LastName = "Kowalski";
            employee.YearOfBirth = 1981;
            employee.Salary = 5000;
            employee.WhoAmI();
            Employee employee2 = new Employee("Adam", "Nowak", 1980, 2000);
            employee2.WhoAmI();*/

      /*      Person person = new Person(firstName: "Adam", lastName: "Nowak");
            person.WhoAmI();
            Console.WriteLine(person.YearOfBirth);*/






            /*        Person person = new Person()
            {
                FirstName = "Jan",
                LastName = "Kowalski",
                YearOfBirth = 1981
            };

            person.WhoAmI();
            Console.WriteLine(person.IsAdult());*/


        }
    }
}
