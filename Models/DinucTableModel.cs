using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinucMVC.Models
{
    public class DinucleotideTable
    {
        public string[] Dinuc { get; set; } = {"aa", "ac", "ag", "at",
                                               "ca", "cc", "cg", "ct",
                                               "ga", "gc", "gg", "gt",
                                               "ta", "tc", "tg", "tt"};
        public int[] DinucCountFirstFrame { get; set; } = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        public int[] DinucCountSecondFrame { get; set; } = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public double[] DinucFrqFirstFrame { get; set; } = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public double[] DinucFrqSecondFrame { get; set; } = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public double DinucFrqDiff { get; set; } = 0;
    }
}
