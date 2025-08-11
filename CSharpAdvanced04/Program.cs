using System.Collections;

namespace CSharpAdvanced04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Given an array of integers, count the frequency of each element using a hash table.
            int[] arr = { 1, 2, 2, 3, 1, 4, 2, 3, 3 };
            Hashtable numFreq = new Hashtable();

            foreach (int i in arr)
            {
                if (numFreq.ContainsKey(i))
                {
                    numFreq[i] = (int)numFreq[i] + 1;
                }
                else numFreq[i] = 1;
            }
            foreach (DictionaryEntry entry in numFreq)
            {
                //Console.WriteLine(entry.Key);
                Console.WriteLine($"[Key: {entry.Key} , Value: {entry.Value}]");
            } 
            #endregion
        }
    }
}
