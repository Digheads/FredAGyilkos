using System;

namespace FredAGyilkos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool p = false;
            bool q = false;
            bool r = false;
            bool s = false;

            bool replay = true;

            while (replay)
            {
                Console.Clear();

                Console.WriteLine("Egy gyilkossággal kapcsolatban az alábbiakat sikerült megállapítani:");
                Console.WriteLine("\t- Ha Joe nem találkozott akkor éjjel Freddel, akkor Fred a gyilkos vagy Joe hazudik.");
                Console.WriteLine("\t- Ha nem Fred a gyilkos, akkor Joe nem találkozott akkor éjjel Freddel, és a gyilkosság éjfél után történt.");
                Console.WriteLine("\t- Ha a gyilkosság éjfél után történt, akkor Fred a gyilkos vagy Joe hazudik.");
                Console.WriteLine("A gyilkos után nyomozó felügyelő ezek alapján arra következtetett, hogy Fred a gyilkos.");
                Console.WriteLine("Helyesen tette-e?");
                Console.WriteLine();

                Console.Write("Joe nem találkozott akkor éjjel Freddel? (I - igen, egyébként - nem): ");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.I)
                    p = true;

                Console.WriteLine();
                Console.Write("Fred a gyilkos? (I - igen, egyébként - nem): ");
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.I)
                    q = true;

                Console.WriteLine();
                Console.Write("Joe hazudik? (I - igen, egyébként - nem): ");
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.I)
                    r = true;

                Console.WriteLine();
                Console.Write("A gyilkosság éjfél után történt? (I - igen, egyébként - nem): ");
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.I)
                    s = true;

                Console.WriteLine();
                if (FredAGyilkos(p, q, r, s))
                    Console.Write("Fred a gyilkos, a következtetés helyes!");
                else
                    Console.Write("Nem Fred a gyilkos, a nyomozó rosszul következtetett!");

                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Újrajátszás? (I - igen, egyébként - kilépés): ");
                key = Console.ReadKey();
                if (key.Key != ConsoleKey.I)
                    replay = false;
            }
        }

        static bool FredAGyilkos(bool p, bool q, bool r, bool s)
        {
            if ((!p || q || r) && (q || (p & s)) && (!s || q || r))
            {
                if (q)
                    //Fred a gyilkos, a következtés helyes!
                    return true;
                else
                    //nem Fred a gyilkos, a következtetés ellentmondásos!
                    return false;
            }
            else
            {
                //nem Fred a gyilkos, rosszul következtetett a nyomozó!
                return false;
            }
        }
    }
}
