using System;
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
      StockList resultList = new StockList();

      // write your implementation here

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
                if(current.StockHolding.Holdings > mostShareStock.Holdings)
                {
                    mostShareStock.Holdings = current.StockHolding.Holdings;
                    mostShareStock.Name = current.StockHolding.Name;
                    mostShareStock.Symbol = current.StockHolding.Symbol;
                    mostShareStock.CurrentPrice = current.StockHolding.CurrentPrice;
                }
                else
                {
                    mostShareStock.Holdings = mostShareStock.Holdings;
                    mostShareStock.Name = mostShareStock.Name;
                    mostShareStock.Symbol = mostShareStock.Symbol;
                    mostShareStock.CurrentPrice = mostShareStock.CurrentPrice;
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