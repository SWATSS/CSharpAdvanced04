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
            //int[] nums1 = { 1, 2, 3, 1, 5 };
            //Hashtable EXIST = new Hashtable();
            //foreach (int i in nums1)
            //{
            //    if (EXIST.ContainsKey(i))
            //    {
            //        Console.WriteLine("Arry Has Dublicated Items");
            //        break;
            //    }
            //    else EXIST[i] = 1;
            //} 
            #endregion

            #region 6. Implement a SortedDictionary that stores student IDs (int) and their names (string). Perform operations like adding, removing, and retrieving student names.
            //SortedDictionary<int, string> students = new SortedDictionary<int, string>()
            //{
            //    {103, "Ahmed Taleb"},
            //    {104, "Sead Mohamed"},
            //    {101, "Sara Khaled"},
            //    {102, "Sara Khaled"},
            //};

            //foreach (var student in students)
            //{
            //    Console.WriteLine($"Student with Id: [{student.Key}] is {student.Value}");
            //}
            //Console.WriteLine("Do You Want To Add A Student  Y / N");
            //string add = Console.ReadLine().ToLower().Replace(" ", "");
            //Console.Clear();

            //if (add == "y")
            //{
            //    Console.Write("Student Id: ");
            //    int.TryParse(Console.ReadLine(), out int key);
            //    Console.Write("Student Name: ");
            //    string value = Console.ReadLine();
            //    students[key] = value;
            //    Console.WriteLine($"Student with Id: [{key}] is {value}");
            //}


            //Console.WriteLine("=============================================");

            //Console.WriteLine("Do You Want To Delete A Student  Y / N");
            //string remove = Console.ReadLine().ToLower().Replace(" ", "");
            //Console.Clear();
            //if (remove == "y")
            //{
            //    Console.Write("Student Id: ");
            //    int.TryParse(Console.ReadLine(), out int key);
            //    students.Remove(key);
            //    Console.WriteLine($"Student with Id: [{key}] is Successfully Deleted");
            //}

            //Console.WriteLine("=============================================");

            //Console.WriteLine("Enter Id Student To Retrieve: ");
            //int.TryParse(Console.ReadLine(), out int rKey);
            //Console.Clear();

            //if (students.ContainsKey(rKey))
            //{
            //    Console.WriteLine($"Student with Id: [{rKey}] is [{students[rKey]}]");
            //}
            //else Console.WriteLine("Theres No Student With Thats Id :("); 
            #endregion

            #region 7. Create an employee directory where employee IDs (int) are keys and employee names (string) are values. Use a SortedList to manage and retrieve employees in order of their IDs.
            //SortedList<int, string> employees = new SortedList<int, string>()
            //{
            //    { 103, "Ahmed Taleb"},
            //    { 104, "Sead Mohamed"},
            //    { 101, "Sara Khaled"},
            //    { 102, "Sara Khaled"}
            //};
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine($"employee with Id: [{employee.Key}] is {employee.Value}");
            //}
            //Console.WriteLine("Do You Want To Add A Employee  Y / N");
            //string add = Console.ReadLine().ToLower().Replace(" ", "");
            //Console.Clear();

            //if (add == "y")
            //{
            //    int key;
            //    while (true)
            //    {
            //        Console.Write("Employee Id: ");
            //        int.TryParse(Console.ReadLine(), out key);
            //        if (employees.ContainsKey(key)) Console.WriteLine("This Id already exists! Use another Id.");
            //        else break;
            //    }
            //    Console.Write("Employee Name: ");
            //    string value = Console.ReadLine();
            //    employees[key] = value;
            //    Console.WriteLine($"Employee with Id: [{key}] is {value}");
            //}


            //Console.WriteLine("=============================================");

            //Console.WriteLine("Do You Want To Delete A Employee  Y / N");
            //string remove = Console.ReadLine().ToLower().Replace(" ", "");
            //Console.Clear();
            //if (remove == "y")
            //{
            //    Console.Write("Employee Id: ");
            //    int.TryParse(Console.ReadLine(), out int key);
            //    if (employees.ContainsKey(key))
            //    {
            //        employees.Remove(key);
            //        Console.WriteLine($"Employee with Id: [{key}] is Successfully Deleted");
            //    }
            //    else Console.WriteLine("There's No Employee With That Id");
            //}

            //Console.WriteLine("=============================================");
            //Console.WriteLine("Do You Want To Delete A Employee  Y / N");
            //string retrieve = Console.ReadLine().ToLower().Replace(" ", "");
            //Console.Clear();
            //if (retrieve == "y")
            //{
            //    Console.WriteLine("Enter Id Employee To Retrieve: ");
            //    int.TryParse(Console.ReadLine(), out int rKey);
            //    Console.Clear();

            //    if (employees.ContainsKey(rKey))
            //    {
            //        Console.WriteLine($"Employee with Id: [{rKey}] is [{employees[rKey]}]");
            //    }
            //    else Console.WriteLine("Theres No Employee With Thats Id :(");

            //} 
            #endregion

            #region 8. Given an array of integers from 1 to N with some numbers missing, find the missing numbers.
            //int N = 9;
            //int[] numbers = { 1, 2, 4, 6, 7 };
            //HashSet<int> hashtable = new(numbers);

            //List<int> missing = new List<int>();
            //for (int i = 1; i < N; i++)
            //{
            //    if (!hashtable.Contains(i))
            //        missing.Add(i);
            //}
            //Console.WriteLine("Missing Numbers is: ");
            //foreach (int i in missing)
            //    Console.Write(i + ","); 
            #endregion

            #region 9. You  have a list of integers with possible duplicates, create a HashSet that contains only unique values.
            //List<int> numbers = new List<int> { 1, 2, 3, 2, 4, 5, 1, 3, 6 };

            //HashSet<int> uniqueNumbers = new(numbers);

            //Console.WriteLine("Unique numbers: ");
            //foreach (int num in uniqueNumbers)
            //{
            //    Console.WriteLine(num);
            //} 
            #endregion

            #region 10. You have a hashtable with unique values, create a new hashtable where the keys and values are swapped.
            //Hashtable names = new Hashtable()
            //{
            //    { 100, "Ahmed" },
            //    { 200, "Sara" },
            //    { 300, "Omar" }
            //};

            //Hashtable swapped = new Hashtable();

            //foreach (DictionaryEntry entry in names)
            //{
            //    swapped[entry.Value] = entry.Key;
            //}

            //foreach (DictionaryEntry entry in swapped)
            //{
            //    Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            //}
            #endregion

            #region 11. Find the union of two sets, returning the unique elements from both sets.
            //HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4 };
            //HashSet<int> set2 = new HashSet<int>() { 3, 4, 5, 6 };

            //set1.UnionWith(set2);

            //Console.WriteLine("Union of both sets:");
            //foreach (var item in set1)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion

            #region 12. You have a dictionary with string keys, the user will enter targetChar , count how many keys start with this targetChar.
            //Dictionary<string, int> dict = new Dictionary<string, int>()
            //{
            //    { "apple", 1 },
            //    { "animal", 2 },
            //    { "airport", 3 },
            //    { "banana", 4 }
            //};

            //Console.Write("Enter target char: ");
            //char targetChar = Console.ReadLine()[0];

            //int count = 0;

            //foreach (var key in dict.Keys)
            //{
            //    if (key.StartsWith(targetChar.ToString(), StringComparison.OrdinalIgnoreCase))
            //        count++;
            //}

            //Console.WriteLine($"Number of keys starting with '{targetChar}': {count}");
            #endregion

            #region 13.You have a sorted set , user will enter an integer target, find all elements that is greater than target and add them in list.
            //SortedSet<int> numbers = new SortedSet<int>() { 2, 5, 8, 10, 15, 20 };

            //Console.Write("Enter Target: ");
            //int target = int.Parse(Console.ReadLine());

            //List<int> greaterList = new List<int>();

            //foreach (var num in numbers)
            //{
            //    if (num > target)
            //    {
            //        greaterList.Add(num);
            //    }
            //}

            //Console.WriteLine("Numbers Greater than Target:");
            //foreach (var num in greaterList)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion

            #region 14. You have a sorted list with integer values, find all the keys associated with even values.
            //SortedList<string, int> sortedList = new()
            //{
            //    {"A", 5},
            //    {"B", 8},
            //    {"C", 12},
            //    {"D", 7},
            //    {"E", 20}
            //};

            //List<string> evenValueKeys = new();

            //foreach (var item in sortedList)
            //{
            //    if (item.Value % 2 == 0)
            //    {
            //        evenValueKeys.Add(item.Key);
            //    }
            //}

            //Console.WriteLine("Keys With Even Values:");
            //foreach (var key in evenValueKeys)
            //{
            //    Console.WriteLine(key);
            //}
            #endregion
        }
    }
}
