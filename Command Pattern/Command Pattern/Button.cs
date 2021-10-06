using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    public class Button
    {
        private string Label { get; set; }
        private ICommand command;

        public Button(ICommand command)
        {
            this.command = command;
        }

        public void Click()
        {
            this.command.Execute();
        }
    }
}
