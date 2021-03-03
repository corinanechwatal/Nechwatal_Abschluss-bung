using System;
using System.Collections.Generic;
using System.Text;

namespace Abschlussübung_Nechwatal
{
    public sealed class Krabbeltiere : Insekt
    {
        public override bool IstGefährlich { get { return false; } }
        public override bool KannFliegen => false;

        public Krabbeltiere(string art, bool kannFliegen, string name, int eigenschaften):base(name, art, eigenschaften)
        {
            KannFliegen = kannFliegen;
            Name = name;
            Eigenschaft = eigenschaften;
            Art = art;

        }

        public override string ToString()
        {
            return "Name: " + Name + " Art: " + Art + "Eigenschaften: " + Eigenschaft;
        }

    }
}
