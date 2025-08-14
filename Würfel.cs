using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Arena
{
    public class Würfel
    {

        private Random würfeln = new Random();

        public int würfelergebnis => Würfeln();

        public double treffer_stärke => treffer_chace(würfelergebnis);

        

        

        public int Würfeln()
        {

            return würfeln.Next(1, 7);   
        }

        public double treffer_chace(int würfelergebnis)
        {
            double stärke =0.0;
            
            switch (würfelergebnis)
            {
                case 1: stärke = 0.0; break;
                case 2: stärke = 1.0; break;
                case 3: stärke = 1.0; break;

                case 4: stärke = 1.0; break;
                case 5: stärke = 1.0; break;
                case 6: stärke = 1.0; break;
            }
            return stärke;
        }

        
    }
}
