namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> videoGames = new List<String>
            {"Minecraft", "Fifa", "Fortnite", "Halo", "Overwatch" };

            IEnumerable<String> videoGameNames = videoGames.OrderBy(x => x.Length);
              
            foreach(String game in videoGameNames)
            {
                Console.WriteLine(game);
            }
        }
    }
}