using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



class GSM
{
    private Battery battery;
    private Display display;
    private string model;
    private string manufacture;
    private decimal? price;
    private string owner;
    static private GSM iPhone4S;

    List<Call> calls;

    public GSM(string model, string manufacture, decimal? price = null, string owner = null, Battery bat = null, Display disp = null)
    {
        this.model = model;
        this.manufacture = manufacture;
        this.price = price;
        this.owner = owner;
        this.battery = bat;
        this.display = disp;
        this.calls = new List<Call>();
    }

    static GSM()
    {
        iPhone4S = new GSM("IPhone4S", "Apple", 1000M, "Me :D", new Battery("AppleBat", 100M, 24M), new Display(5M));
    }

    static public GSM IPhone4S
    {
        get
        {
            return iPhone4S;
        }
    }



    //public GSM(string model, string manufacture, decimal priceAdd)
    //{
    //    this.model = model;
    //    this.manufacture = manufacture;
    //    this.price = priceAdd;
    //    this.owner = null;
    //}

    //public GSM(string model, string manufacture, string owner)
    //{
    //    this.model = model;
    //    this.manufacture = manufacture;
    //    this.price = null;
    //    this.owner = owner;
    //}

    //public GSM(string model, string manufacture, decimal price, string owner)
    //{
    //    this.model = model;
    //    this.manufacture = manufacture;
    //    this.price = price;
    //    this.owner = owner;
    //}

    public void ViewCalls()
    {
        if (calls.Count > 0)
        {
            Console.WriteLine("---------------- Calls List ------------------");
            Console.WriteLine("{0,-10}{1,-13} | {2,-8} | {3}", "Date", "Time", "Number", "Duration");
            foreach (var call in this.calls)
            {
                Console.WriteLine("{0,-23} | {1,-8} | {2}", call.TimeOfCall, call.DialedNumber, call.Duration);
            }
            Console.WriteLine("----------------------------------------------");
        }
        else
        {
            Console.WriteLine("\nNo calls\n");
        }
    }

    public void AddCall(string dailedNum, int dur)
    {
        Call someCall = new Call(dailedNum, dur);
        this.calls.Add(someCall);
    }

    public void RemoveCall(DateTime callToDel)
    {
        int removedCalls;

        if (this.calls.Count > 0)
        {
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No calls in history");
        }

        removedCalls = this.calls.RemoveAll(
            delegate(Call c)
            {
                return c.TimeOfCall == callToDel;
            }
        );

        if (removedCalls > 0)
        {
            Console.WriteLine("{0} calls removed", removedCalls);
        }
        else
        {
            Console.WriteLine("Call not found");
        }

    }

    public void RemoveCall(string numToDell)
    {
        int removedCalls;

        if (this.calls.Count > 0)
        {
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No calls in history");
        }

        removedCalls = this.calls.RemoveAll(
            delegate(Call c)
            {
                return c.DialedNumber == numToDell;
            }
        );

        if (removedCalls > 0)
        {
            Console.WriteLine("{0} calls removed\n", removedCalls);
        }
        else
        {
            Console.WriteLine("Call not found");
        }

    }

    public void ClearHistory()
    {
        this.calls.Clear();

        Console.WriteLine("\nAll calls cleared\n");
    }

    public decimal CalculatePrice(decimal priceSec)
    {
        int totalSecondCalls = 0;

        foreach (var item in calls)
        {
            totalSecondCalls += item.Duration;
        }

        return (totalSecondCalls / 60) * priceSec;
    }

    public override string ToString()
    {

        StringBuilder printInfo = new StringBuilder();
        printInfo.Append("--------------------------\n");
        printInfo.Append(String.Format("{0, -13} - {1}\n", "Manufacture", this.manufacture));
        printInfo.Append(String.Format("{0, -13} - {1}\n", "Model", this.model));
        printInfo.Append(this.price == null ? String.Format("{0, -13} - unknown\n", "Price") : String.Format("{0, -13} - {1}\n", "Price", this.price));
        printInfo.Append(this.owner == null ? String.Format("{0, -13} - unknown\n", "Owner") : String.Format("{0, -13} - {1}\n", "Owner", this.owner));

        if (this.battery != null)
        {
            printInfo.Append("\nBattery\n");
            printInfo.Append(String.Format("{0,2}{1,-10} - {2}\n", "-", "Model", this.battery.Model));
            printInfo.Append(this.battery.HoursIdle == null ? String.Format("{0,2}{1,-10} - {2}\n", "-", "HoursIdle", "unknown") : String.Format("{0,2}{1,-10} - {2}\n", "-", "HoursIdle", this.battery.HoursIdle));
            printInfo.Append(this.battery.HoursTalk == null ? String.Format("{0,2}{1,-10} - {2}\n", "-", "HoursTalk", "unknown") : String.Format("{0,2}{1,-10} - {2}\n", "-", "HoursTalk", this.battery.HoursTalk));
            printInfo.Append(this.battery.Type == null ? String.Format("{0,2}{1,-10} - {2}\n", "-", "Type", "unknown") : String.Format("{0,2}{1,-10} - {2}\n", "-", "Type", this.battery.Type));
        }
        else
        {
            printInfo.Append(String.Format("{0, -13} - {1}\n", "Battery", "unknown"));
        }

        if (this.display != null)
        {
            printInfo.Append("\nDisplay\n");
            printInfo.Append(String.Format("{0,2}{1,-10} - {2}\"\n", "-", "Size", this.display.Size));
            printInfo.Append(this.display.Colors == null ? String.Format("{0,2}{1,-10} - {2}\n", "-", "Colors", "unknown") : String.Format("{0,2}{1,-10} - {2}\n", "-", "Colors", this.display.Colors));
        }
        else
        {
            printInfo.Append(String.Format("{0, -13} - {1}\n", "Display", "unknown"));
        }
        printInfo.Append("--------------------------\n");
        return printInfo.ToString();
    }
}
