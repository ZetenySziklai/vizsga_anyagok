using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_06_FutoversenyProjekt
{
    public class Program
    {
        static void Main(string[] args)
        {
            Versenyzo v = new Versenyzo("12d", "Béla", true);
            Console.WriteLine(v);
            Versenytipus vt = new Versenytipus("123kl", 100, new DateTime(2025, 02, 06));
            Console.WriteLine(vt);
            Versenytipus vt2 = new Versenytipus("987hv", 20000, new DateTime(2025, 02, 07));
            Console.WriteLine(vt2);
            Szervezo sz = new Szervezo();
            Futas f = new Futas("01:20:15", "01:28:05");
            Futas f2 = new Futas("01:20:15", "02:15:05");
            
            //sz.EredmenyMentese(vt, v, f);
            //if(v.VersenyzoEredmenye(vt, f)) Console.WriteLine("Felvettük az új eredményt.");
            //else Console.WriteLine("Már adminisztrálva van.");

            v.VersenyzoEredmenye(vt, f);
            if (sz.EredmenyMentese(vt, v, f)) Console.WriteLine("Felvettük az új eredményt.");
            else Console.WriteLine("Már adminisztrálva van.");

            sz.EredmenyMentese(vt2, v, f2);

            Console.WriteLine(v.HanyVersenyenvolt());
            Console.WriteLine(v.LegjobbEredmeny());



            //Futas futas = new Futas();
            //futas.Kezdes = "01:20:15";
            //futas.Befejezes = "02:15:05";
            //(int k, int b) = futas.TeljesitmenyPercSec();
            //Console.WriteLine(k+" "+b);

            //Dictionary< string,int> konyvtar = new Dictionary< string,int>();
            //konyvtar.Add( "alma",100);
            //konyvtar.Add("körte",2564 );
            //konyvtar.Add("szilva",242 );

            //Console.WriteLine(konyvtar["alma"]);
            //konyvtar["alma"] = 1001;
            //Console.WriteLine(konyvtar["alma"]);
            //List<KeyValuePair<string, int>> valami = konyvtar.ToList();
            //Console.WriteLine(valami[0].Key +" " + valami[0].Value);





            Console.ReadLine();
        }
    }
}
