using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method_Pattern
{
    public class TransferMoneyTask : Task
    {
        protected override void DoExecute()
        {
            Console.WriteLine("Money Transfer");
        }
    }
}
