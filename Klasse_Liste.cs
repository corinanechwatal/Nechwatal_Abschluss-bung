using System;
using System.Collections.Generic;
using System.Text;

namespace Abschlussübung_Nechwatal
{
    class Klasse_Liste
    {
        //Insektenhotel mit hinzufügen und entfernen
        List<Insekt> Insektenhotel = new List<Insekt>();

        public void Add(Insekt i)
        {
            Insektenhotel.Add(i);
        }

        public void Remove(Insekt i1)
        {
            Insektenhotel.Remove(i1);
        }
    }

}
