using System;
using System.Collections;
using System.Collections.Generic;

namespace ProductsApp471.Models
{
    public class TwoSum
    {
        public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
        {
            List<Tuple<int, int>> ListOfInt = new List<Tuple<int, int>>();
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[i] + list[j] == sum)
                    {
                        ListOfInt.Add(new Tuple<int, int>(i, j));
                    }
                }
            }

            foreach (var elemt in ListOfInt)
            {
                return elemt;
            }
            return null;
        }

        //public static void Main(string[] args)
        //{
        //    Tuple<int, int> indices = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
        //    if (indices != null)
        //    {
        //        Console.WriteLine(indices.Item1 + " " + indices.Item2);
        //    }
        //}
    }
}