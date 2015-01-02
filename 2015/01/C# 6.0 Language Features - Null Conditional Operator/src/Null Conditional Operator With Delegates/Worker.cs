using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Conditional_Operator_With_Delegates
{
    public delegate void WorkPerformedHandler(int hours, WorkType workType);

    public class Worker
    {
        public event WorkPerformedHandler WorkPerformed;

        public void DoWork(int hours, WorkType type)
        {
            for (int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i, type);
            }
        }

        private void OnWorkPerformed(int hours, WorkType type)
        {
            WorkPerformedHandler localHandler = WorkPerformed;
            if (localHandler != null)
            {
                localHandler(hours, type);
            }
            //WorkPerformed?.Invoke(hours, type);
        }
    }

    public enum WorkType
    {
        Analysis,
        Design,
        Development,
        Testing,
        Support
    }
}
