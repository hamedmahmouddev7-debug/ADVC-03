using System;
using System.Collections.Generic;
using System.Linq;

namespace ADV03
{
     class Program
    {
        static void Main(string[] args)
        {


            #region Exercise01 

            //StudentGradeManager.Run();
            //Console.WriteLine("***************************************************");
            #endregion

            #region Exercise02
            //Leaderboard.Run();
            //Console.WriteLine("***************************************************");

            #endregion

            #region Exercise03
            //PhoneBook.Run();
            //Console.WriteLine("***************************************************");
            #endregion

            #region Exercise04
            //UniqueEmailValidator.Run();
            #endregion

            #region Part02:Search
            /*
             * 1. Generic Collection
               => A Generic Collection is a collection that stores elements of a specific data type using generics such as <T>. It provides type safety and avoids unnecessary casting.

             * 2. Span<T>
              => Span<T> is a type-safe and memory-safe way to represent a contiguous region of memory. It can be used to work efficiently with arrays or parts of arrays.
             
             *3. sortedList<TKey, TValue>
              => SortedList<TKey, TValue> stores key-value pairs sorted by their keys. It allows accessing elements using their keys and also supports indexed access through its Keys and Values collections
            
            * 4. SortedDictionary<TKey, TValue>
             =>  sortedDictionary<TKey, TValue> stores key-value pairs sorted by key. It is implemented as a binary search tree and provides O(log n) retrieval.


             * 
             ******************************************************************************************************
             *  Type                            الفكرة                                                  

           Generic Collection** => Collections تستخدم Generics زي `List<T>`                
           Span<T>**            => التعامل مع جزء من الذاكرة بكفاءة                        
           SortedList**         => Key/Value مرتبة حسب الـ Key، وتستخدم Array داخليًا      
           SortedDictionary**   => Key/Value مرتبة حسب الـ Key، وتستخدم Binary Search Tree 

             * */
            #endregion
        }
    }
}
