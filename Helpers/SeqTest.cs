using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinucMVC.Helpers
{
    public class SeqTest
    {
        public bool SeqNucTest(string seq)
        {
            char[] seqCharArray = seq.ToCharArray();

            foreach(var seqChar in seqCharArray)
            {
                if (seqChar != 'a' && seqChar != 'c' && seqChar != 'g' && seqChar != 't')
                    return false;
            }
            return true;
        }
    }
}
