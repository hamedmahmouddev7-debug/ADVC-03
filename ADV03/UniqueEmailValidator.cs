using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV03
{
    //public static class UniqueEmailValidator
    //{
    //    public static void Run()
    //    {
    //        Console.WriteLine("=== Unique Email Validator ===");

    //        HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

    //        emails.Add("ahmed@test.com");
    //        emails.Add("AHMED@test.com");
    //        emails.Add("sara@test.com");
    //        emails.Add("Sara@Test.Com");

    //        Console.WriteLine($"Email Count: {emails.Count}");
    //        Console.WriteLine("Only 2 emails are stored because the HashSet uses a case-insensitive");
    //        Console.WriteLine("comparer, so 'ahmed@test.com'/'AHMED@test.com' are treated as the same");
    //        Console.WriteLine("value, and 'sara@test.com'/'Sara@Test.Com' are treated as the same value.");
    //        Console.WriteLine(); HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
    //        HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

    //        HashSet<int> unionSet = new HashSet<int>(setA);
    //        unionSet.UnionWith(setB);
    //        Console.WriteLine("UnionWith: " + string.Join(", ", unionSet.OrderBy(x => x)));

    //        HashSet<int> intersectSet = new HashSet<int>(setA);
    //        intersectSet.IntersectWith(setB);
    //        Console.WriteLine("IntersectWith: " + string.Join(", ", intersectSet.OrderBy(x => x)));

    //        HashSet<int> exceptSet = new HashSet<int>(setA);
    //        exceptSet.ExceptWith(setB);
    //        Console.WriteLine("ExceptWith: " + string.Join(", ", exceptSet.OrderBy(x => x)));

    //        HashSet<int> subsetCheck = new HashSet<int> { 1, 2 };
    //        bool isSubset = subsetCheck.IsSubsetOf(setA);
    //        Console.WriteLine($"{{1,2}} Is Subset Of Set A: {isSubset}");
    //    }
    //}
}
