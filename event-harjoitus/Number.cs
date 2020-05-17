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
        private NumberSubtraction _numToSubtract;

        public Number(int numberForModify, NumberAdding numToAdd, NumberSubtraction numToSubtract)
        {
            _numberForModify = numberForModify;
            _numToAdd = numToAdd;
            _numToSubtract = numToSubtract;

            _numToAdd.AddNum += (object sender, NumberModifyingEventArgs args) =>
            {
                Console.WriteLine("Lukuun {0} lisätään {1}.", _numberForModify, args.exactNumber);
                Console.ForegroundColor = ConsoleColor.Yellow;

                switch (args.exactNumber)
                {
                    case 1:
                        Console.WriteLine("{0} + 1", _numberForModify);
                        _numberForModify += 1;
                        break;

                    case 2:
                        Console.WriteLine("{0} + 2", _numberForModify);
                        _numberForModify += 2;
                        break;

                    case 3:
                        Console.WriteLine("{0} + 3", _numberForModify);
                        _numberForModify += 3;
                        break;

                    case 4:
                        Console.WriteLine("{0} + 4", _numberForModify);
                        _numberForModify += 4;
                        break;

                    case 5:
                        Console.WriteLine("{0} + 5", _numberForModify);
                        _numberForModify += 5;
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Summa ja uusi luku on: {0}", _numberForModify);
                Console.ResetColor();

                Console.WriteLine();
            };

            _numToSubtract.SubtractNum += (object sender, NumberModifyingEventArgs args) =>
            {
                Console.WriteLine("Luvusta {0} vähennetään {1}.", _numberForModify, args.exactNumber);
                Console.ForegroundColor = ConsoleColor.Magenta;
                switch (args.exactNumber)
                {
                    case 1:
                        Console.WriteLine("{0} - 1", _numberForModify);
                        _numberForModify -= 1;
                        break;

                    case 2:
                        Console.WriteLine("{0} - 2", _numberForModify);
                        _numberForModify -= 2;
                        break;

                    case 3:
                        Console.WriteLine("{0} - 3", _numberForModify);
                        _numberForModify -= 3;
                        break;

                    case 4:
                        Console.WriteLine("{0} - 4", _numberForModify);
                        _numberForModify -= 4;
                        break;

                    case 5:
                        Console.WriteLine("{0} - 5", _numberForModify);
                        _numberForModify -= 5;
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Erotus ja uusi luku on: {0}", _numberForModify);
                Console.ResetColor();

                Console.WriteLine();
            };
        }
    }
}
