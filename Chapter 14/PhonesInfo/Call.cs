using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Call
{
    DateTime timeOfCall;
    string dialedNumber;
    int duration;

    public Call(string dialedNumber, int duration)
    {
        this.timeOfCall = DateTime.Now;
        this.dialedNumber = dialedNumber;
        this.duration = duration;
    }

    public DateTime TimeOfCall
    {
        get
        {
            return this.timeOfCall;
        }
    }

    public string DialedNumber
    {
        get
        {
            return this.dialedNumber;
        }
    }

    public int Duration
    {
        get
        {
            return this.duration;
        }
    }

}
