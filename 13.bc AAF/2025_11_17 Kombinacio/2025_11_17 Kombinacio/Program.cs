using System.Drawing;

namespace _2025_11_17_Kombinacio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // {1,2,3,4,5}
            // Mik azok a kombinációk, ahol az összeg, pl 5.
            // {1,4} {2,3} {5}

            KombinacioOsszeg kbo = new KombinacioOsszeg(7);
            kbo.Run();

            // Sakk-huszár:
            //Keressünk egy olyan huszárugrás-sorozatot, amely minden egyes pontot érint a sakktáblán pontosan egyszer, és ugyan oda tér vissza, ahonnan indult.
        }
    }
}
