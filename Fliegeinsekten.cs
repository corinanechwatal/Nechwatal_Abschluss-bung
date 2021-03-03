using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Abschlussübung_Nechwatal
{
    public sealed class Fliegeinsekten : Insekt
    {
        public override bool IstGefährlich { get { return false; } }
        public override bool KannFliegen { get { return false; } }
        public Fliegeinsekten(string art, bool kannFliegen, string name, int eigenschaften):base(name, art, eigenschaften)
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
