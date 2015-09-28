using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpDevs
{
    class Collections
    {
        //this is an array
        int[] arr = new int[] { 1, 2, 3 };

        //same as this
        int[] arr2 = new int[] 
        {
            1,
            2,
            3
        };

        //array of numb from 0 to 99
        int[] arrOfNumb = GetArray_0_To_99();

        private static int[] GetArray_0_To_99()
        {
            int[] arr = new int[100];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            return arr;
        }

        //array with steps
        int[] arrOfNumb2 = GetArrayOfSteps();

        private static int[] GetArrayOfSteps()
        {
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i*5;
            }
            return arr;
        }


        //Initialized from loop
        int[] arrOfNumb3 = InitializedFromLoop();

        private static int[] InitializedFromLoop()
        {
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * i * 5;
            }
            return arr;
        }

        //This is a function that returns a array
        public string[] RandomFruits(int count)
        {
            string[] result = new string[count];
            string[] fruits = { "apple", "orange", "pear" };
            var r = new System.Random();

            for (int i = 0; i < count; i++)
            {
                int index = r.Next(3);
                result[i] = fruits[index];
            }

            return result;
        }

        //This is a function that returns a array as IEnumerable
        public IEnumerable<string> RandomFruitsEnumerable(int count)
        {
            string[] fruits = { "apple", "orange", "pear" };
            var r = new System.Random();

            for (int i = 0; i < count; i++)
            {
                yield return fruits[r.Next(3)];
            }
        }
    }
}
