using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Binary_Search
{
        class BinarySearch<T>
        {
         T[] array;
         T SearchVar;
      

        public BinarySearch() { }
        public BinarySearch(T[] inputArray, T inputSearchVar)
            {
               array = inputArray;
               SearchVar = inputSearchVar;
            }
        public void set(T[] inputArray) { array = inputArray; }
        public void set(T inputSearchVar) { SearchVar = inputSearchVar; }

        public void printObjectInfo()
            {

                Console.WriteLine("Size of list is " + array.Length);

                Array.Sort(array);
                Console.WriteLine("Sorted Array");
                for (int i = 0; i < array.Length; i++)
                    Console.WriteLine((i + 1) + ". " + array[i]);

                Console.WriteLine("Search variable is " + SearchVar);
            }

            public bool GetMax<T>(T lhs, T rhs)
            {
                T ans = Comparer<T>.Default.Compare(lhs, rhs) > 0 ? lhs : rhs;
                if (ans.Equals(lhs))
                    return true;
                else
                    return false;
            }

            public void SearchElement()
            {
                Array.Sort(array);
                int left = 0;
                int right = array.Length - 1, tmp;

                while (left <= right)
                {
                    tmp = left + (right - left) / 2;
                    if (array[tmp].Equals(SearchVar))
                    {
                        Console.WriteLine("We found this element => array[" + tmp + "] = " + array[tmp] + '\n');
                        return;
                    }
                    else
                    {
                        if (this.GetMax(array[tmp], SearchVar))
                            right = tmp - 1;
                        else
                            left = tmp + 1;
                    }
                }
                Console.WriteLine("The variable is not in the array\n");

            }

        public static BinarySearch<string> inputData()
        {
            string input = "", variable = "";

            Console.WriteLine("Enter Data: ");
            input = Console.ReadLine();
            string[] inputArr = input.Split(" ");

            Console.WriteLine("Enter Search Element: ");
            variable = Console.ReadLine();

            //array = inputArr;
            //SearchVar = variable;
            BinarySearch<string> test5 = new BinarySearch<string>(inputArr, variable);
            test5.printObjectInfo();
            test5.SearchElement();
            return test5;
        }

       
    }

   

    
}

  
 
