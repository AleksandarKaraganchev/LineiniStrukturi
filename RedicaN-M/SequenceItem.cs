using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedicaN_M
{
    public class SequenceItem
    {
        public int Value { get; set; }
        public SequenceItem Previous { get; set; }

        public SequenceItem(int value, SequenceItem previous)
        {
            Value = value;
            Previous = previous;
        }
    }
}
