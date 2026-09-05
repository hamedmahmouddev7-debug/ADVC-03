using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV03
{
    public static class Leaderboard
    {
        public static void Run()
        {
            Console.WriteLine("=== Leaderboard ===");

            SortedDictionary<int, string> leaderboard =
                new SortedDictionary<int, string>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

            leaderboard.Add(500, "Ahmed");
            leaderboard.Add(200, "Sara");
            leaderboard.Add(800, "Ali");
            leaderboard.Add(350, "Mona");

            Console.WriteLine("Leaderboard (sorted by score):");
            foreach (var entry in leaderboard)
            {
                Console.WriteLine($"{entry.Key} = {entry.Value}");
            }

            var first = leaderboard.First();
            Console.WriteLine($"First Key: {first.Key}, First Value: {first.Value}");

            bool scoreExists = leaderboard.ContainsKey(500);
            Console.WriteLine($"Score 500 Exists: {scoreExists}");

            bool found = leaderboard.TryGetValue(999, out string player999);
            Console.WriteLine($"Score 999 Found: {found}, Player: {(found ? player999 : "N/A")}");

            leaderboard.Remove(200);
            Console.WriteLine("Leaderboard After Removing Score 200:");
            foreach (var entry in leaderboard)
            {
                Console.WriteLine($"{entry.Key} = {entry.Value}");
            }
        }
    }
}
