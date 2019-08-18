using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinucMVC.Helpers
{
    public static class SeqTest
    {
        public static string SeqNucTest(string seq)
        {
            char[] seqCharArray = seq.ToCharArray();

            foreach(var seqChar in seqCharArray)
            {
                if (seqChar != 'a' && seqChar != 'c' && seqChar != 'g' && seqChar != 't')
                {
                    return "Use a c g t only";
                }
            }

            if (seq.Length < 64)
                return "1 " + seq + " " + seq.Length + " bp";
            else
                return "1 " + seq.Substring(0, 64) + " ..... " + seq.Length + " bp";
        }

        public static bool SeqDinucTest()
        {


            return true;
        }
    }
}
