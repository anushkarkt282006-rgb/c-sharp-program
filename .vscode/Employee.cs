using System;

class Employee
{
    int empId;
    string empName;
    int salary;


    public Employee()
    {
        empId = 2428;
        empName = "Arsh Singh Verma";
        salary = 180000;
    }

    public Employee(int empId, string empName, int salary)
    {
        this.empId = empId;
        this.empName = empName;
        this.salary = salary;
    }

    public string calculatesalary()
    
    {
        if (salary >= 100000)
            return "High Salary";
        else if (salary >= 50000)
            return "Medium Salary";
        else
            return "Low Salary";
    }

    public void displaydetails()

    Console.WriteLine($"Employee ID: {empId}");
    Console.WriteLine($"Employee Name: {empName}");
    Console.WriteLine($"Employee Salary: {salary}");
    Console.WriteLine($"Salary Category: {calculatesalary()}");


