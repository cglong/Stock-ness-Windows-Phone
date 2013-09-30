﻿using System.Collections.Generic;

namespace Stockness.Model
{
    public class Portfolio
    {
        public IList<Position> Positions { get; set; }
        public double StartingBalance { get; set; }
        public double Gain { get; set; }
        public double Loss { get; set; }
        public double TotalValue { get; set; }
    }
}
