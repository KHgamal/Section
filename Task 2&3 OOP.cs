using System;
namespace MyApplication;

public class Program
{
    public static void Main(string[] args)
    {
       
    var database=new Database();
    
    while (true)
    {
        Console.WriteLine("choose a number 1)student 2)staff  3)person 4)print all people 5)exit program");
       var num=Convert.ToInt32(Console.ReadLine());
        switch (num)
    {
        case 1:
        Console.Write("Enter your Name: ");
        var name=Console.ReadLine();
        Console.Write("Enter your Age: ");
        var age =Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your Year: ");
        var year =Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your Gpa: ");
        var gpa = Convert.ToSingle(Console.ReadLine());
        var student =new Student(name,age,year,gpa);
        database.AddStudent(student);
        break;
                
        case 2:
        Console.Write("Enter your Name: ");
        name=Console.ReadLine();
        Console.Write("Enter your Age: ");
        age =Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your Salary: ");
        var salary = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter your JoinYear: ");
        var joinyear = Convert.ToInt32(Console.ReadLine());
        var staff =new Staff(name,age,salary,joinyear);
        database.AddStaff(staff);
        break;
                
        case 3:
        Console.Write("Enter your Name: ");
        name=Console.ReadLine();
        Console.Write("Enter your Age: ");
        age =Convert.ToInt32(Console.ReadLine());
        var person =new Person(name,age);
        database.AddPerson(person);
        break;
         case 4:
            database.PrintAll();
        break;
        
        default:
        return;
    }
    }
    }
}
public  class Person {
  public string Name;
  public int Age;
public Person(string name,int age){
    Name =name ;
    Age=age;
}
   //.net  method must be marked as explicitly virtual or abstract to override it.
 public virtual void print (){
   Console.WriteLine($"My name is {Name} and my age is {Age}"); 
 }
}
public class Student:Person{
    public int Year;
    public float Gpa;
    public Student (string name,int age,int year,float gpa ):base(name,age){
        Year=year;
        Gpa=gpa;
    }
   
    public override void print() => Console.WriteLine($"My name is {Name},my age is {Age},and gpa is {Gpa}");
}
public class Database{
    //array of objects
    public Person[] People=new Person[10];
    private int i=0;
    public void AddStudent(Student student){
        if(i<10)
        People[i++]=student;
        else
         System.Environment.Exit(0); 
    }
    public void AddStaff(Staff staff){
        if(i<10)
        People[i++]=staff;
        else
         System.Environment.Exit(0); 
    }
    public void AddPerson(Person person){
        if(i<10)
        People[i++]=person;
        else
         System.Environment.Exit(0); 
    }
    public void PrintAll(){
        for(int j=0;j<i;j++){
        // can access print method beacuse People[i] means either Staff or Student object which has print method
        People[j].print();
        }
    }
    
}
public class Staff :Person{
    public double Salary;
    public int JoinYear;
    
    public Staff (string name,int age,double salary ,int joinyear):base(name,age){
    Salary=salary;
    JoinYear=joinyear;
    }
    public override void print() => Console.WriteLine($"My name is {Name}, my age is {Age}, and my salary is {Salary}");

}
