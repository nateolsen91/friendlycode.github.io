using System;
using static System.Console;
class JobDemo
{
    static void Main()
    {
        //Job job1 = new Job(111, "Smith", "Exterior Paint", 20);
        //Job job2 = new Job(222, "Vega", "Gutter Clean", 4);
        //Job job3 = new Job(111, "Land", "Blacktop Drive", 10);
        //page 401, Step 2
        Job[] jobArray = new Job[3];
        //page 401, Step 3
        for (int x = 0; x < jobArray.Length; ++x)
        {
            GetData(out int jobId, out string customerName, out string typeWork, out double jobHours);
            jobArray[x] = new Job(jobId, customerName, typeWork, jobHours);

        }//end for

        //WriteLine(job1.ToString());
        //WriteLine(job2.ToString());
        //WriteLine(job3.ToString());
        for (int x = 0; x < jobArray.Length; ++x)
            WriteLine(jobArray[x].ToString());

    }//end Main
    //page 402, Step 5
    static void GetData(out int jobId, out string customerName, out string typeWork, out double jobHours)
    {
        string enterString;
        Write("Please enter job number: ");
        enterString = ReadLine();
        int.TryParse(enterString, out jobId);

        Write("Please enter customer's last name for job {0}: ", jobId);
        customerName = ReadLine();

        Write("Please enter type of work to be done: ");
        typeWork = ReadLine();

        Write("Please enter the hours needed to complete job {0}: ", jobId);
        enterString = ReadLine();
        double.TryParse(enterString, out jobHours);
        WriteLine();
    }
}//end program
class Job
{
    private double hours;
    private double price;
    public const double RATE = 45.00;
    public int JobNumber { get; set; }
    public string Customer { get; set; }
    public string Description { get; set; } 
    //Constructor
    public Job(int num, string cust, string desc, double hrs)
    {
        JobNumber = num;
        Customer = cust;
        Description = desc;
        Hours = hrs;
    }

    public double Hours
    {
        get
        {
            return hours;
        }
        set
        {
            hours = value;
            price = hours * RATE;
        }
    }
    public double Price
    {
        get
        {
            return price;
        }
    }
    public override string ToString()
    {
        return (GetType() + " " + JobNumber + " " + Customer + " " +
           Description + " " + Hours + " hours @" + RATE.ToString("C") +
           " per hour. Total price is " + Price.ToString("C") + "\n");
    }
}

