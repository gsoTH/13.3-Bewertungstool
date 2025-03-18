namespace Bewertungstool
{
    public class Note
    {
        private int moeglichePunkte;
        private int erreichtePunkte;
        public Note(int moeglichePunkte, int erreichtePunkte)
        {
            this.moeglichePunkte = moeglichePunkte;
            this.erreichtePunkte = erreichtePunkte;
        }

        public int MoeglichePunkte { get { return moeglichePunkte; } }
        public int ErreichtePunkte { get { return erreichtePunkte; }  }
        public double Prozent
        {
            get { return 25.0; }
        }

        public double Dezimal
        {
            get { return 5.3; }
        }

        public string Kurz
        {
            get { return "5-"; }
        }

        public string Lang
        {
            get { return "mangelhaft"; }
        }
    }
}