using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

enum BatteryType { LiIon, NiMH, NiCd }

class Battery
{
    private string model;
    //private decimal? hoursIdle;
    //private decimal? hoursTalk;

    private BatteryType type;

    public Battery(string model, decimal? hoursIdle = null, decimal? hoursTalk = null, BatteryType type = BatteryType.LiIon)
    {
        this.model = model;
        this.HoursIdle = hoursIdle;
        this.HoursTalk = hoursTalk;
        this.type = type;
    }

    public string Model
    {
        get
        {
            return this.model;
        }
    }

    public decimal? HoursIdle { get; set; }
    public decimal? HoursTalk { get; set; }

    public BatteryType Type { get; set; }
}

