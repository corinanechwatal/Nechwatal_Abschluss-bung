using System;
using System.Collections.Generic;
using System.Text;

namespace Abschlussübung_Nechwatal
{
    public sealed class Krabbeltiere : Insekt
    {
        public override bool IstGefährlich { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }
        public override bool KannFliegen { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }

        public Krabbeltiere(string art, bool kannFliegen, string name, int eigenschaften):base(name, art, eigenschaften)
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
