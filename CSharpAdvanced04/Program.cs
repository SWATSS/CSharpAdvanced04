using System.Collections;

namespace CSharpAdvanced04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Given an array of integers, count the frequency of each element using a hash table.
            //int[] arr = { 1, 2, 2, 3, 1, 4, 2, 3, 3 };
            //Hashtable numFreq = new Hashtable();

            //foreach (int i in arr)
            //{
            //    if (numFreq.ContainsKey(i))
            //    {
            //        numFreq[i] = (int)numFreq[i] + 1;
            //    }
            //    else numFreq[i] = 1;
            //}
            //foreach (DictionaryEntry entry in numFreq)
            //{
            //    //Console.WriteLine(entry.Key);
            //    Console.WriteLine($"[Key: {entry.Key} , Value: {entry.Value}]");
            //} 
            #endregion

            #region 2. You have a hashtable where its values are integers, find the key associated with the highest value.
            //Hashtable hashtable = new Hashtable()
            //{
            //    { "Ahmed", 85 },
            //    { "Sara", 92 },
            //    { "Omar", 78 },
            //    { "Laila", 95 },
            //    { "Hassan", 88 }
            //};
            //string highst = "";
            //int max = 0;
            //foreach (DictionaryEntry entry in hashtable)
            //{
            //    if ((int)entry.Value >= max)
            //    {
            //        max = (int)entry.Value;
            //        highst = (string)entry.Key;
            //    }
            //}
            //Console.WriteLine($"The Highst Value is [{highst}] with [{max}]"); 
            #endregion

            #region 3. You have a hashtable , the  user will enter targetValue find all keys that associated with a specific targetValue Note : if the targetValue not found print(“Key not found”)
            //Hashtable ht = new Hashtable()
            //{
            //    { "key1", "apple" },
            //    { "key2", "banana" },
            //    { "key3", "apple" }
            //};

            //Console.Write("Please Enter Target Value To Search: ");
            //string targetValue = Console.ReadLine().ToLower().Replace(" ", "");
            //foreach (DictionaryEntry entry in ht)
            //{
            //    if (entry.Value.ToString() == targetValue)
            //        Console.WriteLine(entry.Key);
            //} 
            #endregion



            #region 4. Given an array of strings, group anagrams together.
            //string[] words = { "eat", "tea", "tan", "ate", "nat", "bat" };

            //Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

            //foreach (string word in words)
            //{
            //    char[] letters = word.ToCharArray();

            //    Array.Sort(letters);

            //    string sorted = new string(letters);

            //    if (!anagrams.ContainsKey(sorted))
            //    {
            //        anagrams[sorted] = new List<string>();
            //    }

            //    anagrams[sorted].Add(word);
            //}

            //foreach (var group in anagrams.Values)
            //{
            //    Console.WriteLine($"[{string.Join(", ", group)}]");
            //} 
            #endregion

            #region 5. Given an array of integers, check if the array contains any duplicates.
            int[] nums1 = { 1, 2, 3, 1, 5 };
            Hashtable EXIST = new Hashtable();
            foreach (int i in nums1)
            {
                if (EXIST.ContainsKey(i))
                {
                    Console.WriteLine("Arry Has Dublicated Items");
                    break;
                }
                else EXIST[i] = 1;
            } 
            #endregion
        }
    }
}
