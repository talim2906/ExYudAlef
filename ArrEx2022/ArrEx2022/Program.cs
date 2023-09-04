using System;

namespace ArrEx2022
{
    class Program
    {
        public static void CreateArr(int[] arr)
        {
            Console.WriteLine("Enter {0} numbers",arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void InitArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
        }

        public static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+"\t");
            }
            Console.WriteLine();
        }

        public static bool IsExist(int[] arr, int num, int count)
        {//ט.כ: הפעולה מקבלת מערך מספר לחיפוש במערך ןמספר המציין כמה איברים יש במערך
            //ט:י : הפעולה תלחזיר אמת אם המספר נמצא במערך ושקר אחרת
            for (int i = 0; i < count; i++)
            {
                if (arr[i] == num)
                    return true;
            }
            return false;
        }


        public static int ZipArr(int[]arr, int[] newArr)
        {
            newArr[0] = arr[0];
            int count = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if(!IsExist(newArr,arr[i],count))
                {
                    newArr[count] = arr[i];
                    count++;
                }
            }
            return count;
        }

        public static void PrintArr(int[] arr, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(arr[i]+"\t");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] arr = { 3, 9, 8, 3, 4, 3, 1, 2, 3, 7, 9 };
            //CreateArr(arr);
            PrintArr(arr);
            int[] newArr = new int[arr.Length];
            InitArr(newArr);
            int count = ZipArr(arr, newArr);
            PrintArr(newArr,count);
        }
    }
}
