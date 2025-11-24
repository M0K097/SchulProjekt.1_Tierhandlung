using System.Text.Json;
namespace Tierhandlung_Projekt._1_Moritz_Kolb
{   
    public static class Tierheim
    {
        public static List<Tier>? tmp_data = new List<Tier>();
        public static List<Tier>? alle_tiere = new List<Tier>();
        public static void load_data()
        {
            string folderPath = "data";
            Directory.CreateDirectory(folderPath);

            string filePath = Path.Combine(folderPath, "tiere.json");
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "[]");
            }
            string json_load = File.ReadAllText(filePath);
            tmp_data = JsonSerializer.Deserialize<List<Tier>>(json_load);
            alle_tiere = tmp_data.ToList();
        }
    static public void tier_hinzufügen()
        {
            if(tmp_data is not null)
            {
                alle_tiere = tmp_data;
            }
            else
            {
                alle_tiere = new List<Tier>();
            }
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
                    alle_tiere.Add(new Tier(art, name, datum));
                    string json = JsonSerializer.Serialize(alle_tiere);
                    File.WriteAllText($"data/tiere.json",json);
                    Console.WriteLine($"{art}{name} wurde erfoglreich hinzugefügt");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Fehler: {e}");
            }

            Console.WriteLine("Drücke eine beliebige Taste...");
            Console.ReadLine();
        }

        static public void filter_nach_tier()
        {

            string suchbegriff = "";
            var suche = Console.ReadLine();
            if (suche is not null)
            {
                suchbegriff = suche;
            }
            var gefilterte_tiere = alle_tiere.Where(( tier ) => tier.tierart.Contains(suchbegriff)).ToList();
            tiere_anzeigen(gefilterte_tiere);
            Console.ReadLine();

        }

        static public void tiere_anzeigen(List<Tier> tiere)
        {
            foreach(Tier tier in tiere)
            {
                Console.WriteLine($"Art: {tier.tierart} Name: {tier.name} Geburtsdatum: {tier.geburtsdatum}");
            }
            Console.WriteLine();
        }



    }
    public class Tier
    {
        public string tierart { get; set; }
        public string name { get; set; }
        public DateTime geburtsdatum { get; set; }
        public string beschreibung { get; set; }

        public Tier() { }
        public Tier(string art, string name_des_tieres, DateTime geburtsdatum)
        {
            tierart = art;
            name = name_des_tieres;
            this.geburtsdatum = geburtsdatum;
            beschreibung = "keine Beschreibung";
            
        }

        
            
    }
}
