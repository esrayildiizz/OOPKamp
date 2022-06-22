using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphizm
{
    internal class AraSicaklar:Yemek
    {
        public override string SunumSekli()
        {
            return "Yanında patates ve içecek ile.";
        }
    }
}
