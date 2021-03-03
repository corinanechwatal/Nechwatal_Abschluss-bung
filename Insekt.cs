using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace Abschlussübung_Nechwatal
{
    public abstract class Insekt
    {
        public string Name { get; set; }
        public virtual string Art { get; set; }
        private int eigenschaften;
        public abstract bool IstGefährlich { get; protected set; }
        public abstract bool KannFliegen { get;protected set; }


        public Insekt(string name, string art, int eigenschaften)
        {
            Name = name;
            Art = art;
            Eigenschaft = eigenschaften;
        }

        public int Eigenschaft
        {
            get { return eigenschaften; }
            set
            {
                if(value > 5)
                    throw new InsektException("Diese Nummer ist zu hoch!")
                int eigenschaften = value;
            }
        }
        public bool Essbar(int eigenschaften)
        {
            if (eigenschaften == 1)
                return true;
           
            else
                return false;
        }

        public override string ToString()
        {
            return "Name: " + Name + " Art: " + Art + "Eigenschaften: " + Eigenschaften;
        }


        //Merkmal, /nicht, Nahrung, Anzahl weltweit
    }
}
