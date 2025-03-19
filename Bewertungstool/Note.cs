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
            get { return Math.Round((double)erreichtePunkte/(double)moeglichePunkte, 2); }
        }

        public double Dezimal
        {
            get
            {
                switch (Prozent)
                {
                    case < 0.2:     return 6;
                    case < 0.26:    return 5.3;
                    case < 0.33:    return 5;
                    case < 0.39:    return 4.7;
                    case < 0.49:    return 4.3;
                    case < 0.5:     return 4;
                    case < 0.55:    return 3.7;
                    case < 0.6:     return 3.3;
                    case < 0.65:    return 3;
                    case < 0.7:     return 2.7;
                    case < 0.75:    return 2.3;
                    case < 0.8:     return 2;
                    case < 0.85:    return 1.7;
                    case < 0.9:     return 1.3;
                    case < 0.95:    return 1;
                    default:        return 0.7; 
                }
            }
        }

        public string Kurz
        {
            get
            {
                switch (Prozent)
                {
                    case < 0.2: return "6";
                    case < 0.26: return "5-";
                    case < 0.33: return "5";
                    case < 0.39: return "5+";
                    case < 0.44: return "4-";
                    case < 0.5: return "4";
                    case < 0.55: return "4+";
                    case < 0.6: return "3-";
                    case < 0.65: return "3";
                    case < 0.7: return "3+";
                    case < 0.75: return "2-";
                    case < 0.8: return "2";
                    case < 0.85: return "2+";
                    case < 0.9: return "1-";
                    case < 0.95: return "1";
                    default: return "1+";
                }
            }
        }

        public string Lang
        {
            get
            {
                switch (Prozent)
                {
                    case < 0.2:  return "ungenügend";
                    case < 0.26: return "mangelhaft";
                    case < 0.33: return "mangelhaft";
                    case < 0.39: return "mangelhaft";
                    case < 0.44: return "ausreichend";
                    case < 0.5:  return "ausreichend";
                    case < 0.55: return "befriedigend";
                    case < 0.6:  return "befriedigend";
                    case < 0.65: return "befriedigend";
                    case < 0.7:  return "befriedigend";
                    case < 0.75: return "gut";
                    case < 0.8:  return "gut";
                    case < 0.85: return "gut";
                    case < 0.9:  return "sehr gut";
                    case < 0.95: return "sehr gut";
                    default:     return "sehr gut";
                }
            }
        }
        
    }
}