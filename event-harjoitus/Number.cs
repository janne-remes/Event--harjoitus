using System;
using System.Collections.Generic;
using System.Security.Cryptography;
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

            _numToAdd.AddNum += (object sender, NumberAddingEventArgs args) =>
            {
                Console.WriteLine("Lukuun {0} lisätään luku.", _numberForModify);
                switch (args.exactNumber)
                {
                    case 1:
                        Console.WriteLine("{0} + 1", _numberForModify);
                        _numberForModify += 1;
                        Console.WriteLine("Summa ja uusi luku on: {0}", _numberForModify);
                        break;

                    case 2:
                        Console.WriteLine("{0} + 2", _numberForModify);
                        _numberForModify += 2;
                        Console.WriteLine("Summa ja uusi luku on: {0}", _numberForModify);
                        break;

                    case 3: Console.WriteLine("{0} + 3", _numberForModify);
                        _numberForModify += 3;
                        Console.WriteLine("Summa ja uusi luku on: {0}", _numberForModify);
                        break;

                    case 4: Console.WriteLine("{0} + 4", _numberForModify);
                        _numberForModify += 4;
                        Console.WriteLine("Summa ja uusi luku on: {0}", _numberForModify);
                        break;

                    case 5: Console.WriteLine("{0} + 5", _numberForModify);
                        _numberForModify += 5;
                        Console.WriteLine("Summa ja uusi luku on: {0}", _numberForModify);
                        break;
                }
            };
        }
    }
}
