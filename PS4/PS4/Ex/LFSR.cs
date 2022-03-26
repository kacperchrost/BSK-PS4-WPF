using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS4.Ex
{
    class LFSR
    {
        private string Seed;
        private string Taps;
        public LFSR(string seed, string taps)
        {
            Seed = seed;
            Taps = taps;
        }
        public static int[] ToArray(string s)
        {
            int[] ints = s.ToCharArray().Where(x => int.TryParse(x.ToString(), out int myInt)).Select(selector: x => int.Parse(x.ToString())).ToArray();
            return ints;
        }
        public string GenerateWordLength(int size)
        {
            string oneLFSR = Step(Seed), result = "";

            for (int i = 0; i < size; i++)
            {
                if (i != 0)
                {
                    oneLFSR = Step(oneLFSR);
                }
                result += oneLFSR[0];
            }
            return result;
        }
        public string GenerateOne(string result)
        {
            return result == "Wynik" ? Step(Seed) : Step(result);
        }
        public string Step(string s)
        {
            //TODO to tutaj trzeba zrobić te pojedyncze przejście LFSRa  i chyba jeszcze trzeba jakas pomocnicza funkcje
            return "xd";
        }
    }
}
