using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Abschlussübung_Nechwatal
{
    public sealed class Fliegeinsekten : Insekt
    {
        public override bool IstGefährlich { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }
        public override bool KannFliegen { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }
        public Fliegeinsekten(string art, bool kannFliegen, string name, int eigenschaften):base(name, art, eigenschaften)
        {
            KannFliegen = kannFliegen;
            Name = name;
            Eigenschaften = eigenschaften;
            Art = art;

        }
        public override string ToString()
        {
            return "Name: " + Name + " Art: " + Art + "Eigenschaften: " + Eigenschaften;
        }

    }
}
