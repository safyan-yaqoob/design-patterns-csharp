using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    public class AdvanceRemoteControl:RemoteControl
    {
        public AdvanceRemoteControl(Device device) : base(device)
        {
        }

        public void SetChannel(int number)
        {
            _device.SetChannel(number);
        }
    }
}
