using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2024_10_10_09_Oroklodes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Utodosztaly ut = new Utodosztaly(543, 654);
            //ut.b = 543;
            Console.WriteLine(ut.ToString());


            Console.ReadLine();


        }
    }

    class Ososztaly {

        //Mezők
        public int x;
        protected int y;

        //Konstruktor
        public Ososztaly(int x, int y) {
            this.x = x;
        }


        //Metódusok
        public void TobbszorozX(int a) {
            x *= a;
        }

        public override string ToString() { 
            return "x = "+x;
        }
    }

    class Utodosztaly : Ososztaly {
        //Mezők
        public int b;

        //Konstruktor
        public Utodosztaly(int b, int x) : base(x,45)
        {
            this.b = b;
        }

        //Metódusok
        public void TobbszorozB(int k) {
            b *= k;
        }

        public override string ToString() { 
            return "b = "+ b+"\tx = "+x+"\ty = "+y;
        }
    }

    class Osztaly {
        public void Lathatosag()
        {
            //Utodosztaly u = new Utodosztaly();
            //u.y; - nem elérhető, csak öröklődéssel

        }
    }

}
