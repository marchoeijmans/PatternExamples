using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BR = PreserveWholeObject.BeforeRefactor;
using AR = PreserveWholeObject.AfterRefactor;

namespace PreserveWholeObject
{
    class Program
    {
        static void Main(string[] args)
        {
            BR.Room room = new BR.Room();
            Console.WriteLine(room.withinPlan(new BR.HeatingPlan(new BR.TempRange(8, 18))));
            
            AR.Room roomRefactored = new AR.Room();
            Console.WriteLine(roomRefactored.withinPlan(new AR.HeatingPlan(new AR.TempRange(8, 18))));

            Console.ReadLine();
         }
    }
}
