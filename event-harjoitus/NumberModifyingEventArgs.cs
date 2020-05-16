using System;
using System.Collections.Generic;
using System.Text;

namespace event_harjoitus
{
    public class NumberModifyingEventArgs : EventArgs
    {
        public int exactNumber { get; set; }
    }
}
