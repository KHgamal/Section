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
        try
        {
            var student =new Student(name,age,year,gpa);
            database.AddStudent(student);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
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
         try
        {
            var staff =new Staff(name,age,salary,joinyear);
            database.AddStaff(staff);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        break;
                
        case 3:
        Console.Write("Enter your Name: ");
        name=Console.ReadLine();
        Console.Write("Enter your Age: ");
        age =Convert.ToInt32(Console.ReadLine());
        try
        {
            var person=new Person(name,age);
            database.AddPerson(person);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
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
  private string _name;
    private int _age;
public Person(string name,int age){
    if(name==null || name=="" || name.Length>=32)
        {
            throw new Exception("Invalid name");
        }
        if(age<0 || age>128)
        {
            throw new Exception("Invalid age");
        }
    _name =name ;
    _age=age;
}
public string GetName() => _name;
    public int GetAge()=>_age;
    public void SetName(string name){
        if(name==null || name=="" || name.Length>=32)
        {
            throw new Exception("Invalid name");
        }
        _name=name;
    }
    public void SetAge(int age){
        if(age<=0||age>128)
        {
            throw new Exception("Invalid age");
        }
        _age=age;
    }
   //.net  method must be marked as explicitly virtual or abstract to override it.
 public virtual void print (){
   Console.WriteLine($"My name is {GetName()} and my age is {GetAge()}"); 
 }
}
public class Student:Person{
   private int _year;
    private float _gpa;
    public Student (string name,int age,int year,float gpa ):base(name,age){
        if(year<1||year>5){
            throw new Exception("Invalid year");
        }
        if(gpa<0||gpa>4){
            throw new Exception("Invalid gpa");
        }
        _year=year;
        _gpa=gpa;
    }
    public int GetYear() => _year;
    public float GetGpa()=>_gpa;
    public void SetYear(int year){
        if(year<1||year>5){
            throw new Exception("Invalid year");
        }
        _year=year;
    }
    public void SetGpa(float gpa){
        if(gpa<0||gpa>4){
            throw new Exception("Invalid gpa");
        }
        _gpa=gpa;
    }
   
    public override void print() => Console.WriteLine($"My name is {GetName()},my age is {GetAge()},and gpa is {GetGpa()}");
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
    private double _salary;
    private int _joinYear;
    
    public Staff (string name,int age,double salary ,int joinyear):base(name,age){
    if(salary<0 || salary>120000){
            throw new Exception("Invalid salary");
        }
        
        if(joinyear-age<21){
            throw new Exception("Invalid join year");
        }
    _salary=salary;
    _joinYear=joinyear;
    }
    public double GetSalary() => _salary;
    public int GetJoinYear()=>_joinYear;
    public void SetSalary(double salary){
        if(salary<0 || salary>120000){
            throw new Exception("Invalid salary");
        }
        _salary=salary;
    }
    public void SetJoinYear(int joinyear){
        if(GetJoinYear()-GetAge()<=21){
            throw new Exception("Invalid join year");
        }
        _joinYear=joinyear;
    }
    public override void print() => Console.WriteLine($"My name is {GetName()}, my age is {GetAge()}, and my salary is {GetSalary()}");

}
