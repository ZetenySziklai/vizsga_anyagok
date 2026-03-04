namespace RobotDoga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AllapotTerSzelessegi at = new AllapotTerSzelessegi();
            at.Megoldas().ForEach(Console.WriteLine);
        }
    }
}
