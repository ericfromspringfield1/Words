using System;

namespace interfaces
{
public interface INameable 
{
    string Name {get; set;}
}

public interface IAge
{
     int Age { get; private set; }
}
   public void IncrementAge()
    {
        Age++;
    }
    public class Person : Mammal, INameable, IAge
    {
        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        } 
        public int Age {get; private set;}
    }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
