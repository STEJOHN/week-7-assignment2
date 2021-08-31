using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
    public class SimpleArray
    {   
        public string[] GroceryList;

        public SimpleArray()
        {
            GroceryList = new string[4] { "bread", "milk", "eggs", "cheese" };
        }
        public override string ToString()
        {
            return "There are " + GroceryList.Length + " and they are: " + GroceryList.ToString();
        }
    }
}
