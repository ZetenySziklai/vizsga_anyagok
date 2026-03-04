using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_12_05_Gyakorlas
{
    class Program
    {
        static string vers1 = "„Vannak vidékek gyönyörű tájak ahol csak keserű lapi tenyészget sanyarú sorsú emberek szomorú szemében alig pislogó mindegyre el-ellobbanó fakó reménység révedez hogy egyszer mégis vége lesz fekete kendők kalapok pergamen arcok alattuk s mint a kezek a térdeken ülnek maguk is félszegen a velük rozzant egy-rokon megszuvasodott padokon ülnek akár egy metszeten mexikóban vagy messzi fenn vancouver jólápolt gyöpén indiánokat láttam én így ülni ilyen révedőn reményt már alig rebbenőn térdükre ejtett két kezük az életünk az életük azért mentem oly messzire belémdöbbenjen mennyire indiánosodik szemünk tekintetük tekintetünk akár egy temetés után telő vasárnap délután”";
        static string vers2 = "„Papsajt közt szerelmeskedő szabóbogarak tarka népe csalogat vissza egy régen nem látott martra. Düledő kerítés alól rajzik hozzám az emlék, érzem a papsajt illatát: hagynék mindent és mennék; Ülnék a kövön gondtalan, a langyos verőfényben s gyönyörködnék a bogarak szerelmi menetében. Nem kötnék papsajttal rakott szekeret már utánuk, és nem mártanám csorduló gyantába sem a lábuk. Csak nézném átellenben az égig érő erdőt, s nem bánnám, ha már nem lehet belőlem többé felnőtt.”";

        static string abc = "áéíóöőúüűÁÉÍÓÖŐÚÜŰabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ ";

        static void Main(string[] args)
        {
            /*Console.WriteLine(vers2);
            Console.WriteLine();
            Console.WriteLine(CsakBetuk(vers2));*/
            Feladat2();
            Console.ReadLine();
        }

        static void Feladat2()
        {
            /*int db = SzokozokSzama(vers1);
            string[] szavak1 = new string[db+1];
            Szokigyujt(CsakBetuk(vers1), szavak1);*/

            string szurtVers1 = CsakBetuk(vers1);
            string[] szavak1 = szurtVers1.Split(' ');
            string szurtVers2 = CsakBetuk(vers2);
            string[] szavak2 = szurtVers2.Split(' ');
            Metszet(szavak1, szavak2);
            
        }

        static void Metszet(string[] sz1, string[] sz2)
        {
            string[] metszet;
            if (sz1.Length > sz2.Length)
                metszet = new string[sz2.Length];
            else
                metszet = new string[sz1.Length];

            int k = 0;
            for (int i = 0; i < sz1.Length; i++)
            {
                if (BenneVanE(sz2, sz1[i]))
                {
                    metszet[k] = sz1[i];
                    k++;
                }
            }
        }

        static bool BenneVanE(string[] tomb, string sz)
        {
            int i = 0;
            while (i < tomb.Length && tomb[i] != sz)
                i++;
            return i < tomb.Length;
        }

        static void Szokigyujt(string szoveg, string[] tomb)
        {
            string szo = "";
            int k = 0;
            for (int i = 0; i < szoveg.Length; i++)
            {
                if (szoveg[i] != ' ')
                {
                    szo += szoveg[i];
                }
                else
                {
                    tomb[k] = szo;
                    k++;
                    szo = "";
                }
            }
        }

        static int SzokozokSzama(string szoveg)
        {
            int db = 0;
            for (int i = 0; i < szoveg.Length; i++)
            {
                if (szoveg[i] == ' ')
                    db++;
            }
            return db;
        }

        static string CsakBetuk(string szoveg)
        {
            string ki = "";
            for (int i = 0; i < szoveg.Length; i++)
            {
                if (JoKarakter(szoveg[i]))                
                    ki += szoveg[i];
            }
            return ki;
        }

        static bool JoKarakter(char c)
        {
            int i = 0;
            while (i < abc.Length && c != abc[i])
                i++;
            return i < abc.Length;            
        }
    }
}
