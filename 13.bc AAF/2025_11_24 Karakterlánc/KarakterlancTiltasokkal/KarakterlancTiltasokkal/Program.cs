namespace KarakterlancTiltasokkal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SzovegGeneralas szg = new SzovegGeneralas(new char[] { 'A', 'B', 'C', 'D' }, 6);
            szg.Run();
            foreach(string sz in szg.megoldasok)
                Console.WriteLine(sz);
        }
    }
}
