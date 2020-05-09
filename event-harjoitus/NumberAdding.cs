using System;
using System.Collections.Generic;
using System.Text;

namespace event_harjoitus
{

    public delegate void NumAddEventHandler(object sender, NumberAddingEventArgs args);
    public class NumberAdding
    {
        public event NumAddEventHandler AddNum;
        
        public void AddOne()
        {
            AddNum(this, new NumberAddingEventArgs { exactNumber = 1 });
        }

        public void AddTwo()
        {
            AddNum(this, new NumberAddingEventArgs { exactNumber = 2 });
        }

        public void AddThree()
        {
            AddNum(this, new NumberAddingEventArgs { exactNumber = 3 });
        }

        public void AddFour()
        {
            AddNum(this, new NumberAddingEventArgs { exactNumber = 4 });
        }

        public void AddFive()
        {
            AddNum(this, new NumberAddingEventArgs { exactNumber = 5 });
        }
    }
}
