using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS4.Ex
{
    class Cipher
    {
        private readonly string BitString;
        private readonly string Taps;
        private readonly string Seed;
        public Cipher(string bitString, string seed, string taps)
        {
            BitString = bitString;
            Taps = taps;
            Seed = seed;
        }
        public string Encrypt()
        {
            LFSR lFSR = new(Seed, Taps);
            string temp = lFSR.GenerateWordLength(BitString.Length);

            int[] lfsrInts = LFSR.ToArray(temp), bitStringsInts = LFSR.ToArray(BitString), resultInts = new int[BitString.Length];

            for (int i = 0; i < BitString.Length; i++)
            {
                int xor = lfsrInts[i] ^ bitStringsInts[i];
                resultInts[i] = xor;
            }

            return string.Join("", resultInts);
        }
    }
}
