using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


static class GSMTest
{

    private static GSM[] testGSMs = new GSM[3];

    public static void TestPrint()
    {
        testGSMs[0] = new GSM("Desire S", "HTC", bat: new Battery("HTCBattery", hoursIdle: 100M), disp: new Display(4M));
        testGSMs[1] = new GSM("Desire S", "HTC", bat: new Battery("HTCBattery", hoursIdle: 100M), disp: new Display(4M));
        testGSMs[2] = GSM.IPhone4S;

        foreach (GSM gsm in testGSMs)
        {
            Console.WriteLine(gsm);
        }


        testGSMs[0].AddCall("8427153", 60);
        testGSMs[0].AddCall("8435153", 60);
        testGSMs[0].AddCall("8437153", 70);

        testGSMs[0].ViewCalls();
        Console.WriteLine("Total price = {0:C}", testGSMs[0].CalculatePrice(0.30M));

        testGSMs[0].RemoveCall("8437153");
        testGSMs[0].ViewCalls();
        Console.WriteLine("Total price = {0:C}", testGSMs[0].CalculatePrice(0.30M));

        testGSMs[0].ClearHistory();
        testGSMs[0].ViewCalls();
        Console.WriteLine("Total price = {0:C}", testGSMs[0].CalculatePrice(0.30M));


    }

}

