using System;
using System.Collections.Generic;

namespace Abschlussübung_Nechwatal
{
    class Program
    {
        static void Main(string[] args)
        {
            Klasse_Liste<Insekt> insekten = new Klasse_Liste<Insekt> { };
            Insekt i = new Insekt("Orchideenmantis", "friedlich", 5);
            insekten.Add(i);
            Console.WriteLine(i);
        }
    }

    class Klasse_Liste<T>
    {
        internal void Add(Insekt i)
        {
            throw new NotImplementedException();
        }
    }
}

