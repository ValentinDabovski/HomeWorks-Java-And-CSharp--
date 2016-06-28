
using System.Diagnostics;

public class Person
{
    private string firstName;
    private int age;

    public Person(string firstName,int age)
    {
        this.age = age;
        this.firstName = firstName;
    }
    

    public string FirstName => this.firstName;
    public int Age => this.age;
}

