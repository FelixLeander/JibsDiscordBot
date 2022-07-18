using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Pattern
{
    internal class Dot
    {
        public int Pos { get; set; }
        public bool IsUsed { get; set; }
        public Dot? Child { get; set; }

        public Dot(int pos, bool isUsed = false)
        {
            Pos = pos;
            IsUsed = isUsed;
        }
    }
}
