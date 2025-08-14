using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Monster_Arena
{
    internal class Monster
    {
        #region Monster ID
        public int ID {  get; set; }

       
        #endregion


        #region Monstername
        public string name {  get; set; }
        #endregion


        #region Lebenspunkte
        public int HP { get; set; }

        public int Basis_HP { get; set; }
        #endregion


        #region leichter Angriff
        public int ATK_leicht { get; set; }
        public  string ATK_leicht_Name { get; set; }
        #endregion


        #region schwerer Angriff
        public int ATK_schwer { get; set; }
        public string ATK_schwer_Name { get; set; }
        #endregion


        #region magischer Angriff
        public int magical { get; set; }
        public string magical_Name { get; set; }
        #endregion


        #region Verteidigungspunkte
        public int DEF_Points { get; set; }
        #endregion


        #region Level und Erfahrungspunkte
        public int LvL { get; set; }
        public int EP { get; set; }
        #endregion


        #region Monstertyp
        public string Typ { get; set; }
        #endregion


        #region ausgeteilter Schaden
        public int ausgeteilter_leichter_schaden { get { return leichter_Angriff(this.ATK_leicht); } }

        public int ausgeteilter_schwerer_schaden => schwerer_Angriff(this.ATK_schwer);
        public int ausgeteilter_magischer_schaden => magischer_Angriff(this.magical);

        public int Aktionspunkte { get; set; } = 20;




        public Monster () { }

        // Copy-Konstruktor
        public Monster(Monster klon)
        {
            ID = klon.ID;
            name = klon.name;
            HP = klon.HP;
            Basis_HP = klon.Basis_HP;
            ATK_leicht = klon.ATK_leicht;
            ATK_leicht_Name = klon.ATK_leicht_Name;
            ATK_schwer = klon.ATK_schwer;
            ATK_schwer_Name = klon.ATK_schwer_Name;
            magical = klon.magical;
            magical_Name = klon.magical_Name;
            DEF_Points = klon.DEF_Points;
            LvL = klon.LvL;
            EP = klon.EP;
            Typ = klon.Typ;
            Aktionspunkte = klon.Aktionspunkte;
        }

        // Clone-Methode
        public Monster Clone()
        {
            return new Monster(this);
        }





        #endregion


        ///  Methoden ///

        public int leichter_Angriff(int ATK_leicht)
        {
            Random random = new Random();
            int multiplikator = random.Next(10 , 16);

            double vorläufiger_Schadenswert = ((double)multiplikator / 10) * ATK_leicht;
            int ausgeteilter_Schaden = (int)vorläufiger_Schadenswert;

            return ausgeteilter_Schaden;
        }


        public int schwerer_Angriff(int ATK_schwer)
        {
            Random random = new Random();
            int multiplikator = random.Next(10, 25);

            double vorläufiger_Schadenswert = ((double)multiplikator / 10) * ATK_schwer;
            int ausgeteilter_Schaden = (int)vorläufiger_Schadenswert;

            return ausgeteilter_Schaden;
        }


        public int magischer_Angriff(int magical)
        {
            Random random = new Random();
            int multiplikator = random.Next(10, 30);

            double vorläufiger_Schadenswert = ((double)multiplikator /10) * magical;
            int ausgeteilter_Schaden = (int)vorläufiger_Schadenswert;

            return ausgeteilter_Schaden;
        }
    }
}
