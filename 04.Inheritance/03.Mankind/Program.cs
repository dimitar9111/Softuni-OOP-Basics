using System;

public class Program
{
    public static void Main()
    {
        var studentInput = Console.ReadLine().Split();
        var workerInput = Console.ReadLine().Split();

        try
        {
            var student = new Student(studentInput[0], studentInput[1], studentInput[2]);
            var worker = new Worker(workerInput[0], workerInput[1], decimal.Parse(workerInput[2]), int.Parse(workerInput[3]));

            Console.WriteLine(student);
            Console.WriteLine(worker);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
