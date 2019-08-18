using DinucMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinucMVC.Calculation
{
    public class DinucCalculation
    {
        public DinucleotideTable dinucTable;
        public string sequence;
        public int diSequenceLength ;

        //Constructor makes sequence circle.
        public DinucCalculation(DinucleotideTable dinucTable, string sequence)
        {
            this.dinucTable = dinucTable;
            this.sequence = sequence;
            this.diSequenceLength = sequence.Length / 2;
        }

        public List<string> SubseqListFirstFrame()
        {
            string circleSequence = this.sequence + this.sequence.Substring(0, 10);
            var subseqList = new List<string>();
            int length = 0;

            if (circleSequence.Length % 2 == 0)
                length = (circleSequence.Length - 10) / 2;
            else
                length = (circleSequence.Length - 10 - 1) / 2;

            while (length != 0)
            {
                subseqList.Add(circleSequence.Substring(0, 1) + circleSequence.Substring(1, 1));
                circleSequence = circleSequence.Substring(2);
                length -= 1;
            }

            return subseqList;
        }

        public List<string> SubseqListSecondFrame()
        {
            string circleSequence = this.sequence + this.sequence.Substring(0, 11);
            circleSequence = circleSequence.Substring(1);
            var subseqList = new List<string>();
            int length = 0;

            if(circleSequence.Length % 2 == 0)
                length = length = (circleSequence.Length - 10) / 2;
            else
                length = (circleSequence.Length - 10 - 1) / 2;

            while (length != 0)
            {
                subseqList.Add(circleSequence.Substring(0, 1) + circleSequence.Substring(1, 1));
                circleSequence = circleSequence.Substring(2);
                length -= 1;
            }

            return subseqList;
        }
        public void DinucCalc (List<string> dinucList, string frame)
        {
            int i = 0;

            foreach(var item1 in dinucTable.Dinuc)
            {
                foreach(var item2 in dinucList)
                {
                    if ((item1 == item2) && (frame == "1st"))
                    {
                        this.dinucTable.DinucCountFirstFrame[i]++;
                        this.dinucTable.DinucFrqFirstFrame[i] = Math.Round((double)this.dinucTable.DinucCountFirstFrame[i] / this.diSequenceLength, 4);
                    }

                    if ((item1 == item2) && (frame == "2nd"))
                    {
                        this.dinucTable.DinucCountSecondFrame[i]++;
                        this.dinucTable.DinucFrqSecondFrame[i] = Math.Round((double)this.dinucTable.DinucCountSecondFrame [i]/ this.diSequenceLength, 4);
                    }
                }
                i++;
            }
        }

        public void  DinucFrqDiffCalc()
        {
            for(var i = 0; i < 16; i++)
            {
                this.dinucTable.DinucFrqDiff += Math.Abs(this.dinucTable.DinucFrqFirstFrame[i] - this.dinucTable.DinucFrqSecondFrame[i]);
            }
        }
    }
}
