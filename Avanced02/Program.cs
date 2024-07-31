using System.Collections;

namespace Avanced02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part1
            #region Generic
            #region Array
            //int[] numbers = { 1, 2, 3 };
            //Console.WriteLine(numbers[0]); 

            #endregion
            #region List
            //List<int> numbers = new List<int> { 1, 2, 3 };
            //numbers.Add(4); 
            //Console.WriteLine(numbers[1]); 

            #endregion
            #region dictionary
            //Dictionary<string, int> ageDict = new Dictionary<string, int>();
            //ageDict.Add("Alice", 30);
            //Console.WriteLine(ageDict["Alice"]); 

            #endregion
            #region HashSet
            //HashSet<int> uniqueNumbers = new HashSet<int> { 1, 2, 3 };
            //uniqueNumbers.Add(2); // No effect, as 2 is already present
            //Console.WriteLine(uniqueNumbers.Count); 
            #endregion
            #region Queue
            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("First");
            //queue.Enqueue("Second");
            //Console.WriteLine(queue.Dequeue()); 

            #endregion
            #region Stack
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //Console.WriteLine(stack.Pop()); 

            #endregion
            #endregion
            #region non_Generic
            #region ArrayList
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add("Hello");
            //arrayList.Add(3.14);

            //Console.WriteLine("First element: " + arrayList[0]);
            //Console.WriteLine("Second element: " + arrayList[1]); 
            #endregion
            #region HashTable
            //Hashtable hashtable = new Hashtable();
            //hashtable.Add("Alice", 30);
            //hashtable.Add("Bob", 25);
            //hashtable.Add("Charlie", 35);

            //Console.WriteLine("Alice's age: " + hashtable["Alice"]); 
            #endregion
            #endregion
            #endregion
            #region part2
            #region Q1
            //ArrayList arrayList = new ArrayList { 1, "r", true, 2, 3, 4, 5, };
            //Class1.reverse(ref arrayList);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q2
            //List<int> list ;
            //list = Enumerable.Range(0, 10).ToList();
            //List<int> result=Class1.EvenNum(list);
            //foreach (var item in result) 
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q3
            //FixedSizeList<int> fixedSizeList = new FixedSizeList<int>(5);
            //fixedSizeList.Add(1);
            //fixedSizeList.Add(2);
            //fixedSizeList.Add(3);
            //fixedSizeList.Add(4);
            //fixedSizeList.Add(5);
            //fixedSizeList.Add(6);//out of range exception
            //Console.WriteLine(fixedSizeList.GetValue(0));
            //Console.WriteLine(fixedSizeList.GetValue(5));//index exception
            #endregion
            #region Q4
            //string str = "mmddp";
            //Console.WriteLine(Class1.nonReapeted(str));
            #endregion
            #endregion
        }
    }
}
