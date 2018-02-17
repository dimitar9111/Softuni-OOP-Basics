using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var departmentInfo = new Dictionary<string, List<Employee>>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            var department = input[3];
            Employee employee;
            if (input.Length == 4)
            {
                employee = new Employee(input[0], decimal.Parse(input[1]), input[2], input[3]);
            }
            else if (input.Length == 5)
            {
                if (int.TryParse(input[4], out int result))
                {
                    employee = new Employee(input[0], decimal.Parse(input[1]), input[2], input[3], result);
                }
                else
                {
                    employee = new Employee(input[0], decimal.Parse(input[1]), input[2], input[3], input[4]);
                }
            }
            else
            {
                employee = new Employee(input[0], decimal.Parse(input[1]), input[2], input[3], input[4], int.Parse(input[5]));

            }

            if (!departmentInfo.ContainsKey(department))
            {
                departmentInfo[department] = new List<Employee>();
            }
            departmentInfo[department].Add(employee);
        }

        var highestSalaryDepartment = departmentInfo
            .OrderByDescending(d => d.Value.Sum(e => e.Salary) / d.Value.Count)
            .Take(1)
            .ToDictionary(x => x.Key, y => y.Value);

        Console.WriteLine($"Highest Average Salary: {highestSalaryDepartment.First().Key}");
        foreach (var employee in highestSalaryDepartment
            .First()
            .Value
            .OrderByDescending(e => e.Salary))
        {
            Console.WriteLine(employee);
        }
    }
}
