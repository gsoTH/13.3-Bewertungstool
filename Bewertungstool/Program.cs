namespace Bewertungstool
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Note> noten = BeispielObjekteErzeugen();
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain(noten));
        }

        private static List<Note> BeispielObjekteErzeugen()
        {
            // TODO: Noten aus Datei einlesen, statt hier zu erzeugen

            List<Note> beispielNoten = new List<Note>();
            beispielNoten.Add(new Note(100, 80));
            beispielNoten.Add(new Note(100, 42));
            beispielNoten.Add(new Note(100, 67));
            beispielNoten.Add(new Note(100, 93));

            return beispielNoten;


        }

        public static void ErzeugeJSON(List<Note> noten)
        {
            // TODO: Datei erzeugen
            // TODO: Anzahl der Objekte in Datei eintragen
            // TODO: Alle Objekte in Datei auflisten
        }
    }
}