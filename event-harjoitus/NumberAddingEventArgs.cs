using System;
using System.Collections.Generic;
using System.Text;

namespace event_harjoitus
{
    public class NumberAddingEventArgs : EventArgs
    {
        public int exactNumber { get; set; }
    }
}
