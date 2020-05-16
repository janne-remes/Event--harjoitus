using System;
using System.Collections.Generic;
using System.Text;

namespace event_harjoitus
{

    public delegate void NumAddEventHandler(object sender, NumberModifyingEventArgs args);
    public class NumberAdding
    {
        public event NumAddEventHandler AddNum;
        
        public void AddOne()
        {
            AddNum(this, new NumberModifyingEventArgs { exactNumber = 1 });
        }

        public void AddTwo()
        {
            AddNum(this, new NumberModifyingEventArgs { exactNumber = 2 });
        }

        public void AddThree()
        {
            AddNum(this, new NumberModifyingEventArgs { exactNumber = 3 });
        }

        public void AddFour()
        {
            AddNum(this, new NumberModifyingEventArgs { exactNumber = 4 });
        }

        public void AddFive()
        {
            AddNum(this, new NumberModifyingEventArgs { exactNumber = 5 });
        }
    }
}
