using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Display
{
    private decimal size;
    private decimal? colors;

    public Display(decimal size, decimal? colors = null)
    {
        this.size = size;
        this.colors = colors;
    }

    public decimal Size
    {
        get
        {
            return this.size;
        }
    }

    public decimal? Colors { get; set; }
}
