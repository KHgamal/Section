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
public class Student :Person{
    public int Year;
    public float Gpa;
    public Student (string name,int age,int year,float gpa ):base(name,age){
        Year=year;
        Gpa=gpa;
    }
    public override void Print(){
        Console.WriteLine($"My name is{Name},my age is{Age},and gpa is {Gpa}");
    }
}
