using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Arena
{
    internal class Arena
    {
        
            public string Arena_Typ { get; set; }

             #region Buff
            public int Arena_Buff_Angriff_Player{  get; set; }
            public int Arena_Buff_Verteidigung_Player { get; set; }    

            public int Arena_Buff_Angriff_PC { get; set; }

            public int Arena_Buff_Verteidigung_PC { get; set; }
             #endregion

        public ConsoleColor Hintergrundfarbe_der_Arena { get; set; }


        public string wähle_einen_zufälligen_Arena_Typ()
            {
                Random rnd = new Random();
                int zufallszahl = rnd.Next(1, 12); // 1 bis 11

                string gewählter_Arena_Typ;

                switch (zufallszahl)
                {
                    case 1:  gewählter_Arena_Typ = "Feuer";   Hintergrundfarbe_der_Arena = ConsoleColor.DarkRed; break;
                    case 2:  gewählter_Arena_Typ = "Wasser";  Hintergrundfarbe_der_Arena = ConsoleColor.DarkBlue; break;
                    case 3:  gewählter_Arena_Typ = "Erde";    Hintergrundfarbe_der_Arena = ConsoleColor.DarkYellow; break;
                    case 4:  gewählter_Arena_Typ = "Luft";    Hintergrundfarbe_der_Arena = ConsoleColor.Gray; break;
                    case 5:  gewählter_Arena_Typ = "Unlicht"; Hintergrundfarbe_der_Arena = ConsoleColor.DarkMagenta; break;
                    case 6:  gewählter_Arena_Typ = "Eis";     Hintergrundfarbe_der_Arena = ConsoleColor.Cyan; break;
                    case 7:  gewählter_Arena_Typ = "Elektro"; Hintergrundfarbe_der_Arena = ConsoleColor.Yellow; break;
                    case 8:  gewählter_Arena_Typ = "Pflanze"; Hintergrundfarbe_der_Arena = ConsoleColor.Green; break;
                    case 9:  gewählter_Arena_Typ = "Geist";   Hintergrundfarbe_der_Arena = ConsoleColor.Black; break;
                    case 10: gewählter_Arena_Typ = "Licht";   Hintergrundfarbe_der_Arena = ConsoleColor.White; break;
                    case 11: gewählter_Arena_Typ = "Gift";    Hintergrundfarbe_der_Arena = ConsoleColor.DarkGray; break;
                    default:
                        gewählter_Arena_Typ = "Neutral"; // Falls mal etwas schiefgeht
                        break;
                }

                return gewählter_Arena_Typ;
            }
           
        

    }
}
