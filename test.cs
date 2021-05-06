namespace My_Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 1, 2, 4, 8, 3 };
            BinarySearch<int> test1 = new BinarySearch<int>(intArr, 100);
            test1.printObjectInfo();
            test1.SearchElement();

            double[] doubleArr = { 1.5, 2, 4.40, 8, 3 };
            BinarySearch<double> test2 = new BinarySearch<double>(doubleArr, 4.40);
            test2.printObjectInfo();
            test2.SearchElement();

            char[] charArr = { 'a', 'b', 'f', 'c' };
            BinarySearch<char> test3 = new BinarySearch<char>(charArr, 'a');
            test3.printObjectInfo();
            test3.SearchElement();

            string[] stringArr = { "Ann", "Pierre", "Maria" };
            BinarySearch<string> test4 = new BinarySearch<string>(stringArr, "Maria");
            test4.printObjectInfo();
            test4.SearchElement();

            BinarySearch<string> test5 = new BinarySearch<string>();
            test5 = BinarySearch<string>.inputData();

        }
    }
}