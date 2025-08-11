using System.Collections;

namespace CSharpAdvanced04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Given an array of integers, count the frequency of each element using a hash table.
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

            #region You have a hashtable where its values are integers, find the key associated with the highest value.
            Hashtable hashtable = new Hashtable()
            {
                { "Ahmed", 85 },
                { "Sara", 92 },
                { "Omar", 78 },
                { "Laila", 95 },
                { "Hassan", 88 }
            };
            string highst = "";
            int max = 0;
            foreach (DictionaryEntry entry in hashtable)
            {
                if ((int)entry.Value >= max)
                {
                    max = (int)entry.Value;
                    highst = (string)entry.Key;
                }
            }
            Console.WriteLine($"The Highst Value is [{highst}] with [{max}]"); 
            #endregion

        }
    }
}
