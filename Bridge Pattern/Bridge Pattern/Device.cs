using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    public interface Device
    {
        void TurnOn();
        void TurnOff();
        void SetChannel(int number);
    }
}
