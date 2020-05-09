using System;
using System.Collections.Generic;
using System.Text;

namespace event_harjoitus
{

    public delegate void NumAddEventHandler();
    public class NumberAdding
    {
        public event NumAddEventHandler AddNum;
        
        public void AddOne()
        {
            AddNum();
        }

        public void AddTwo()
        {
            AddNum();
        }
    }
}
