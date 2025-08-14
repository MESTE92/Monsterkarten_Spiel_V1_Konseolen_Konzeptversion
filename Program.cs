using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Monster_Arena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Konsolenformatierung
            Console.OutputEncoding = Encoding.UTF8;
            Console.CursorVisible = false;
            #endregion



            #region Spielerliste
            List<Player> Spielerliste = new List<Player>();
            #endregion

            #region Monsterliste
            List<Monster> monsterListe = new List<Monster>();

            Monster Ignaros = new Monster();
            
            Ignaros.ID = 1;
            Ignaros.name = "Ignaros";
            Ignaros.Typ = "Feuer";
            Ignaros.LvL = 1;
            Ignaros.EP = 0;
            Ignaros.HP = 140;
            Ignaros.Basis_HP = 140;
            Ignaros.ATK_leicht = 12;
            Ignaros.ATK_leicht_Name = "Flammenhieb";
            Ignaros.ATK_schwer = 24;
            Ignaros.ATK_schwer_Name = "Glutstoß";
            Ignaros.magical = 28;
            Ignaros.magical_Name = "Feuerball";
            Ignaros.DEF_Points = 10;
            monsterListe.Add(Ignaros);

            Monster Aquarina = new Monster();
            Aquarina.ID = 2;
            Aquarina.name = "Aquarina";
            Aquarina.Typ = "Wasser";
            Aquarina.LvL = 1;
            Aquarina.EP = 0;
            Aquarina.HP = 130;
            Aquarina.Basis_HP = 130;
            Aquarina.ATK_leicht = 10;
            Aquarina.ATK_leicht_Name = "Wasserschlag";
            Aquarina.ATK_schwer = 22;
            Aquarina.ATK_schwer_Name = "Wellenbrecher";
            Aquarina.magical = 30;
            Aquarina.magical_Name = "Hydrobeam";
            Aquarina.DEF_Points = 12;
            monsterListe.Add(Aquarina);

            Monster Terrak = new Monster();
            Terrak.ID = 3;
            Terrak.name = "Terrak";
            Terrak.Typ = "Erde";
            Terrak.LvL = 1;
            Terrak.EP = 0;
            Terrak.HP = 160;
            Terrak.Basis_HP = 160;
            Terrak.ATK_leicht = 11;
            Terrak.ATK_leicht_Name = "Felswurf";
            Terrak.ATK_schwer = 25;
            Terrak.ATK_schwer_Name = "Erdbeben";
            Terrak.magical = 18;
            Terrak.magical_Name = "Steinsalve";
            Terrak.DEF_Points = 14;
            monsterListe.Add(Terrak);

            Monster Zephir = new Monster();
            Zephir.ID = 4;
            Zephir.name = "Zephir";
            Zephir.Typ = "Luft";
            Zephir.LvL = 1;
            Zephir.EP = 0;
            Zephir.HP = 140;
            Zephir.Basis_HP = 140;
            Zephir.ATK_leicht = 13;
            Zephir.ATK_leicht_Name = "Luftschnitt";
            Zephir.ATK_schwer = 21;
            Zephir.ATK_schwer_Name = "Tornadokick";
            Zephir.magical = 26;
            Zephir.magical_Name = "Sturmstoß";
            Zephir.DEF_Points = 8;
            monsterListe.Add(Zephir);

            Monster Noctra = new Monster();
            Noctra.ID = 5;
            Noctra.name = "Noctra";
            Noctra.Typ = "Unlicht";
            Noctra.LvL = 1;
            Noctra.EP = 0;
            Noctra.HP = 125;
            Noctra.Basis_HP = 125;
            Noctra.ATK_leicht = 14;
            Noctra.ATK_leicht_Name = "Schattenhieb";
            Noctra.ATK_schwer = 27;
            Noctra.ATK_schwer_Name = "Dunkelklaue";
            Noctra.magical = 32;
            Noctra.magical_Name = "Seelenpein";
            Noctra.DEF_Points = 11;
            monsterListe.Add(Noctra);

            Monster Lavamor = new Monster();
            Lavamor.ID = 6;
            Lavamor.name = "Lavamor";
            Lavamor.Typ = "Feuer";
            Lavamor.LvL = 1;
            Lavamor.EP = 0;
            Lavamor.HP = 150;
            Lavamor.Basis_HP = 150;
            Lavamor.ATK_leicht = 11;
            Lavamor.ATK_leicht_Name = "Ascheschlag";
            Lavamor.ATK_schwer = 23;
            Lavamor.ATK_schwer_Name = "Lavaeruption";
            Lavamor.magical = 29;
            Lavamor.magical_Name = "Feuerschauer";
            Lavamor.DEF_Points = 10;
            monsterListe.Add(Lavamor);

            Monster Blubblor = new Monster();
            Blubblor.ID = 7;
            Blubblor.name = "Blubblor";
            Blubblor.Typ = "Wasser";
            Blubblor.LvL = 1;
            Blubblor.EP = 0;
            Blubblor.HP = 130;
            Blubblor.Basis_HP = 130;
            Blubblor.ATK_leicht = 9;
            Blubblor.ATK_leicht_Name = "Platscher";
            Blubblor.ATK_schwer = 19;
            Blubblor.ATK_schwer_Name = "Tsunami";
            Blubblor.magical = 27;
            Blubblor.magical_Name = "Nassstoß";
            Blubblor.DEF_Points = 9;
            monsterListe.Add(Blubblor);

            Monster Gaianox = new Monster();
            Gaianox.ID = 8;
            Gaianox.name = "Gaianox";
            Gaianox.Typ = "Erde";
            Gaianox.LvL = 1;
            Gaianox.EP = 0;
            Gaianox.HP = 170;
            Gaianox.Basis_HP = 170;
            Gaianox.ATK_leicht = 10;
            Gaianox.ATK_leicht_Name = "Bodenschlag";
            Gaianox.ATK_schwer = 28;
            Gaianox.ATK_schwer_Name = "Schlammfaust";
            Gaianox.magical = 20;
            Gaianox.magical_Name = "Gesteinszauber";
            Gaianox.DEF_Points = 15;
            monsterListe.Add(Gaianox);

            Monster Sylfira = new Monster();
            Sylfira.ID = 9;
            Sylfira.name = "Sylfira";
            Sylfira.Typ = "Luft";
            Sylfira.LvL = 1;
            Sylfira.EP = 0;
            Sylfira.HP = 120;
            Sylfira.Basis_HP = 120;
            Sylfira.ATK_leicht = 12;
            Sylfira.ATK_leicht_Name = "Windpeitsche";
            Sylfira.ATK_schwer = 22;
            Sylfira.ATK_schwer_Name = "Hurrikanstoß";
            Sylfira.magical = 24;
            Sylfira.magical_Name = "Luftwirbel";
            Sylfira.DEF_Points = 10;
            monsterListe.Add(Sylfira);

            Monster Umbros = new Monster();
            Umbros.ID = 10;
            Umbros.name = "Umbros";
            Umbros.Typ = "Unlicht";
            Umbros.LvL = 1;
            Umbros.EP = 0;
            Umbros.HP = 135;
            Umbros.Basis_HP = 135;
            Umbros.ATK_leicht = 13;
            Umbros.ATK_leicht_Name = "Finsterfaust";
            Umbros.ATK_schwer = 26;
            Umbros.ATK_schwer_Name = "Nachtstachel";
            Umbros.magical = 31;
            Umbros.magical_Name = "Dämonensog";
            Umbros.DEF_Points = 13;
            monsterListe.Add(Umbros);

            Monster Glacira = new Monster();
            Glacira.ID = 11;
            Glacira.name = "Glacira";
            Glacira.Typ = "Eis";
            Glacira.LvL = 1;
            Glacira.EP = 0;
            Glacira.HP = 125;
            Glacira.Basis_HP = 125;
            Glacira.ATK_leicht = 11;
            Glacira.ATK_leicht_Name = "Froststoß";
            Glacira.ATK_schwer = 23;
            Glacira.ATK_schwer_Name = "Eissplitter";
            Glacira.magical = 30;
            Glacira.magical_Name = "Gefrierzauber";
            Glacira.DEF_Points = 13;
            monsterListe.Add(Glacira);

            Monster Voltranox = new Monster();
            Voltranox.ID = 12;
            Voltranox.name = "Voltranox";
            Voltranox.Typ = "Elektro";
            Voltranox.LvL = 1;
            Voltranox.EP = 0;
            Voltranox.HP = 145;
            Voltranox.Basis_HP = 145;
            Voltranox.ATK_leicht = 13;
            Voltranox.ATK_leicht_Name = "Blitzhieb";
            Voltranox.ATK_schwer = 26;
            Voltranox.ATK_schwer_Name = "Donnerzorn";
            Voltranox.magical = 32;
            Voltranox.magical_Name = "Stromschlag";
            Voltranox.DEF_Points = 9;
            monsterListe.Add(Voltranox);

            Monster Florania = new Monster();
            Florania.ID = 13;
            Florania.name = "Florania";
            Florania.Typ = "Pflanze";
            Florania.LvL = 1;
            Florania.EP = 0;
            Florania.HP = 135;
            Florania.Basis_HP = 135;
            Florania.ATK_leicht = 10;
            Florania.ATK_leicht_Name = "Rankenhieb";
            Florania.ATK_schwer = 22;
            Florania.ATK_schwer_Name = "Dornenwalze";
            Florania.magical = 28;
            Florania.magical_Name = "Blütensturm";
            Florania.DEF_Points = 14;
            monsterListe.Add(Florania);

            Monster Pyronix = new Monster();
            Pyronix.ID = 14;
            Pyronix.name = "Pyronix";
            Pyronix.Typ = "Feuer";
            Pyronix.LvL = 1;
            Pyronix.EP = 0;
            Pyronix.HP = 145;
            Pyronix.Basis_HP = 145;
            Pyronix.ATK_leicht = 14;
            Pyronix.ATK_leicht_Name = "Gluthieb";
            Pyronix.ATK_schwer = 27;
            Pyronix.ATK_schwer_Name = "Flammenzunge";
            Pyronix.magical = 29;
            Pyronix.magical_Name = "Inferno";
            Pyronix.DEF_Points = 11;
            monsterListe.Add(Pyronix);

            Monster Mystel = new Monster();
            Mystel.ID = 15;
            Mystel.name = "Mystel";
            Mystel.Typ = "Geist";
            Mystel.LvL = 1;
            Mystel.EP = 0;
            Mystel.HP = 120;
            Mystel.Basis_HP = 120;
            Mystel.ATK_leicht = 12;
            Mystel.ATK_leicht_Name = "Spukgriff";
            Mystel.ATK_schwer = 24;
            Mystel.ATK_schwer_Name = "Nebelklaue";
            Mystel.magical = 34;
            Mystel.magical_Name = "Seelenraub";
            Mystel.DEF_Points = 10;
            monsterListe.Add(Mystel);

            Monster Luxaris = new Monster();
            Luxaris.ID = 16;
            Luxaris.name = "Luxaris";
            Luxaris.Typ = "Licht";
            Luxaris.LvL = 1;
            Luxaris.EP = 0;
            Luxaris.HP = 130;
            Luxaris.Basis_HP = 130;
            Luxaris.ATK_leicht = 11;
            Luxaris.ATK_leicht_Name = "Strahlstoß";
            Luxaris.ATK_schwer = 25;
            Luxaris.ATK_schwer_Name = "Lichtblitz";
            Luxaris.magical = 31;
            Luxaris.magical_Name = "Heilstrahl";
            Luxaris.DEF_Points = 12;
            monsterListe.Add(Luxaris);

            Monster Venoxa = new Monster();
            Venoxa.ID = 17;
            Venoxa.name = "Venoxa";
            Venoxa.Typ = "Gift";
            Venoxa.LvL = 1;
            Venoxa.EP = 0;
            Venoxa.HP = 125;
            Venoxa.Basis_HP = 125;
            Venoxa.ATK_leicht = 10;
            Venoxa.ATK_leicht_Name = "Stichbiss";
            Venoxa.ATK_schwer = 24;
            Venoxa.ATK_schwer_Name = "Toxinklaue";
            Venoxa.magical = 29;
            Venoxa.magical_Name = "Giftschleier";
            Venoxa.DEF_Points = 11;
            monsterListe.Add(Venoxa);

            Monster Cryonos = new Monster();
            Cryonos.ID = 18;
            Cryonos.name = "Cryonos";
            Cryonos.Typ = "Eis";
            Cryonos.LvL = 1;
            Cryonos.EP = 0;
            Cryonos.HP = 140;
            Cryonos.Basis_HP = 140;
            Cryonos.ATK_leicht = 12;
            Cryonos.ATK_leicht_Name = "Eisstachel";
            Cryonos.ATK_schwer = 23;
            Cryonos.ATK_schwer_Name = "Kältekern";
            Cryonos.magical = 26;
            Cryonos.magical_Name = "Schneesturm";
            Cryonos.DEF_Points = 13;
            monsterListe.Add(Cryonos);

            Monster Elektros = new Monster();
            Elektros.ID = 19;
            Elektros.name = "Elektros";
            Elektros.Typ = "Elektro";
            Elektros.LvL = 1;
            Elektros.EP = 0;
            Elektros.HP = 150;
            Elektros.Basis_HP = 150;
            Elektros.ATK_leicht = 13;
            Elektros.ATK_leicht_Name = "Zapschlag";
            Elektros.ATK_schwer = 20;
            Elektros.ATK_schwer_Name = "Voltbombe";
            Elektros.magical = 33;
            Elektros.magical_Name = "Ladungsfeld";
            Elektros.DEF_Points = 8;
            monsterListe.Add(Elektros);

            Monster Thornax = new Monster();
            Thornax.ID = 20;
            Thornax.name = "Thornax";
            Thornax.Typ = "Pflanze";
            Thornax.LvL = 1;
            Thornax.EP = 0;
            Thornax.HP = 130;
            Thornax.Basis_HP = 130;
            Thornax.ATK_leicht = 12;
            Thornax.ATK_leicht_Name = "Stachelranke";
            Thornax.ATK_schwer = 26;
            Thornax.ATK_schwer_Name = "Wurzelfalle";
            Thornax.magical = 27;
            Thornax.magical_Name = "Grünfluch";
            Thornax.DEF_Points = 14;
            monsterListe.Add(Thornax);

            #endregion

            #region trainierte Monster_Liste
            List<Monster> trainierte_monster = new List<Monster>();
            #endregion


            ////// Spiel - Start /////

            #region Startbildschirm
            Console.Title = "S.P.L.O.O.T";
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            SchreibeZentriert("\n\n\n\n");
            SchreibeZentriert("Willkommen in der Welt von SPLOOT !\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            warte_auf_enter();
            #endregion

            #region Spiel wird geladen
            Ladebalken_Spielstart(55,35);
            Thread.Sleep(2000);
            #endregion

            #region Wallet-Connection
            Player user = Wallet_Connection();
            Spielerliste.Add(user);
            #endregion

            Thread.Sleep(5000);

        hauptmenü:
            #region Hauptmenü
            bool token_aufladen = false;
            int Menüwahl = Hauptmenü(user);


            switch (Menüwahl)
            {
                case 1: goto modus_1;
                case 2: goto modus_1;
                case 3: token_aufladen =true;   break;
                case 4:
                    Console.Clear();
                    SchreibeZentriert("\n\n\n\n\n\n\n\n\n\n");
                    SchreibeZentriert("Das Spiel wird beendet....");
                    Thread.Sleep(3000);
                    Environment.Exit(0); 
                    break;
                
            }
            #endregion

            #region token aufladen
            if (token_aufladen == true)
            {
                Console.Clear();
                SchreibeZentriert("\n\n\n\n\n\n\n\n\n\n\n");
                for (int i = 0; i < 4; i++)
                {
                    Ladebalken_Transaktion(30, 15);
                }
                Thread.Sleep(1200);
                 int entscheidung = tokenaufladung_menge();

                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

                
                //SchreibeZentriert("\n\n\n\n\n\n\n\n\n\n");
                //for (int i = 0; i < 4; i++)
                //{
                //    Ladebalken_Transaktion(20, 12);
                //}
                //Thread.Sleep(3000);

                switch (entscheidung)
                {
                    case 1:
                        if (user.cash < 5)
                        {
                            SchreibeZentriert("\n\n\n\n\n\n\n\n\n\n");
                            for (int i = 0; i < 4; i++)
                            {
                                Ladebalken_Transaktion(20, 12);
                            }
                            Thread.Sleep(2300);
                            Console.Clear();
                            Console.BackgroundColor= ConsoleColor.Red;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            SchreibeZentriert("\n\n\n\n\n\n\n\n\n\n");
                            SchreibeZentriert("Transaktion fehlgeschalgen !\n\n");
                            SchreibeZentriert("Cash - Balance zu gering");
                            Thread.Sleep(4000);
                            goto hauptmenü;
                        }
                        else
                        {
                            SchreibeZentriert("\n\n\n\n\n\n\n\n\n\n");
                            for (int i = 0; i < 4; i++)
                            {
                                Ladebalken_Transaktion(20, 12);
                            }
                            Thread.Sleep(2300);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Green; 
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            SchreibeZentriert("\n\n\n\n\n\n\n\n\n\n");
                            SchreibeZentriert("Transaktion erfolgreich !\n\n");
                            SchreibeZentriert(" 20 SPLOOT wurden ihren Wallet gutegeschrieben, danke für ihren Einkauf !!");
                            Thread.Sleep(4000);
                            user.Token = user.Token + 20;
                            user.cash = user.cash - 5.0;
                            goto hauptmenü;
                        }

                    case 2:
                        if (user.cash < 12)
                        {
                            SchreibeZentriert("\n\n\n\n\n\n\n\n\n\n");
                            for (int i = 0; i < 4; i++)
                            {
                                Ladebalken_Transaktion(20, 12);
                            }
                            Thread.Sleep(2300);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            SchreibeZentriert("\n\n\n\n\n\n\n\n\n\n");
                            SchreibeZentriert("Transaktion fehlgeschalgen !\n\n");
                            SchreibeZentriert("Cash - Balance zu gering");
                            Thread.Sleep(4000);
                            goto hauptmenü;
                        }
                        else
                        {
                            SchreibeZentriert("\n\n\n\n\n\n\n\n\n\n");
                            for (int i = 0; i < 4; i++)
                            {
                                Ladebalken_Transaktion(20, 12);
                            }
                            Thread.Sleep(2300);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            SchreibeZentriert("\n\n\n\n\n\n\n\n\n\n");
                            SchreibeZentriert("Transaktion erfolgreich !\n\n");
                            SchreibeZentriert(" 60 SPLOOT wurden ihren Wallet gutegeschrieben, danke für ihren Einkauf !!");
                            Thread.Sleep(4000);
                            user.Token = user.Token + 60;
                            user.cash = user.cash - 12.0;
                            goto hauptmenü;
                        }

                    case 3:
                        if (user.cash < 20)
                        {
                            SchreibeZentriert("\n\n\n\n\n\n\n\n\n\n");
                            for (int i = 0; i < 4; i++)
                            {
                                Ladebalken_Transaktion(20, 12);
                            }
                            Thread.Sleep(2300);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            SchreibeZentriert("\n\n\n\n\n\n\n\n\n\n");
                            SchreibeZentriert("Transaktion fehlgeschalgen !\n\n");
                            SchreibeZentriert("Cash - Balance zu gering");
                            Thread.Sleep(4000);
                            goto hauptmenü;
                        }
                        else
                        {
                            SchreibeZentriert("\n\n\n\n\n\n\n\n\n\n");
                            for (int i = 0; i < 4; i++)
                            {
                                Ladebalken_Transaktion(20, 12);
                            }
                            Thread.Sleep(2300);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            SchreibeZentriert("\n\n\n\n\n\n\n\n\n\n");
                            SchreibeZentriert("Transaktion erfolgreich !\n\n");
                            SchreibeZentriert(" 100 SPLOOT wurden ihren Wallet gutegeschrieben, danke für ihren Einkauf !!");
                            Thread.Sleep(4000);
                            user.Token = user.Token + 100;
                            user.cash = user.cash - 20.0;
                            goto hauptmenü;
                        }

                    case 4:

                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor= ConsoleColor.White;
                        Console.Clear();
                        SchreibeZentriert("\n\n\n\n\n\n\n\n\n\n");
                        Ladebalken_Transaktion(70, 10);
             
                        Thread.Sleep(3000);
                        goto hauptmenü;
                }
            }
            #endregion


        modus_1:
            #region Sicherheitsabfrage
            int sicherheitsabfrage = Sicherheitsabfrage(Menüwahl);
            
            switch (sicherheitsabfrage)
            {
                case 1:
                    if (user.Token >= 20)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        SchreibeZentriert("\n\n\n\n\n\n\n\n\n");
                        SchreibeZentriert("Transaktion wird verarbeitet\n\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        for (int i = 0; i < 3; i++)
                        {
                            Ladebalken_Transaktion(50, 20);
                        }
                        Console.ResetColor();
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        SchreibeZentriert("\n\n\n\n\n\n\n\n\n");
                        SchreibeZentriert("Transaktion erfolreich !");
                        user.Token = user.Token - 20;
                        Thread.Sleep(2500);
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        SchreibeZentriert("\n\n\n\n\n\n\n\n\n");
                        SchreibeZentriert("Transaktion wird verarbeitet!\n\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        for (int i = 0; i < 3; i++)
                        {
                            Ladebalken_Transaktion(50, 20);
                        }
                        Console.ResetColor();
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        SchreibeZentriert("\n\n\n\n\n\n\n\n\n");
                        SchreibeZentriert("Transaktion fehlgeschlagen!\n\n");
                        SchreibeZentriert("Nicht genügend SPLOOT - Token im Wallet");
                        
                        Thread.Sleep(2500);
                        goto hauptmenü;
                    }

                    break;

                case 2: Console.Clear();
                    SchreibeZentriert("\n\n\n\n\n\n\n\n\n");
                    SchreibeZentriert("Das Spiel wird beendet....");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                    break;
            }
            #endregion

           
            #region Anzeige aller Monster
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Zeige_alle_Monster(monsterListe);
            #endregion
            

            #region Monsterwahl User / PC
                     
            int vom_user_gewählte_Monster_ID = user_wählt_monster_by_ID(monsterListe);
            var Spielermonster_Vorlage = monsterListe.First(monster => monster.ID == vom_user_gewählte_Monster_ID).Clone();
            Monster Spieler_Monster = new Monster(Spielermonster_Vorlage);
            

            int vom_PC_gewähltes_Monster_ID = PC_Gegner_wählt_ein_Monster(monsterListe);
            Monster PC_Monster = monsterListe.First(monster => monster.ID == vom_PC_gewähltes_Monster_ID).Clone();

            Console.Clear();

            #endregion



            #region Wartebildschirm Arena
            Arena_Wartebildschirm();

            Arena aktuelle_Arena = new Arena();
            Anzeige_der_Arena(aktuelle_Arena, Spieler_Monster, PC_Monster);
            Ladebalken_Arena_und_Wallet(60,300);
            Thread.Sleep(3000);
            Console.Clear();
            #endregion

            #region Startspieler ermitteln
            Würfel start_würfel = new Würfel();
            string Start_Spieler = auswürfeln_des_startspielers(start_würfel);
            Console.Clear();
            #endregion



            #region Kampf

            Würfel Kampf_Würfel = new Würfel();

            Kampf(PC_Monster, Spieler_Monster, aktuelle_Arena, Kampf_Würfel, Start_Spieler, user);

            #endregion


            #region aufleveln

            aufleveln(Spieler_Monster,user,50,50);
            Thread.Sleep(5000);

            #endregion

            trainierte_monster.Add(Spieler_Monster);

            goto hauptmenü;
           

        }


        #region Methoden

        #region Formatierungen
        public static void SchreibeZentriert(string text)
        {
            int breite = Console.WindowWidth;
            int einrueckung = (breite - text.Length) / 2;

            if (einrueckung < 0) einrueckung = 0; // Sicherheit bei zu langem Text

            Console.WriteLine(new string(' ', einrueckung) + text);
        }


        public static void SchreibeZentriert_Ladebalken(string text)
        {
        int leerzeichenLinks = (Console.WindowWidth - text.Length) / 2;
        Console.SetCursorPosition(leerzeichenLinks, Console.CursorTop);
        Console.WriteLine(text);
        }
        #endregion



        #region Alle Ladebalken

        public static void Ladebalken_Spielstart(int länge, int wartezeit_in_Ms)   // Ladebalken Spielstart
        {
            string prefix = "Wird geladen: [";
            string suffix = "]";
            int gesamtBreite = prefix.Length + länge + suffix.Length;

            int fensterBreite = Console.WindowWidth;
            int leerzeichenLinks = (fensterBreite - gesamtBreite) / 2;

            Console.SetCursorPosition(leerzeichenLinks, Console.CursorTop);
            Console.Write(prefix);

            for (int i = 0; i < länge; i++)
            {
                Console.Write("█");
                Thread.Sleep(wartezeit_in_Ms);
            }

            Console.Write(suffix);
        }
        public static void Ladebalken_Transaktion(int länge, int wartezeit_in_Ms)
        {
            string prefix = "[";
            string suffix = "]";
            int gesamtBreite = prefix.Length + länge + suffix.Length;

            int fensterBreite = Console.WindowWidth;
            int leerzeichenLinks = (fensterBreite - gesamtBreite) / 2;

            // Startposition des Ladebalkens im Text
            int startPosX = leerzeichenLinks + prefix.Length;
            int startPosY = Console.CursorTop;

            // Prefix schreiben
            Console.SetCursorPosition(leerzeichenLinks, startPosY);
            Console.Write(prefix);

            // Balken mittig aufbauen
            int mitte = länge / 2;
            for (int step = 0; step <= mitte; step++)
            {
                int links = mitte - step;
                int rechts = mitte + step;

                if (links >= 0)
                {
                    Console.SetCursorPosition(startPosX + links, startPosY);
                    Console.Write("█");
                }
                if (rechts < länge)
                {
                    Console.SetCursorPosition(startPosX + rechts, startPosY);
                    Console.Write("█");
                }
                Thread.Sleep(wartezeit_in_Ms);
            }

            // Suffix schreiben
            Console.SetCursorPosition(startPosX + länge, startPosY);
            Console.Write(suffix);

            Thread.Sleep(300);

            // Balken mittig abbauen
            for (int step = mitte; step >= 0; step--)
            {
                int links = mitte - step;
                int rechts = mitte + step;

                if (links >= 0)
                {
                    Console.SetCursorPosition(startPosX + links, startPosY);
                    Console.Write(" ");
                }
                if (rechts < länge)
                {
                    Console.SetCursorPosition(startPosX + rechts, startPosY);
                    Console.Write(" ");
                }
                Thread.Sleep(wartezeit_in_Ms);
            }
        }  // Ladebalkn für Transaktionen


        public static void Ladebalken_Arena_und_Wallet(int länge, int wartezeit_in_Ms)   // Ladebalken Arena
        {
            string prefix = "[";
            string suffix = "]";
            int gesamtBreite = prefix.Length + länge + suffix.Length;

            int fensterBreite = Console.WindowWidth;
            int leerzeichenLinks = (fensterBreite - gesamtBreite) / 2;

            Console.SetCursorPosition(leerzeichenLinks, Console.CursorTop);
            Console.Write(prefix);

            for (int i = 0; i < länge; i++)
            {
                Console.Write("█");
                Thread.Sleep(wartezeit_in_Ms);
            }

            Console.Write(suffix);
        }


        public static void Ladebalken_XP_EP_Verteilung(int länge, int wartezeit_in_Ms)
        {
            string prefix = "berechne EP / XP: [";
            string suffix = "]";
            int gesamtBreite = prefix.Length + länge + suffix.Length;

            int fensterBreite = Console.WindowWidth;
            int leerzeichenLinks = (fensterBreite - gesamtBreite) / 2;

            Console.SetCursorPosition(leerzeichenLinks, Console.CursorTop);
            Console.Write(prefix);

            for (int i = 0; i < länge; i++)
            {
                Console.Write("▓");
                Thread.Sleep(wartezeit_in_Ms);
            }

            Console.Write(suffix);
        }  // Ladebalken XP / EP am Ende

        public static void Ladebalken_aufleveln_Player(int länge, int wartezeit_in_Ms, Monster Spieler_Monster, Player user)
        {
            string prefix = $"{user.Name} [";
            string suffix = $"]        + {user.XP_Points} XP";
            int gesamtBreite = prefix.Length + länge + suffix.Length;

            int fensterBreite = Console.WindowWidth;
            int leerzeichenLinks = (fensterBreite - gesamtBreite) / 2;

            Console.SetCursorPosition(leerzeichenLinks, Console.CursorTop);
            Console.Write(prefix);

            for (int i = 0; i < länge; i++)
            {
                Console.Write("░");
                Thread.Sleep(wartezeit_in_Ms);
            }

            Console.Write(suffix);
        }  // Ladebalken XP  Player am Ende

        public static void Ladebalken_aufleveln_Monster(int länge, int wartezeit_in_Ms, Monster Spieler_Monster, Player user)
        {
            string prefix = $"{Spieler_Monster.name} [";
            string suffix = $"]        + {Spieler_Monster.EP} EP";
            int gesamtBreite = prefix.Length + länge + suffix.Length;

            int fensterBreite = Console.WindowWidth;
            int leerzeichenLinks = (fensterBreite - gesamtBreite) / 2;

            Console.SetCursorPosition(leerzeichenLinks, Console.CursorTop);
            Console.Write(prefix);

            for (int i = 0; i < länge; i++)
            {
                Console.Write("░");
                Thread.Sleep(wartezeit_in_Ms);
            }

            Console.Write(suffix);
        }  // aufleveln der Monster
        #endregion


        #region Abläufe
        public static void warte_auf_enter(string text = "Drücke ENTER um fortzufahren...")
        {
            Console.CursorVisible = false;

            int x = (Console.WindowWidth - text.Length) / 2;
            int y = Console.WindowHeight / 2;

            bool sichtbar = true;

            while (true)
            {
                // Abbruch nur, wenn ENTER gedrückt wird
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                    break;

                Console.SetCursorPosition(x, y);

                if (sichtbar)
                    Console.Write(text);
                else
                    Console.Write(new string(' ', text.Length));

                sichtbar = !sichtbar;
                Thread.Sleep(500);
            }

            // Nach Eingabe löschen
            Console.SetCursorPosition(x, y);
            Console.Write(new string(' ', text.Length));
            Console.CursorVisible = true;
        }
        public static Player Wallet_Connection()
        {
            #region spieler anlegen
            Console.Clear();
            Player new_user = new Player();
            Console.ForegroundColor = ConsoleColor.White;
            #endregion

            SchreibeZentriert("\n\n");
            SchreibeZentriert("Wallet Verbinden\n\n\n");
            SchreibeZentriert("[1 = JA]       [2 = Nein]\n\n\n");
            Console.Write("                 Entscheidung:     ");
            string entscheidung;
            entscheidung = Console.ReadLine();
            int wahl;
            while (!int.TryParse(entscheidung, out wahl) || wahl < 1 || wahl > 2)
            {
                Console.Clear();
                SchreibeZentriert("\n\n");
                SchreibeZentriert("Wallet Verbinden\n\n\n");
                SchreibeZentriert("[1 = JA]       [2 = Nein]\n\n\n");
                Console.Write("                 Entscheidung:     ");
                entscheidung = Console.ReadLine();
            }
            switch (wahl)
            {
                case 1:
                    #region Tokenmenge / Cash Balance
                    for (int i = 0; i < 2; i++)
                    {

                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        SchreibeZentriert("\n\n\n\n\n\n\n");
                        SchreibeZentriert("Daten werden geladen...");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    for (int i = 0; i < 1; i++)
                    {

                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        SchreibeZentriert("\n\n\n\n\n\n\n");
                        SchreibeZentriert("Wallet wird verknüpft...");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    SchreibeZentriert("\n\n\n\n\n\n\n\n\n\n");
                    Ladebalken_Arena_und_Wallet(50, 50);
                    Thread.Sleep(2000);

                    double min_token = 500.0;
                    double max_token = 10000.0;

                    double min_cash = 15.0;
                    double max_cash = 10000.0;

                    Random token_menge_auswürfeln = new Random();
                    double menge_Sploot_token = token_menge_auswürfeln.NextDouble() * (((((max_token - min_token)/4)* 1.456)+300)/1.2);

                    Random cashmenge_auswürfeln = new Random();
                    double cashmenge = cashmenge_auswürfeln.NextDouble() * (((((max_cash - min_cash)/2.2)*1.666)*0.9)/1.1);

                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    SchreibeZentriert("\n\n\n\n\n\n\n\n\n\n\n");
                    SchreibeZentriert("Verbindung erfolgreich !");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();
                    SchreibeZentriert("\n\n\n\n\n");
                    SchreibeZentriert("Bitte gib deinen Spielernamen an !\n\n");
                    Console.Write("                 Spielername:     ");
                    new_user.Name = Console.ReadLine();
                    while (new_user == null || string.IsNullOrWhiteSpace(new_user.Name))
                    {
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        SchreibeZentriert("\n\n\n\n\n");
                        SchreibeZentriert("Bitte gib deinen Spielernamen an !\n\n");
                        Console.Write("                 Spielername:     ");
                        new_user.Name = Console.ReadLine();
                    }

                    Console.Clear();
                    SchreibeZentriert("\n\n\n\n\n");
                    Ladebalken_Arena_und_Wallet(60, 20);
                    Thread.Sleep(1500);
                    Console.Clear();
                    SchreibeZentriert("\n\n\n\n");
                    SchreibeZentriert("Herzlich Willkommen bei SPLOOT \n\n\n\n");
                    SchreibeZentriert($"Spielername:    {new_user.Name}\n\n");
                    SchreibeZentriert($"[ Sploot-Token: {menge_Sploot_token:F4} SLT ]         [ Cash-Balance: {cashmenge:F2} $ ]");
                    #endregion

                    new_user.Token = menge_Sploot_token;
                    new_user.cash = cashmenge;


                    new_user.XP_Points = 0;
                    break;

                case 2:
                    Console.Clear();
                    SchreibeZentriert("\n\n\n\n");
                    SchreibeZentriert("Verbindung wurde unterbrochen\n\n");
                    SchreibeZentriert("Die Anwendung wird beendet ....");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                    break;
            }

            return new_user;
        }
        public static int Hauptmenü(Player user)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            SchreibeZentriert("\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"   [ Sploot:  {user.Token:F4} SLT ]\n\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"   [ Cash:  {user.cash:F2} $ ]\n\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            SchreibeZentriert("Hauptmenü\n\n\n");
            Console.ResetColor();
            SchreibeZentriert("Bitte wähle eine der folgenden Optionen\n\n");
            SchreibeZentriert($"1.  [ Training gegen PC ]  (Kostet 20 Sploot pro Kampf)\n\n");
            SchreibeZentriert($"2.  [ Kampf gegen einen anderen Spieler ]  (Modus in der aktuellen version noch nicht verfügbar)\n\n");
            SchreibeZentriert($"3.  [ SPLOOT Token aufladen ]");
            SchreibeZentriert("4.   [ Spiel beenden ]\n\n\n");
            Console.Write("       Auswahl:      ");

            string eingabe;
            eingabe = Console.ReadLine();
            int auswahl;
            while (!int.TryParse(eingabe, out auswahl) || auswahl < 1 || auswahl > 4)
            {
                Console.Clear();
                SchreibeZentriert("\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"   [ Sploot:  {user.Token:F4} SLT ]\n\n");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"   [ Cash:  {user.cash:F2} $ ]\n\n");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                SchreibeZentriert("Hauptmenü\n\n\n");
                Console.ResetColor();
                SchreibeZentriert("Bitte wähle eine der folgenden Optionen\n\n");
                SchreibeZentriert($"1.  [ Training gegen PC ]  (Kostet 20 Sploot pro Kampf)\n\n");           
                SchreibeZentriert($"2.  [ Kampf gegen einen anderen Spieler ]  (Modus in der aktuellen version noch nicht verfügbar)\n\n");
                SchreibeZentriert($"3.  [ SPLOOT Token aufladen ]");
                SchreibeZentriert("4.   [ Spiel beenden ]\n\n\n");
                Console.Write("       Auswahl:      ");
                eingabe = Console.ReadLine();
            }

            return auswahl;

        }

        public static int Sicherheitsabfrage(int zahl)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            SchreibeZentriert("\n\n\n\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            SchreibeZentriert("Transaktion bestätigen\n\n\n");
            Console.ResetColor();
            SchreibeZentriert("[1 = Ja]           [2 = Abbrechen]\n\n");

            Console.Write("     Eingabe:      ");
            string EIngabe = Console.ReadLine();
            int ausgabe;
            while (!int.TryParse(EIngabe, out ausgabe) || ausgabe < 1 || ausgabe > 2)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                SchreibeZentriert("\n\n\n\n\n\n\n");
                Console.ForegroundColor = ConsoleColor.Green;
                SchreibeZentriert("Transaktion bestätigen\n\n\n");
                Console.ResetColor();
                SchreibeZentriert("[1 = Ja]           [2 = Abbrechen]\n\n");

                Console.Write("     Eingabe:      ");
                EIngabe = Console.ReadLine();
            }

            return ausgabe;
        }



        public static int tokenaufladung_menge()
        {   
            Console.Clear();
            Console.BackgroundColor= ConsoleColor.Magenta;
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.Clear();
            SchreibeZentriert("\n\n");
            SchreibeZentriert("Willkommen im Shop !\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            SchreibeZentriert("Was möchtest du tun ?\n\n");
            SchreibeZentriert("[ 1 = 20 SPLOOT  ( 5$ ) ]\n\n");
            SchreibeZentriert("[ 2 = 60 SPLOOT  ( 12$ ) ]\n\n");
            SchreibeZentriert("[ 3 = 100 SPLOOT  ( 20 $ ) ]\n\n");
            SchreibeZentriert("[ 4 = Abbrechen und zurpck zum Hauptmenü ]\n\n\n");
            Console.Write("       Auswahl:     ");
            string eingabe;
            eingabe = Console.ReadLine();
            int auswahl;

            while(!int.TryParse(eingabe, out auswahl) || auswahl < 1 || auswahl > 4)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Clear();
                SchreibeZentriert("\n\n");
                SchreibeZentriert("Willkommen im Shop !\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                SchreibeZentriert("Was möchtest du tun ?\n\n");
                SchreibeZentriert("[ 1 = 20 SPLOOT  ( 5$ ) ]\n\n");
                SchreibeZentriert("[ 2 = 60 SPLOOT  ( 12$ ) ]\n\n");
                SchreibeZentriert("[ 3 = 100 SPLOOT  ( 20 $ ) ]\n\n");
                SchreibeZentriert("[ 4 = Abbrechen und zurpck zum Hauptmenü ]\n\n\n");
                Console.Write("       Auswahl:     ");
                eingabe = Console.ReadLine();
            }
      
            return auswahl;
        }






        public static void Zeige_alle_Monster(List<Monster> monsterListe)
        {
            
            Console.Clear();

            // Tabellenkopf mit ID
            string kopf = "ID | Name       | Arena_Typ      | LvL | HP  | ATK leicht | ATK schwer | Magie | DEF";
            string trenner = "---|------------|----------|-----|-----|------------|------------|-------|-----";

            // Zentriert ausgeben
            SchreibeZentriert("Monsterliste\n\n");
            SchreibeZentriert(kopf);
            SchreibeZentriert(trenner);

            foreach (Monster monster in monsterListe)
            {
                string zeile = $"{monster.ID,2} | {monster.name,-10} | {monster.Typ,-8} | {monster.LvL,3} | {monster.HP,3} | {monster.ATK_leicht,10} | {monster.ATK_schwer,10} | {monster.magical,5} | {monster.DEF_Points,3}";
                SchreibeZentriert(zeile);
            }
        }

        public static int user_wählt_monster_by_ID(List<Monster> monsterListe)
        {
            Console.Write("\n");
            Console.ForegroundColor= ConsoleColor.DarkBlue;
            Console.Write("           Wähle anhand der ID:    ");
            Console.ResetColor();
            string auswahl = Console.ReadLine();
            int gewählte_ID;
            while (!int.TryParse(auswahl, out gewählte_ID) || gewählte_ID < 1 || gewählte_ID > 20)
            {

                Zeige_alle_Monster(monsterListe);
                Console.Write("\n");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("           Wähle anhand der ID:    ");
                Console.ResetColor();
                auswahl = Console.ReadLine();

            }
            return gewählte_ID;
        }

        public static int PC_Gegner_wählt_ein_Monster(List<Monster> monsterListe)
        {
            Random monsterwahl = new Random();
            int gewählte_monster_ID = monsterwahl.Next(1,monsterListe.Count+1);

            return gewählte_monster_ID;
        }





        public static void Arena_Wartebildschirm()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n\n\n\n\n\n\n\n\n\n");
            string text = "⌛.....Arena wird für den Kampf vorbereitet .....⌛";
            int consoleWidth = Console.WindowWidth;
            int posX = (consoleWidth - text.Length) / 2;
            int posY = Console.CursorTop;

            DateTime startZeit = DateTime.Now;
            TimeSpan Blink_Dauer = TimeSpan.FromSeconds(7);

            bool sichtbar = true;

            while (DateTime.Now - startZeit < Blink_Dauer)
            {
                Console.SetCursorPosition(posX, posY);
                if (sichtbar)
                {
                    Console.Write(text);
                }
                else
                {
                    Console.Write(new string(' ', 50));
                }

                sichtbar = !sichtbar;
                Thread.Sleep(700);
            }

            // Am Ende dauerhaft anzeigen
            Console.SetCursorPosition(posX, posY);
            Console.WriteLine(text);
        }

        public static void Anzeige_der_Arena(Arena aktuelle_Arena, Monster Spieler_Monster, Monster PC_Monster)
        {
            aktuelle_Arena.Arena_Typ = aktuelle_Arena.wähle_einen_zufälligen_Arena_Typ();

            Berechne_Typ_Bonus(PC_Monster, Spieler_Monster, aktuelle_Arena);


            Console.Clear();
            Console.BackgroundColor = aktuelle_Arena.Hintergrundfarbe_der_Arena;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            if (aktuelle_Arena.Hintergrundfarbe_der_Arena == ConsoleColor.Black)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            SchreibeZentriert("\n");

            SchreibeZentriert($"🏟️ Der Kampf findet in einer: {aktuelle_Arena.Arena_Typ} - Arena statt! 🏟️\n\n");
            SchreibeZentriert($"Alle Monster vom Typ [ {aktuelle_Arena.Arena_Typ} ] erhalten einen Bonus auf Angriff und Verteidigung !\n");

            Console.Write("     Es treten geneinander an:........\n\n");

            SchreibeZentriert($"{Spieler_Monster.name}");
            SchreibeZentriert("-------------------------\n");
            SchreibeZentriert($" HP: {Spieler_Monster.HP}   DEF:  {Spieler_Monster.DEF_Points + aktuelle_Arena.Arena_Buff_Verteidigung_Player}");
            SchreibeZentriert($"Skills: {Spieler_Monster.ATK_leicht_Name}: {Spieler_Monster.ATK_leicht + aktuelle_Arena.Arena_Buff_Angriff_Player}  /  {Spieler_Monster.ATK_schwer_Name}: {Spieler_Monster.ATK_schwer + aktuelle_Arena.Arena_Buff_Angriff_Player}  /  {Spieler_Monster.magical_Name}: {Spieler_Monster.magical + aktuelle_Arena.Arena_Buff_Angriff_Player}");
            SchreibeZentriert($"Typ:  {Spieler_Monster.Typ}\n\n");

            SchreibeZentriert("VS:\n\n");

            SchreibeZentriert($"{PC_Monster.name}");
            SchreibeZentriert("-------------------------\n");
            SchreibeZentriert($" HP: {PC_Monster.HP}   DEF:  {PC_Monster.DEF_Points + aktuelle_Arena.Arena_Buff_Verteidigung_PC}");
            SchreibeZentriert($"Skills: {PC_Monster.ATK_leicht_Name}: {PC_Monster.ATK_leicht + aktuelle_Arena.Arena_Buff_Angriff_PC}  /  {PC_Monster.ATK_schwer_Name}: {PC_Monster.ATK_schwer + aktuelle_Arena.Arena_Buff_Angriff_PC}  /  {PC_Monster.magical_Name}: {PC_Monster.magical + aktuelle_Arena.Arena_Buff_Angriff_PC}");
            SchreibeZentriert($"Typ:  {PC_Monster.Typ}\n\n");
            Console.Write("der Kampf beginnt in kürze:  ");

        }

        public static void Berechne_Typ_Bonus(Monster PC_Monster, Monster Spieler_Monster, Arena aktuelle_Arena)
        {

            if (PC_Monster.Typ == aktuelle_Arena.Arena_Typ)       // PC - Gegner Buff
            {
                aktuelle_Arena.Arena_Buff_Angriff_PC = 4;
                aktuelle_Arena.Arena_Buff_Verteidigung_PC = 5;
            }



            if (Spieler_Monster.Typ == aktuelle_Arena.Arena_Typ)   // Spieler Buff
            {
                aktuelle_Arena.Arena_Buff_Angriff_Player = 4;
                aktuelle_Arena.Arena_Buff_Verteidigung_Player = 5;
            }

        }

        public static string auswürfeln_des_startspielers(Würfel start_würfel)
        {
            int player_wurf, PC_wurf;

            do
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                SchreibeZentriert("\n\n\n\n\n\n\n\n");
                SchreibeZentriert("🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲");
                SchreibeZentriert("🎲                                   🎲");
                SchreibeZentriert("🎲 Der Startspieler wird ermittelt ! 🎲");
                SchreibeZentriert("🎲                                   🎲");
                SchreibeZentriert("🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲");
                SchreibeZentriert("\n\n");
                Thread.Sleep(4500);

                player_wurf = start_würfel.Würfeln();
                PC_wurf = start_würfel.Würfeln();

                SchreibeZentriert($"Spieler hat ein {player_wurf} gewürfelt und der Gegner hat eine {PC_wurf} gewürfelt...");


                if (player_wurf == PC_wurf)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    SchreibeZentriert("\n\n\n\n\n\n\n\n");
                    SchreibeZentriert("🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲");
                    SchreibeZentriert("🎲                                                      🎲");
                    SchreibeZentriert("🎲     🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲    🎲");
                    SchreibeZentriert("🎲   🎲                                           🎲   🎲");
                    SchreibeZentriert("🎲   🎲  Gleichstand,es wird nochmal gewürfelt    🎲   🎲");
                    SchreibeZentriert("🎲   🎲                                           🎲   🎲");
                    SchreibeZentriert("🎲     🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲    🎲");
                    SchreibeZentriert("🎲                                                      🎲");
                    SchreibeZentriert("🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲");

                    Thread.Sleep(2500);
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    SchreibeZentriert("\n\n\n\n\n\n\n\n");
                    SchreibeZentriert("🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲");
                    SchreibeZentriert("🎲                                   🎲");
                    SchreibeZentriert("🎲 Der Startspieler wird ermittelt ! 🎲");
                    SchreibeZentriert("🎲                                   🎲");
                    SchreibeZentriert("🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲🎲");
                    SchreibeZentriert("\n\n\n\n");
                    Thread.Sleep(4500);
                }

            } while (player_wurf == PC_wurf);


            string startspieler;
            if (player_wurf > PC_wurf)
            {
                startspieler = "Der Spieler";
            }
            else
            {
                startspieler = "Der PC-Gegner";
            }
            SchreibeZentriert("\n");
            SchreibeZentriert($"➡️ {startspieler} beginnt den Kampf...!\n");
            Thread.Sleep(2000);

            return startspieler;
        }





        public static void Kampf(Monster PC_Monster, Monster Spieler_Monster, Arena aktuelle_Arena, Würfel Kampf_Würfel, string Start_Spieler, Player user)
        {

            #region startspieler
            bool Player_ist_dran;
            if (Start_Spieler == "Der Spieler")
            {
                Player_ist_dran = true;
            }
            else
            {
                Player_ist_dran = false;
            }
            #endregion

            bool kampfLäuft = true;

            bool player_verteidigt_sich = false;
            bool pc_verteidigt_sich = false;

            int def_buff = 12;
            int orginale_DEF_Punkte_Spieler_Monster = Spieler_Monster.DEF_Points;
            int orginale_DEF_Punkte_PC_Monsters = PC_Monster.DEF_Points;

            int regenerierte_aktionspunkte = 0;
            int maximale_aktionspunkte = 20;
            int x, y;
            
            Spieler_Monster.ATK_leicht = Spieler_Monster.ATK_leicht + aktuelle_Arena.Arena_Buff_Angriff_Player;
            Spieler_Monster.ATK_schwer = Spieler_Monster.ATK_schwer + aktuelle_Arena.Arena_Buff_Angriff_Player;
            Spieler_Monster.magical = Spieler_Monster.magical + aktuelle_Arena.Arena_Buff_Angriff_Player;


            
            PC_Monster.ATK_leicht = PC_Monster.ATK_leicht + aktuelle_Arena.Arena_Buff_Angriff_PC;
            PC_Monster.ATK_schwer = PC_Monster.ATK_schwer + aktuelle_Arena.Arena_Buff_Angriff_PC;
            PC_Monster.magical = PC_Monster.magical + aktuelle_Arena.Arena_Buff_Angriff_PC;


          
            while (kampfLäuft)
            {
                
                Console.BackgroundColor = aktuelle_Arena.Hintergrundfarbe_der_Arena;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                if (aktuelle_Arena.Hintergrundfarbe_der_Arena == ConsoleColor.Black)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                



            turn:
                // Anzeige der aktuellen HP beider Monster
                SchreibeZentriert($"🧿 {Spieler_Monster.name} HP: {Spieler_Monster.HP}            \U0001f9ff {PC_Monster.name} HP: {PC_Monster.HP}\n");
                SchreibeZentriert("--------------------------------------------------------------------------------------------------------------------\n\n\n");
                Thread.Sleep(400);

            
                #region spieler ist dran
                if (Player_ist_dran == true)                   
                {
                             
                    SchreibeZentriert("Wähle einen Angriff\n\n");
                    SchreibeZentriert($"Verfügbare Aktionspunkte: {Spieler_Monster.Aktionspunkte}   DEF :{Spieler_Monster.DEF_Points}\n\n");
                    SchreibeZentriert($" 1. {Spieler_Monster.ATK_leicht_Name}   {Spieler_Monster.ATK_leicht}  Kosten: 3\n\n");
                    SchreibeZentriert($" 2. {Spieler_Monster.ATK_schwer_Name}   {Spieler_Monster.ATK_schwer}  Kosten: 4\n\n");
                    SchreibeZentriert($" 3. {Spieler_Monster.magical_Name}   {Spieler_Monster.magical}  Kosten: 5\n\n");
                    SchreibeZentriert(" 4. Verteidigung stärken und Aktionspunkte regenerieren\n\n");
                    Console.Write("        Angriff mit:     ");

                    string eingabe;
                    int auswahl;
                    eingabe = Console.ReadLine();
                    while (!int.TryParse(eingabe, out auswahl)|| auswahl < 1 || auswahl > 4)
                    {
                       
                        Console.Clear();
                        
                        SchreibeZentriert($"🧿 {Spieler_Monster.name} HP: {Spieler_Monster.HP}            \U0001f9ff {PC_Monster.name} HP: {PC_Monster.HP}\n");
                        SchreibeZentriert("--------------------------------------------------------------------------------------------------------------------\n\n\n");
                        Thread.Sleep(400);

                        SchreibeZentriert("Wähle einen Angriff\n\n");
                        SchreibeZentriert($"Verfügbare Aktionspunkte: {Spieler_Monster.Aktionspunkte}   DEF :{Spieler_Monster.DEF_Points}\n\n");
                        SchreibeZentriert($" 1. {Spieler_Monster.ATK_leicht_Name}   {Spieler_Monster.ATK_leicht}  Kosten: 3\n\n");
                        SchreibeZentriert($" 2. {Spieler_Monster.ATK_schwer_Name}   {Spieler_Monster.ATK_schwer}  Kosten: 4\n\n");
                        SchreibeZentriert($" 3. {Spieler_Monster.magical_Name}   {Spieler_Monster.magical}  Kosten: 5\n\n");
                        SchreibeZentriert(" 4. Verteidigung stärken und Aktionspunkte regenerieren\n\n");
                        Console.Write("        Angriff mit:     ");
                        eingabe = Console.ReadLine();
                    }

                    int Kampfwürfel_Ergebnis = Kampf_Würfel.Würfeln();
                    double würfel_faktor = Kampf_Würfel.treffer_chace(Kampfwürfel_Ergebnis);

                    string Kommentar = "";
                    switch (Kampfwürfel_Ergebnis)
                    {

                        case 1: Kommentar = "Leider Daneben, der Gegner ist ausgewichen ....."; break;
                        case 2: Kommentar = $"{PC_Monster.name} wurde getroffen!"; break;
                        case 3: Kommentar = $"{PC_Monster.name} wurde getroffen!"; break;

                        case 4: Kommentar = $"{PC_Monster.name} wurde getroffen!"; break;
                        case 5: Kommentar = $"{PC_Monster.name} wurde getroffen!"; break;
                        case 6: Kommentar = $"{PC_Monster.name} wurde getroffen!"; break;
                    }

                    double ausgeteilter_schaden = 0.0;

                    switch (auswahl)
                    {
                        case 1:
                            if (Spieler_Monster.Aktionspunkte > 0 && player_verteidigt_sich == false && Spieler_Monster.Aktionspunkte >= 3)
                            {
                                
                                ausgeteilter_schaden = Spieler_Monster.ausgeteilter_leichter_schaden * würfel_faktor;
                                Console.Clear();
                                SchreibeZentriert("\n\n\n\n");
                                SchreibeZentriert($"{Spieler_Monster.name} greift {PC_Monster.name} mit {Spieler_Monster.ATK_leicht_Name} an !\n\n");
                                SchreibeZentriert($"{Kommentar}");
                                Spieler_Monster.Aktionspunkte = Spieler_Monster.Aktionspunkte - 3;
                                
                            }
                            else
                            {
                                Console.Clear();
                                SchreibeZentriert("\n\n\n\n");
                                SchreibeZentriert($"{Spieler_Monster.name} hat nicht mehr genügend Aktionspunkte");
                                Thread.Sleep(1500);
                                Console.Clear();
                                goto turn;
                            }
                                break;
                            
                        case 2:
                            if (Spieler_Monster.Aktionspunkte >= 2 && player_verteidigt_sich == false && Spieler_Monster.Aktionspunkte >= 4)
                            {
                                ausgeteilter_schaden = Spieler_Monster.ausgeteilter_schwerer_schaden * würfel_faktor;
                                Console.Clear();
                                SchreibeZentriert("\n\n\n\n");
                                SchreibeZentriert($"{Spieler_Monster.name} greift {PC_Monster.name} mit {Spieler_Monster.ATK_schwer_Name} an !\n\n");
                                SchreibeZentriert($"{Kommentar}");
                                Spieler_Monster.Aktionspunkte = Spieler_Monster.Aktionspunkte - 4;
                                
                            }
                            else
                            {
                                Console.Clear();
                                SchreibeZentriert("\n\n\n\n");
                                SchreibeZentriert($"{Spieler_Monster.name} hat nicht mehr genügend Aktionspunkte");
                                Thread.Sleep(1500);
                                Console.Clear();
                                goto turn;
                            }
                            break;

                        case 3:
                            if (Spieler_Monster.Aktionspunkte >= 3 && player_verteidigt_sich == false && Spieler_Monster.Aktionspunkte >= 5)
                            {
                                ausgeteilter_schaden = Spieler_Monster.ausgeteilter_magischer_schaden * würfel_faktor;
                                Console.Clear();
                                SchreibeZentriert("\n\n\n\n");
                                SchreibeZentriert($"{Spieler_Monster.name} greift {PC_Monster.name} mit {Spieler_Monster.magical_Name} an !\n\n");
                                SchreibeZentriert($"{Kommentar}");
                                Spieler_Monster.Aktionspunkte = Spieler_Monster.Aktionspunkte - 5;
                                
                            }
                            else
                            {
                                Console.Clear();
                                SchreibeZentriert("\n\n\n\n");
                                SchreibeZentriert($"{Spieler_Monster.name} hat nicht mehr genügend Aktionspunkte");
                                Thread.Sleep(1500);
                                Console.Clear();
                                goto turn;
                            }
                            break;

                        case 4:
                         Console.Clear();
                         player_verteidigt_sich = true;
                         Spieler_Monster.Aktionspunkte = Spieler_Monster.Aktionspunkte + 7;
                         //Spieler_Monster.DEF_Points = Spieler_Monster.DEF_Points + def_buff;
                            SchreibeZentriert("\n\n\n\n");
                         SchreibeZentriert($"{Spieler_Monster.name} weicht zurück und baut seine Verteidigung auf !\n\n");
                            Thread.Sleep(1000);
                            SchreibeZentriert($"Die Verteidigung von {Spieler_Monster.name} hat sich von {Spieler_Monster.DEF_Points + aktuelle_Arena.Arena_Buff_Verteidigung_Player} auf {Spieler_Monster.DEF_Points + aktuelle_Arena.Arena_Buff_Verteidigung_Player + def_buff} erhöht !");
                         ausgeteilter_schaden = 0.0;
                            
                            if(Spieler_Monster.Aktionspunkte > 20)
                            {
                                x = Spieler_Monster.Aktionspunkte - maximale_aktionspunkte;
                                regenerierte_aktionspunkte = 7 - x;
                               Spieler_Monster.Aktionspunkte = maximale_aktionspunkte;
                                SchreibeZentriert($"{Spieler_Monster.name} regeneriert {regenerierte_aktionspunkte} Aktionspunkte");
                            }
                            else
                            {
                                SchreibeZentriert($"{Spieler_Monster.name} regeneriert 7 Aktionspunkte");
                            }
                            

                            break;
                    }

                    int Schaden = Convert.ToInt32(ausgeteilter_schaden);


                    Thread.Sleep(1000);


                    switch (player_verteidigt_sich)
                    {
                        case false:
                            if(pc_verteidigt_sich == true)
                            {
                                PC_Monster.DEF_Points = orginale_DEF_Punkte_PC_Monsters + aktuelle_Arena.Arena_Buff_Verteidigung_PC + def_buff;

                                if (PC_Monster.DEF_Points - Schaden >= 0)
                                {
                                    PC_Monster.HP = PC_Monster.HP;
                                    SchreibeZentriert($"Die Verteidigung von {PC_Monster.name} konnte nicht durchbrochen werden, {PC_Monster.name} verliert keine HP");
                                }
                                if (PC_Monster.DEF_Points - Schaden < 0)
                                {

                                    PC_Monster.HP = PC_Monster.HP + (PC_Monster.DEF_Points - Schaden);
                                    SchreibeZentriert($"Der Angriff war erfolgreich !, {PC_Monster.name} verliert " + Math.Abs(PC_Monster.DEF_Points - Schaden) + " HP Punkte");
                                    
                                }
                            }
                            if(pc_verteidigt_sich==false)
                            {
                                PC_Monster.DEF_Points = orginale_DEF_Punkte_PC_Monsters + aktuelle_Arena.Arena_Buff_Verteidigung_PC;

                                if (PC_Monster.DEF_Points - Schaden >= 0)
                                {
                                    PC_Monster.HP = PC_Monster.HP;
                                    SchreibeZentriert($"Die Verteidigung von {PC_Monster.name} konnte nicht durchbrochen werden, {PC_Monster.name} verliert keine HP");
                                }
                                if (PC_Monster.DEF_Points - Schaden < 0)
                                {

                                    PC_Monster.HP = PC_Monster.HP + (PC_Monster.DEF_Points - Schaden);
                                    SchreibeZentriert($"Der Angriff war erfolgreich !, {PC_Monster.name} verliert " + Math.Abs(PC_Monster.DEF_Points - Schaden) + " HP Punkte");

                                }
                            }
                            break;

                        case true:
                            PC_Monster.HP = PC_Monster.HP - 0;
                            break;
                    }
                    


                }

                pc_verteidigt_sich = false;
                PC_Monster.DEF_Points = orginale_DEF_Punkte_PC_Monsters + aktuelle_Arena.Arena_Buff_Verteidigung_PC;



                if (PC_Monster.HP <= 0)
                {
                    kampfLäuft = false;
                    break;
                }
                else
                {
                    Player_ist_dran = false;
                }
                #endregion

                Thread.Sleep(3000);
                
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////  Seitenwechsel
                
                #region PC-Gegner ist dran
                

                if (Player_ist_dran == false)
                {
                    pc_turn:
                    Console.Clear();
                    SchreibeZentriert($"🧿 {Spieler_Monster.name} HP: {Spieler_Monster.HP}            \U0001f9ff {PC_Monster.name} HP: {PC_Monster.HP}\n");
                    SchreibeZentriert("--------------------------------------------------------------------------------------------------------------------\n\n\n");
                    Thread.Sleep(400);

                    SchreibeZentriert("Der PC - Gegner wählt einen Angriff\n\n");
                    SchreibeZentriert($"Verfügbare Aktionspunkte: {PC_Monster.Aktionspunkte}   DEF :{PC_Monster.DEF_Points}\n\n");
                    SchreibeZentriert($" 1. {PC_Monster.ATK_leicht_Name}   {PC_Monster.ATK_leicht}  Kosten: 3\n\n");
                    SchreibeZentriert($" 2. {PC_Monster.ATK_schwer_Name}   {PC_Monster.ATK_schwer}  Kosten: 4\n\n");
                    SchreibeZentriert($" 3. {PC_Monster.magical_Name}   {PC_Monster.magical}  Kosten: 5\n\n");
                    SchreibeZentriert(" 4. Verteidigung stärken und Aktionspunkte regenerieren\n\n");
                    Thread.Sleep(3000);

                    // der PC wählt jetzt
                    int gewählter_Angriff_PC = 0;

                    Random Gegner_wählt_einen_Angriff = new Random();

                    if (PC_Monster.Aktionspunkte > 3)
                    {
                        gewählter_Angriff_PC = Gegner_wählt_einen_Angriff.Next(1,5);
                    }
                    if (PC_Monster.Aktionspunkte <= 3)
                    {
                        gewählter_Angriff_PC = 4;
                    }



                    int Kampfwürfel_Ergebnis_des_Gegners = Kampf_Würfel.Würfeln();
                    double würfel_faktor_PC_Gegner = Kampf_Würfel.treffer_chace(Kampfwürfel_Ergebnis_des_Gegners);
                    string Kommentar = "";
                    switch (Kampfwürfel_Ergebnis_des_Gegners)
                    {
                        case 1: Kommentar = "Leider Daneben, der Gegner ist ausgewichen ....."; break;
                        case 2: Kommentar = "Leider Daneben, der Gegner ist ausgewichen ....."; break;
                        case 3: Kommentar = "Leider Daneben, der Gegner ist ausgewichen ....."; break;

                        case 4: Kommentar = $"{Spieler_Monster.name} wurde getroffen!"; break;
                        case 5: Kommentar = $"{Spieler_Monster.name} wurde getroffen!"; break;
                        case 6: Kommentar = $"{Spieler_Monster.name} wurde getroffen!"; break;
                    }


                    double ausgeteilter_schaden_PC_Monster = 0.0;

                    switch (gewählter_Angriff_PC)
                    {
                        case 1:
                            if (PC_Monster.Aktionspunkte > 0 && pc_verteidigt_sich == false)
                            {

                                ausgeteilter_schaden_PC_Monster = PC_Monster.ausgeteilter_leichter_schaden * würfel_faktor_PC_Gegner;
                                Console.Clear();
                                SchreibeZentriert("\n\n\n\n");
                                SchreibeZentriert($"{PC_Monster.name} greift {Spieler_Monster.name} mit {PC_Monster.ATK_leicht_Name} an !\n\n");
                                SchreibeZentriert($"{Kommentar}");
                                PC_Monster.Aktionspunkte = PC_Monster.Aktionspunkte - 3;
                            }
                            else
                            {
                                Console.Clear();
                                SchreibeZentriert("\n\n\n\n");
                                SchreibeZentriert($"{PC_Monster.name} hat nicht mehr genügend Aktionspunkte");
                                Thread.Sleep(1500);
                                Console.Clear();
                                goto pc_turn;
                            }
                            break;

                        case 2:
                            if (PC_Monster.Aktionspunkte >= 2 && pc_verteidigt_sich == false)
                            {
                                ausgeteilter_schaden_PC_Monster = PC_Monster.ausgeteilter_schwerer_schaden * würfel_faktor_PC_Gegner;
                                Console.Clear();
                                SchreibeZentriert("\n\n\n\n");
                                SchreibeZentriert($"{PC_Monster.name} greift {Spieler_Monster.name} mit {PC_Monster.ATK_schwer_Name} an !\n\n");
                                SchreibeZentriert($"{Kommentar}");
                                PC_Monster.Aktionspunkte = PC_Monster.Aktionspunkte - 4;
                            }
                            else
                            {
                                Console.Clear();
                                SchreibeZentriert("\n\n\n\n");
                                SchreibeZentriert($"{PC_Monster.name} hat nicht mehr genügend Aktionspunkte");
                                Thread.Sleep(1500);
                                Console.Clear();
                                goto pc_turn;
                            }
                            break;

                        case 3:
                            if (PC_Monster.Aktionspunkte >= 3 && pc_verteidigt_sich == false)
                            {
                                ausgeteilter_schaden_PC_Monster = PC_Monster.ausgeteilter_magischer_schaden * würfel_faktor_PC_Gegner;
                                Console.Clear();
                                SchreibeZentriert("\n\n\n\n");
                                SchreibeZentriert($"{PC_Monster.name} greift {Spieler_Monster.name} mit {PC_Monster.magical_Name} an !\n\n");
                                SchreibeZentriert($"{Kommentar}");
                                PC_Monster.Aktionspunkte = PC_Monster.Aktionspunkte - 5;
                            }
                            else
                            {
                                Console.Clear();
                                SchreibeZentriert("\n\n\n\n");
                                SchreibeZentriert($"{PC_Monster.name} hat nicht mehr genügend Aktionspunkte");
                                Thread.Sleep(1500);
                                Console.Clear();
                                goto pc_turn;
                            }
                            break;

                        case 4:
                            Console.Clear();
                            pc_verteidigt_sich = true;
                            PC_Monster.Aktionspunkte = PC_Monster.Aktionspunkte + 7;
                            //PC_Monster.DEF_Points = PC_Monster.DEF_Points + def_buff;
                            SchreibeZentriert("\n\n\n\n");
                            SchreibeZentriert($"{PC_Monster.name} weicht zurück und baut seine Verteidigung auf !\n\n");
                            ausgeteilter_schaden_PC_Monster = 0.0;
                            Thread.Sleep(1000);
                            SchreibeZentriert($"Die Verteidigung von {PC_Monster.name} hat sich von {PC_Monster.DEF_Points + aktuelle_Arena.Arena_Buff_Verteidigung_PC} auf {PC_Monster.DEF_Points + aktuelle_Arena.Arena_Buff_Verteidigung_PC + def_buff} erhöht !\n");

                            if (PC_Monster.Aktionspunkte > 20)
                            {
                                y = PC_Monster.Aktionspunkte - maximale_aktionspunkte;
                                regenerierte_aktionspunkte = 7 - y;
                                PC_Monster.Aktionspunkte = maximale_aktionspunkte;
                                SchreibeZentriert($"{PC_Monster.name} regeneriert {regenerierte_aktionspunkte} Aktionspunkte");
                            }
                            else
                            {
                                SchreibeZentriert($"{PC_Monster.name} regeneriert 7 Aktionspunkte");
                            }

                            break;


                    }
                    int Schaden_durch_den_Gegner = Convert.ToInt32(ausgeteilter_schaden_PC_Monster);

                    Thread.Sleep(2000);

                    switch (pc_verteidigt_sich)
                    {
                        case false:
                            if (player_verteidigt_sich == true)
                            {
                                Spieler_Monster.DEF_Points = orginale_DEF_Punkte_Spieler_Monster + aktuelle_Arena.Arena_Buff_Verteidigung_Player + def_buff;

                                if (Spieler_Monster.DEF_Points - Schaden_durch_den_Gegner >= 0)
                                {
                                    Spieler_Monster.HP = Spieler_Monster.HP;
                                    SchreibeZentriert($"Die Verteidigung von {Spieler_Monster.name} konnte nicht durchbrochen werden, {Spieler_Monster.name} verliert keine HP");
                                }

                                if (Spieler_Monster.DEF_Points - Schaden_durch_den_Gegner < 0)
                                {

                                    Spieler_Monster.HP = Spieler_Monster.HP + (Spieler_Monster.DEF_Points - Schaden_durch_den_Gegner);
                                    SchreibeZentriert($"Der Angriff war erfolgreich !, {Spieler_Monster.name} verliert " + Math.Abs(Spieler_Monster.DEF_Points - Schaden_durch_den_Gegner) + " HP Punkte");

                                }
                            }
                            if (player_verteidigt_sich == false)
                            {
                                Spieler_Monster.DEF_Points = orginale_DEF_Punkte_Spieler_Monster + aktuelle_Arena.Arena_Buff_Verteidigung_Player;

                                if (Spieler_Monster.DEF_Points - Schaden_durch_den_Gegner >= 0)
                                {
                                    Spieler_Monster.HP = Spieler_Monster.HP;
                                    SchreibeZentriert($"Die Verteidigung von {Spieler_Monster.name} konnte nicht durchbrochen werden, {Spieler_Monster.name} verliert keine HP");
                                }
                                if (Spieler_Monster.DEF_Points - Schaden_durch_den_Gegner < 0)
                                {

                                    Spieler_Monster.HP = Spieler_Monster.HP + (Spieler_Monster.DEF_Points - Schaden_durch_den_Gegner);
                                    SchreibeZentriert($"Der Angriff war erfolgreich !, {Spieler_Monster.name} verliert " + Math.Abs(Spieler_Monster.DEF_Points - Schaden_durch_den_Gegner) + " HP Punkte");

                                }
                            }
                            break;

                        case true:
                            Spieler_Monster.HP = Spieler_Monster.HP - 0;
                            break;
                    }



                }

                player_verteidigt_sich = false;
                
                Spieler_Monster.DEF_Points = orginale_DEF_Punkte_Spieler_Monster + aktuelle_Arena.Arena_Buff_Verteidigung_Player;

                

                if (Spieler_Monster.HP <= 0)
                {
                    
                    kampfLäuft = false;
                    break;
                }
                else
                {
                    Player_ist_dran = true;
                    
                }

                #endregion
                Thread.Sleep(3000);
            }


            /////////////////////  Gewinner Ehrung""""""""""""""""""
           
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            #region siegerehrung
            string Gewinner;
            if (Spieler_Monster.HP > 0)
            {
                SchreibeZentriert("\n\n\n\n");
                Gewinner = Spieler_Monster.name + $" und sein Trainer {user.Name} haben diesen Kampf gewonnen ! 🏆";
                SchreibeZentriert(Gewinner);
                SchreibeZentriert("\n\n");
                Thread.Sleep(300);
                Ladebalken_XP_EP_Verteilung(70, 60);
                Thread.Sleep(300);
                Console.Write("\n\n");
                SchreibeZentriert($"Für diesen Kampf erhälst du 200 EP und 100 XP");
                user.XP_Points = user.XP_Points + 100;
                Spieler_Monster.EP = Spieler_Monster.EP + 200;



            }
            else
            {
                SchreibeZentriert("\n\n\n\n");
                Gewinner = PC_Monster.name + $" und sein Trainer PC haben diesen Kampf gewonnen ! 🏆";
                SchreibeZentriert(Gewinner);
                SchreibeZentriert("\n\n");
                Thread.Sleep(300);
                Ladebalken_XP_EP_Verteilung(70, 60);
                Thread.Sleep(300);
                Console.Write("\n\n");
                SchreibeZentriert($"Für diesen Kampf erhälst du 50 EP und 20 XP");
                user.XP_Points = user.XP_Points + 20;
                Spieler_Monster.EP = Spieler_Monster.EP + 50;


            }
            #endregion

            Spieler_Monster.HP = Spieler_Monster.Basis_HP;
            Spieler_Monster.Aktionspunkte = 20;
            Spieler_Monster.DEF_Points = orginale_DEF_Punkte_Spieler_Monster;

            Spieler_Monster.ATK_leicht -= aktuelle_Arena.Arena_Buff_Angriff_Player;
            Spieler_Monster.ATK_schwer -= aktuelle_Arena.Arena_Buff_Angriff_Player;
            Spieler_Monster.magical -= aktuelle_Arena.Arena_Buff_Angriff_Player;

            PC_Monster.HP = PC_Monster.Basis_HP;
            PC_Monster.Aktionspunkte = 20;
            PC_Monster.DEF_Points = orginale_DEF_Punkte_PC_Monsters;

            Spieler_Monster.ATK_leicht -= aktuelle_Arena.Arena_Buff_Angriff_Player;
            Spieler_Monster.ATK_schwer -= aktuelle_Arena.Arena_Buff_Angriff_Player;
            Spieler_Monster.magical -= aktuelle_Arena.Arena_Buff_Angriff_Player;

            PC_Monster.ATK_leicht -= aktuelle_Arena.Arena_Buff_Angriff_PC;
            PC_Monster.ATK_schwer -= aktuelle_Arena.Arena_Buff_Angriff_PC;
            PC_Monster.magical -= aktuelle_Arena.Arena_Buff_Angriff_PC;


            
        }

        public static void aufleveln(Monster Spieler_Monster, Player user, int länge, int wartezeit_in_Ms)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            SchreibeZentriert("\n\n\n");
            Ladebalken_aufleveln_Player(50, 50, Spieler_Monster, user);
            Console.Write("\n\n");
            Ladebalken_aufleveln_Monster(50, 50, Spieler_Monster, user);

            


        }



        #endregion




        #endregion


    }



}

