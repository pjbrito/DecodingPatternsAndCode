using System.Collections;
using System.Linq;
using System.Text;

namespace DecodingPatternsAndCode.Tests.Book.Chapter01
{
    public class BitVisualizer
    {
        private readonly int[] _bitValues;

        public BitVisualizer(int intBitValue)
        {
            var intermediateRepresentation = new BitArray(new[] { intBitValue });
            _bitValues = intermediateRepresentation
                .Cast<bool>()
                .Select(b => (b ? 1 : 0))
                .ToArray();
        }

        public string GetBitString()
        {
            var str = new StringBuilder();
            foreach (var b in _bitValues)
            {
                str.Insert(0, b);
            }
            return str.ToString();
        }

        public override string ToString()
        {
            return GetBitString();
        }
    }
}