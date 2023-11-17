using System;

public enum Vacancies
{
    Manager,
    Clerk,
    ITSpecialist,
    Salesperson
}

public struct Employee
{
    public string Name;
    public Vacancies Vacancy;
    public int[] HireDate; // Год, месяц, день
    public int Salary;

    public override string ToString()
    {
        return $"Name: {Name}, Vacancy: {Vacancy}, Hire Date: {HireDate[0]}-{HireDate[1]}-{HireDate[2]}, Salary: {Salary}";
    }
}

class Program
{
    static void Main()
    {
        Employee employee1;
        employee1.Name = "John Doe";
        employee1.Vacancy = Vacancies.Manager;
        employee1.HireDate = new int[] { 2022, 11, 15 };
        employee1.Salary = 50000;

        Employee employee2;
        employee2.Name = "Jane Smith";
        employee2.Vacancy = Vacancies.Clerk;
        employee2.HireDate = new int[] { 2023, 3, 20 };
        employee2.Salary = 30000;

        // Вывод информации о сотрудниках
        Console.WriteLine("Employee 1:");
        Console.WriteLine(employee1);

        Console.WriteLine("\nEmployee 2:");
        Console.WriteLine(employee2);
    }
}
