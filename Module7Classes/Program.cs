namespace Module7classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new("Sushma", "Srini", "Sush@123.com", new DateTime(1994, 03, 15), 25);
            e.DisplayEmployeeDetails();
            e.PerformWork(2);
            e.PerformWork(8);
            

            double receiveWage=e.ReceiveWage(true);
            Console.WriteLine($"Wage paid (message from program): {receiveWage}");
        }
    }
}