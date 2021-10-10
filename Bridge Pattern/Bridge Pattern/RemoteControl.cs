using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    public class RemoteControl
    {
        protected Device _device;
        public RemoteControl(Device device)
        {
            _device = device;
        }

        public void TurnOn()
        {
            _device.TurnOn();
        }
        public void TurnOff()
        {
            _device.TurnOff();
        }
    }
}
