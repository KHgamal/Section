using System;
namespace MyApplication;

public class Program
{
    public static void Main(string[] args)
    {
        var database=new Database();
        Console.Write("Enter your Name: ");
        var name =Console.ReadLine();
        Console.Write("Enter your Age: ");
        var age =Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your Year: ");
        var year =Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your GPA: ");
        var gpa =Convert.ToSingle(Console.ReadLine());
        var student = new  Student(name,age,year,gpa);
        database.AddStudent(student);
        student.print();
    }
}
public abstract class Person {
  public string Name;
  public int Age;
public Person(string name,int age){
    Name =name ;
    Age=age;
}
  
 public abstract void print ();
}
public class Student:Person{
    public int Year;
    public float Gpa;
    public Student (string name,int age,int year,float gpa ):base(name,age){
        Year=year;
        Gpa=gpa;
    }
    public override void print(){
        Console.WriteLine($"My name is {Name},my age is {Age},and gpa is {Gpa}");
    }
}
public class Database{
    public Person[] People=new Person[10];
    private int i=0;
    public void AddStudent(Student student){
        if(i<=10)
        People[i++]=student;
    }
    
}
