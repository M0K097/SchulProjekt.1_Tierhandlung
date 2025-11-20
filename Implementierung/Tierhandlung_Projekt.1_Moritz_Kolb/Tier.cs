namespace Tierhandlung_Projekt._1_Moritz_Kolb
{   
    public static class Tierheim
    {
        static List<Tier> alle_tiere = new ();
        static private void tier_hinzufügen(Tier tier) => alle_tiere.Add(tier);
        static public void tier_erstellen()
        {
            try
            {
                Console.WriteLine("Tierart:");
                var art = Console.ReadLine();
                Console.WriteLine("Tiername:");
                var name = Console.ReadLine();
                Console.WriteLine("Geburtsdatum:");
                var datum = Convert.ToDateTime(Console.ReadLine());


                if (art != null && name != null)
                {
                    tier_hinzufügen(new Tier(art, name, datum));
                }
                else
                {
                    throw new Exception("Tierart oder Name war NULL");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Fehler: {e}");
            }
        }

        static public List<Tier> filter_nach_tier(string suchbegriff)
        {
            var gefilterte_tiere = alle_tiere.Where((Tier t) => t.name == "*"+suchbegriff+"*").ToList();
            return gefilterte_tiere;
        }


    }
    public class Tier
    {
        public string tierart { get; set; }
        public string name { get; set; }
        public DateTime geburtsdatum { get; set; }
        public string beschreibung { get; set; }
        public bool reserviert { get; set; }

        public Tier(string art, string name_des_tieres, DateTime geburtsdatum)
        {
            tierart = art;
            name = name_des_tieres;
            this.geburtsdatum = geburtsdatum;
            beschreibung = "keine Beschreibung";
            reserviert = false;
            
        }
            
    }
}
