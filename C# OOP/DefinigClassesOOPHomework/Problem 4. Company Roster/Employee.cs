
public class Employee
{
  

    public Employee(string name, decimal salary,string position,string departament)
    {
        this.Name = name;
        this.Salary = salary;
        this.Position = position;
        this.Departament = departament;

    }

    public string Name { get; set; }
    public decimal Salary { get; set; }
    public string Position { get; set; }
    public string Departament { get; set; }
    public string Email { get; set; } = "n/a";
    public int Age { get; set; } = -1;
    
}



