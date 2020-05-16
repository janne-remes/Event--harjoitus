using System;
using System.Collections.Generic;
using System.Text;

namespace event_harjoitus
{
    public delegate void NumSubtractEventHandler(object sender, NumberModifyingEventArgs args);
    public class NumberSubtraction
    {
        public event NumSubtractEventHandler SubtractNum;

        public void SubtractOne()
        {
            SubtractNum(this, new NumberModifyingEventArgs { exactNumber = 1 });
        }

        public void SubtractTwo()
        {
            SubtractNum(this, new NumberModifyingEventArgs { exactNumber = 2 });
        }

        public void SubtractThree()
        {
            SubtractNum(this, new NumberModifyingEventArgs { exactNumber = 3 });
        }

        public void SubtractFour()
        {
            SubtractNum(this, new NumberModifyingEventArgs { exactNumber = 4 });
        }

        public void SubtractFive()
        {
            SubtractNum(this, new NumberModifyingEventArgs { exactNumber = 5 });
        }
    }
}
