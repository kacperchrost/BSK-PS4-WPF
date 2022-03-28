using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS4.Ex
{
    class LFSR_Line
    {

        public List<int> Line; //pojedyncza linia
        public int xor { get; set; } //wynik xor

        public LFSR_Line()
        {
            Line = new List<int>();
            xor = -1;
        }

        public int XOR_Method(int x, int y)
        {
            if (x == 0 && y == 0)
            {
                return 0;
            }

            if (x == 1 && y == 0)
            {
                return 1;
            }

            if (x == 0 && y == 1)
            {
                return 1;
            }

            if (x == 1 && y == 1)
            {
                return 0;
            }

            return -1;
        }
    }
    class LFSR
    {
        private int Repeat;
        private string Taps;

        public LFSR(string Repeat, string Taps)
        {
            this.Repeat = int.Parse(Repeat);
            this.Taps = Taps;
        }
        public static int[] ToArray(string s)
        {
            int[] ints = s.ToCharArray().Where(x => int.TryParse(x.ToString(), out int myInt)).Select(selector: x => int.Parse(x.ToString())).ToArray();
            return ints;
        }
        public string Generate()
        {
            string result = "";

            return result;
        }
    }
    
}
