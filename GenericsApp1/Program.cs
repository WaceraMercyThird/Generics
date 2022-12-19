// See https://aka.ms/new-console-template for more information
using System;
using Console = System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;






namespace GenericApp1
{
  class Person<T, T1, B>
  {
    public T Age { get; set; }
    public T1 Name { get; set; }

    public B Area { get; set; }

    public void Message<B>()
    {
      Console.WriteLine(Age + " " + Name + " lives at "+ Area);
    }
  }
  

  class MyClass
  {
    public static void Main(string[] args)
    {
      Person<float, string, string> obj1 = new Person<float, string, string>();
      obj1.Age = 45;
      obj1.Name = "Jane Doe";
      obj1.Area = "Nairobi";
      obj1.Message<string>();



    }
    
  }
  



}
