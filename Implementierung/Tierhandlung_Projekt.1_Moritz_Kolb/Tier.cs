using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tierhandlung_Projekt._1_Moritz_Kolb
{   
    public enum tier_art
    {
        Hund,
        Katze,
        Hamster,
        Ratte,
        Maus,
        Vogel,
        Reptiel
    }

    public static class Tierheim
    {
        static List<Tier> alle_tiere = new ();

    }
    public class Tier
    {
        public tier_art tierart { get; set; }
        public string name { get; set; }
        public DateTime geburtsdatum { get; set; }
        public string beschreibung { get; set; }
        public bool reserviert { get; set; }

        public Tier(tier_art art, string name_des_tieres, DateTime geburtsdatum)
        {
            tierart = art;
            name = name_des_tieres;
            this.geburtsdatum = geburtsdatum;
            beschreibung = "keine Beschreibung";
            reserviert = false;
            
        }
            
    }
}
