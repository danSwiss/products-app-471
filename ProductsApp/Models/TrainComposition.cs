using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductsApp471.Models
{
    public class TrainComposition
    {
        private LinkedList<int> wagons = new LinkedList<int>();

        public void AttachWagonFromLeft(int wagonId)
        {
            wagons.AddFirst(wagonId);
        }

        public void AttachWagonFromRight(int wagonId)
        {
            wagons.AddLast(wagonId);
        }

        public int DetachWagonFromLeft()
        {
            //if (wagons.Any())
            //{
            //   // return wagons.Select().RemoveFirst();
            //}
            //else
            //{
                throw new IndexOutOfRangeException("No Wagons");
           // }
        }

        public int DetachWagonFromRight()
        {
           // if (wagons.Any())
            //{
            //   // return wagons.RemoveLast();
            //}
            //else
            //{
                throw new IndexOutOfRangeException("No Wagons");
           // }
        }

        //public static void Main(string[] args)
        //{
        //    TrainComposition tree = new TrainComposition();
        //    tree.AttachWagonFromLeft(7);
        //    tree.AttachWagonFromLeft(13);
        //    Console.WriteLine(tree.DetachWagonFromRight()); // 7 
        //    Console.WriteLine(tree.DetachWagonFromLeft()); // 13
        //}

    }
}