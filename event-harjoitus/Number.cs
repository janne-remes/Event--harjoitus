using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace event_harjoitus
{
    public class Number
    {
        private int _numberForModify;
        private NumberAdding _numToAdd;

        public Number(int numberForModify, NumberAdding numToAdd)
        {
            _numberForModify = numberForModify;
            _numToAdd = numToAdd;

            _numToAdd.AddNum += () => Console.WriteLine("Lukuun {0} tehdään lisäys.", _numberForModify);
        }
    }
}
