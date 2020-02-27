using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTTM
{
    public class FizzBuzz
    {
        public FizzBuzz(string val)
        {
            Value = val;
        }
        public string Value { get; set; }
        public string PrintValue()
        {
            return Value;
        }
    }
}
