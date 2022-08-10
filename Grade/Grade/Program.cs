using System;

namespace Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            Console.WriteLine("Plz enter garde between 2 to 5");
            int [] arr=new int[6];    
            for(int i=0; i<6; i++)
            {
                int ip =Convert.ToInt32(Console.ReadLine());
                if (ip>1 && ip<6)
                {
                    arr[i]=ip;
                }
                else
                {
                    Console.WriteLine("Plz enter garde between 2 to 5");
                    ip = Convert.ToInt32(Console.ReadLine());
                    arr[i] = ip;
                }
            }
            float avg= FindAvg(arr);
            Console.WriteLine("avg "+avg);
            while (avg < 4.5) {   
                avg=ChangeEle(arr);
                c++;

            }

            Console.WriteLine("Changes required is " + c);


            Console.ReadKey();
        }

        public static float ChangeEle(int[] arr ) {
            Array.Sort(arr);
            arr[0] = 5;
            float avg=FindAvg(arr);

            return avg;
            
        }

        public static float FindAvg(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            float avg =(float) sum / arr.Length;

            return avg;

        }




    }
}
