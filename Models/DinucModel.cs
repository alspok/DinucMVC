using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinucMVC.Models
{
    public class DinucModel
    {
        public string Dinuc { get; set; }
        public int[] DinucCalc { get; set; } = { 0, 0 };
    }
}
