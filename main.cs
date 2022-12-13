using System;
namespace Hello;

public class Hello
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Hello Mono World");
    }
}
public abstract class Person {
  public string name;
  public int age;
public Person (string name,int age){
    name =name ;
    age=age;
}
  
 public abstract void print ();
}
