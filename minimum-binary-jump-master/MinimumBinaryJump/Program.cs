using System;

namespace MinimumBinaryJump
{
    class Program
    {
        private static int i;
        static void Main(string[] args)
        {
            int arrayLength;
            Console.WriteLine("Enter length of the array : ");
            arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[100];
            Console.WriteLine("Enter binary elements in array : ");
            for (i = 0; i < arrayLength; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            if(arrayLength>2)
            CountSteps(arrayLength, arr);
            else if((arrayLength==2)&& (CheckIfAllZero(arrayLength, arr) == 1))
                Console.WriteLine("Minimum jumps required are : 1");
            else
                Console.WriteLine("Minimum jumps required are : 0");

        }        

        static int CheckIfAllZero(int arrLength,int[] arrCheck)
        {
                int f=0;
            for (i = 0; i < arrLength; i++)
            {
                if (arrCheck[i] == 0)
                    f= 1;
                else
                {
                    f= 0;
                    break;
                }
            }
            return f;
        }

        static void CountSteps(int arLength, int[] arCheck)
        {
                int steps = 0;
                for (i = 0; i < arLength; i++)
                {
                    if ((i - arLength) < -2)
                    {
                        if ((arCheck[i] == 0) && (arCheck[i + 1] == 0) && (arCheck[i + 2] == 1))
                        steps++;
                        else if ((arCheck[i] == 0) && (arCheck[i + 1] == 0) && (arCheck[i + 2] == 0))
                        steps++;
                        else if ((arCheck[i] == 0) && (arCheck[i + 1] == 1) && (arCheck[i + 2] == 0))
                        steps++;
                        else if ((arCheck[i] == 1) && (arCheck[i + 1] == 0) && (arCheck[i + 2] == 0))
                        steps -= 0;
                        else
                        {
                            steps -= 0;
                            break;
                        }
                    }
                    else
                        break;
                }
                if (CheckIfAllZero(arLength,arCheck) == 0)
                    Console.WriteLine("Minimum jumps required are : " + steps);
                else
                    Console.WriteLine("Minimum jumps required are : " + (steps - 1));
        }
        
    }
}
