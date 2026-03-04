using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_09_19_Gyakorlas
{
    internal class Program
    {
        List<string> nevek = new List<string>() {
            "Farkas Máté",
            "Deák Zsombor",
            "Kakuk Ákos",
            "Kis Levente",
            "Varga Csaba",
            "Pálinkás Zoltán",
            "Détári Viktória",
            "Gebhardt Lilla",
            "Sebella Máté",
            "Zsidákovits Bálint",
            "Szabó Dániel"
        };

        static void Main(string[] args)
        {
            /* Hozzon létre egy struktúrát, amiben eltárolja a csoport neveit és mindenknek generál egy 18 számjegyből álló kódot! Ezektet a példányosítás során, adja is át!
             * A struktúrában legyenek a további mezők is:
             * Magasság, szemuveges, azonosító, jelszó.
             * A példányosítás során fusson le egy véletlen generálás, ami megadja a súlyt [50,80] között. Illetve véletlen szerűen állítsa be, hogy szemüveges-e az illető.
             * Majd ugyen itt a példány elkészülése során, fusson le a struktúrában elkészített két függvény, az egyik eredménye az azonosító a másik a jelszó!
             * Azonosító: minden páratlanadik karakter kis betűvel, szóköz nélkül! és a kód számjegyeinek összege majd @ckik.hu!
             * Jelszó: A kód kettesével vett értékének asci kódjából előállított betű! Ha 32-nél kisebb az érték, adjon hozzá 50-et!
             * CSináljon ToString metódust!*/
        }
    }
}
