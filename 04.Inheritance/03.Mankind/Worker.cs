using System;
using System.Text;

public class Worker : Human
{
    private const int DaysPerWeek = 5;

    private decimal weekSalary;
    private int workHoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
        :base(firstName, lastName)
    {
        WeekSalary = weekSalary;
        WorkHoursPerDay = workHoursPerDay;
    }

    public decimal WeekSalary
    {
        get
        {
            return this.weekSalary;
        }
        private set
        {
            if (value <= 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            this.weekSalary = value;
        }
    }

    public int WorkHoursPerDay
    {
        get
        {
            return this.workHoursPerDay;
        }
        private set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            this.workHoursPerDay = value;
        }
    }

    private decimal SalaryPerHour()
    {
        return this.WeekSalary / (WorkHoursPerDay * DaysPerWeek);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Week Salary: {this.WeekSalary:f2}");
        sb.AppendLine($"Hours per day: {this.WorkHoursPerDay:f2}");
        sb.AppendLine($"Salary per hour: {this.SalaryPerHour():f2}");

        return base.ToString() + sb.ToString(); ;
    }
}
