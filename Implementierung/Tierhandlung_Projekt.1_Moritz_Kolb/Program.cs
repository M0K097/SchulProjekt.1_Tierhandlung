//Kurzbeschreibung: Eine Anwendung, mit der Mitarbeiter eines Tierheims die zu vermittelnden
//Tiere mit Fotos und Beschreibungen präsentieren können.
//Interessenten können die Tiere filtern und Adoptionsanfragen stellen.



namespace Tierhandlung_Projekt._1_Moritz_Kolb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tierheim.tier_erstellen();

            var gefilterte_tiere = Tierheim.filter_nach_tier("B");
            foreach (Tier t in gefilterte_tiere)
            {
                Console.WriteLine(t.name);
            }
            
        }
    }
}