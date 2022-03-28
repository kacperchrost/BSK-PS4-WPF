using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS4.Ex
{
    class Cipher
    {
        private string BitString;
        private string Taps;
        private string Repeat;
        public Cipher(string BitString, string Taps)
        {
            this.BitString = BitString;
            this.Taps = Taps;
            Repeat = BitString;
            
        }
        public string EnDecrypt()
        {
            string temp = Repeat.ToString();
            LFSR LFSR = new(temp, Taps);
            //string temp = LFSR.GenerateWordLength(BitString.Length);
            //wywołanie generowania klucza
            string key = LFSR.Generate();

            int[] lfsrInts = LFSR.ToArray(key);
            //int[] lfsrInts = LFSR.ToArray(temp);
            //stworzenie tabeli z kluczem
            int[] bitStringsInts = LFSR.ToArray(BitString);
            int[] resultInts = new int[BitString.Length];

            for (int i = 0; i < BitString.Length; i++)
            {
                int xor = lfsrInts[i] ^ bitStringsInts[i];
                resultInts[i] = xor;
            }

            return string.Join("", resultInts);
        }
    }
}
