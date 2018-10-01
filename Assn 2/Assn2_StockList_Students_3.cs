using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    public partial class StockList
    {
        //param        : NA
        //summary      : Calculate the value of each node by multiplying holdings with price, and returns the total value
        //return       : total value
        //return type  : decimal
        public decimal Value()
        {
            decimal value = 0.0m;
            StockNode current = head;

            while (current != null)
            {
                value = value + (current.StockHolding.CurrentPrice) * (current.StockHolding.Holdings);
                current = current.Next;
            }

            return value;
        }

        //param  (StockList) listToCompare     : StockList which has to comared for similarity index
        //summary      : finds the similar number of nodes between two lists
        //return       : similarty index
        //return type  : int
        public int Similarity(StockList listToCompare)
        {
            int similarityIndex = 0;
            StockNode current = this.head;
            StockNode current2 = listToCompare.head;

            while (current != null)
            {
                while (current2 != null)
                {
                    if (current.StockHolding.Symbol == current2.StockHolding.Symbol)
                    {
                        if (current.Next == null || current2.Next == null)
                        {
                            similarityIndex = similarityIndex + 1;
                        }
                        else if (current.StockHolding.Symbol == current.Next.StockHolding.Symbol || current2.StockHolding.Symbol == current2.Next.StockHolding.Symbol)
                        {
                            similarityIndex = similarityIndex + 0;
                        }
                        else
                        {
                            similarityIndex = similarityIndex + 1;
                        }
                    }
                    current2 = current2.Next;
                }
                current2 = listToCompare.head;
                current = current.Next;
            }
            return similarityIndex;
        }

        //param        : NA
        //summary      : Print all the nodes present in the list
        //return       : NA
        //return type  : NA
        public void Print()
        {
            StockNode current = head;
            while (current != null)
            {
                Console.WriteLine(current.StockHolding);
                current = current.Next;
            }
        }
    }
}