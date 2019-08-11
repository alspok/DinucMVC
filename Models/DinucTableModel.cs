using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinucMVC.Models
{
    public class DinucTable
    {
        public string[] Dinuc { get; set; } = {"aa", "ac", "ag", "at",
                                               "ca", "cc", "cg", "ct",
                                               "ga", "gc", "gg", "gt",
                                               "ta", "tc", "tg", "tt"};
        public int[] DinucCount { get; set; } = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        public double[] DinucFrq { get; set; } = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    }
}
