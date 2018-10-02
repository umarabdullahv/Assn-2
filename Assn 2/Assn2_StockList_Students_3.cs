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

            //Value of each share = (current price * number of holdings). 
            //Adding this value in the decimal variable 'value' to 
            //find portfolio value.
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

            //With two Do-while loops comparing 1st node of List1 with all the nodes of List2, 
            //and then comparing 2nd node of List1 with all the nodes of List2 
            //and this goes on until head = null
            while (current != null)
            {
                while (current2 != null)
                {

                    if (current.StockHolding.Symbol == current2.StockHolding.Symbol)
                    {
                        //similarity found and checking if that is the last node in the list then adding 1 to it
                        if (current.Next == null || current2.Next == null)
                        {
                            similarityIndex = similarityIndex + 1;
                        }
                        //similarity found and checking if the same stock is present in the same lists,
                        //i.e. if Client 1 or Client 2 has two or more GOOG in their portfolio then for each person 
                        //it will be counted once and will eliminate the first GOOG keeping only the last GOOG.
                        else if (current.StockHolding.Symbol == current.Next.StockHolding.Symbol || current2.StockHolding.Symbol == current2.Next.StockHolding.Symbol)
                        {
                            similarityIndex = similarityIndex + 0;
                        }
                        //similarity found and there is no two common stock in each client's 
                        //portfolio then add 1 to the similarity index
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
                //Using loop reading data from the head of the list towards the tail 
                Console.WriteLine(current.StockHolding);
                current = current.Next;
            }
        }
    }
}