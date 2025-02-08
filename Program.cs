namespace Static_Class;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Number of Employees:  {0}",Employee.EmployeeAmount);
        Employee emp =new Employee("Serhat","Sakallı","CEO");
        Console.WriteLine("Number of Employees:  {0}",Employee.EmployeeAmount);
        Employee emp1 =new Employee("Serwdhat","Sakawwllı","CEO");
        Employee emp2 =new Employee("Serhwgat","Sakawwallı","CaEO");
        Employee emp3 =new Employee("Searhwjat","Sakawawllı","CaaEO");

        Console.WriteLine("Number of Employees:  {0}",Employee.EmployeeAmount);

        Console.WriteLine("Toplama işlemi sonucu: {0}{1}",Islemler.Topla(555,13),"oyyyy");
        Console.WriteLine("Çıkarma işlemi sonucu: {0}",Islemler.Cikar(555,13));
        
        Console.ReadLine(); 
    }
    
}
class Employee
{
    private static int employeeAmount;

    public static int EmployeeAmount { get => employeeAmount;}
    private string Name;
    private string Surname;
    private string Department;

    static Employee()
    {
        employeeAmount=0;
    }
    public Employee(string name, string surname, string department)
    {
        this.Name=name;
        this.Surname=surname;
        this.Department=department;
        employeeAmount ++;
    }
}
static class Islemler
{
    public static long Topla(int sayi1,int sayi2)
    {
        return sayi1+sayi2;
    }
    public static long Cikar(int sayi1,int sayi2)
    {
        return sayi1-sayi2;
    }
}
