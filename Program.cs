using System;
using System.Collections.Generic;

namespace PollardsRhoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<long>();
            new PollardsRhoSolver().GetFactors(list, 13195);
            list.ForEach(s => Console.WriteLine(s));
        }
    }
}
