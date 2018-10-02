﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    public partial class StockList
    {
        //param   (StockList)listToMerge : second list to be merged 
        //summary      : merge two different list into a single result list
        //return       : merged list
        //return type  : StockList
        public StockList MergeList(StockList listToMerge)
        {
            //merging the list
            
            StockList resultList = new StockList();
            StockNode currentM = listToMerge.head;
            //there are 2 lists here
            //entering all the contents of client1 in resultlist
            resultList.head = head;
            StockNode current = head;
            
            //using adstock function to enlist all the items from listtomerge i.e client2 to resultlist
            while (current != null)
            {
                while (currentM != null)
                {
                    resultList.AddStock(currentM.StockHolding);
                    currentM = currentM.Next;
                }
                current = current.Next;
            }
            return resultList;
        }
        //param        : NA
        //summary      : finds the stock with most number of holdings
        //return       : stock with most shares
        //return type  : Stock
        public Stock MostShares()
        {
            Stock mostShareStock = null;
            StockNode current = head;
            mostShareStock = current.StockHolding;

            while (current != null)
            {
                if (current.StockHolding.Holdings > mostShareStock.Holdings)
                {
                    mostShareStock = current.StockHolding;
                }
                current = current.Next;
            }

            return mostShareStock;
        }

        //param        : NA
        //summary      : finds the number of nodes present in the list
        //return       : length of list
        //return type  : int
        public int Length()
        {
            int length = 0;
           
            // write your implementation here

            StockNode current = head;

            while (current != null)
            {
                length = length + 1;
                current = current.Next;
            }

            return length;
        }
    }
}