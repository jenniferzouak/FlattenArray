using System;
using System.Collections.Generic;

namespace FlattenArray
{
    public class Flattener
    {
        public object[] Flatten(object[] input) 
        {
            if (input == null) return null;
           
            List<object> outputList = new List<object>();
            foreach(object item in input)
            {
                if (item == null) continue;
                if (item.GetType().IsArray == true)
                {
                    object[] tmpArray = Flatten(item as object[]);
                    outputList.AddRange(tmpArray);
                }
                else
                {
                    outputList.Add(item);
                }

            }
            return outputList.ToArray();

        }
    }
}
