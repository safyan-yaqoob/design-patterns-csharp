using System;

namespace Template_Method_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = new TransferMoneyTask();
            task.Execute();
        }
    }
}
