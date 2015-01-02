using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Conditional_Operator_With_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var analyst = new Worker();
            analyst.WorkPerformed += analyst_WorkPerformed;
            analyst.DoWork(8, WorkType.Analysis);

            Console.ReadLine();
        }

        static void analyst_WorkPerformed(int hours, WorkType workType)
        {
            Console.WriteLine("Work Type : {0}, Hour {1}", workType, hours);
        }
    }
}
