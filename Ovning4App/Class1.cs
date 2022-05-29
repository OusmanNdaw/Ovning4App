using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ListA
{
	public class ExamineList
	{
		public static void Main(string[] args)
		{
			var InputList = new List<int>(); ;
			// InputList = Console.ReadLine();
			ExamineList(InputList);
        }

        private static void ExamineList(List<int> inputList)
        {
            throw new NotImplementedException();
        }

        private static void ExamineList2(object InputList)
        {
            throw new NotImplementedException();
        }

        // static int maxQuantity;
        // static int maxWeight;

        // static int currentMaxSF;

        //
        static List<KeyValuePair<int, int>> ReadInput()
		{
			var input = "";
			var inputList = new List<string>();
			var result = new List<KeyValuePair<int, int>>();

			do
			{
				input = Console.ReadLine();
				inputList.Add(input);
			}
			while (input != null);

			if (inputList.Any())
				inputList.RemoveAt(inputList.Count - 1);

			foreach (var eachItem in inputList)
			{
				var temp = eachItem.Split(' ');

				result.Add(new KeyValuePair<int, int>(Int32.Parse(eachItem.Split(' ')[0]), Int32.Parse(eachItem.Split(' ')[1])));
			}

			// maxQuantity = result[0].Key;
			// maxWeight = result[0].Value;
			result.RemoveAt(0);

			return result;
		}
	}

}








/*
 
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
      var inputList = ReadInput();
      
      var filteredList = filterOverWeight(inputList);
      
      examineList(inputList);
      
      examineList(filteredList);
		}
		
		static int maxQuantity;
		static int maxWeight;
		
		static int currentMaxSF;
		
		//
	  static List<KeyValuePair<int, int>> ReadInput()
	  {
		  var input = "";
		  var inputList = new List<string>();
		  var result = new List<KeyValuePair<int, int>>();
		  
		  do
		  {
		    input = Console.ReadLine();
		    inputList.Add(input);
		  }
		  while(input != null);
		  
		  if(inputList.Any())
		    inputList.RemoveAt(inputList.Count - 1);
		  
		  foreach(var eachItem in inputList)
		  {
		    var temp = eachItem.Split(' ');
		    
		    result.Add(new KeyValuePair<int, int>(Int32.Parse(eachItem.Split(' ')[0]), Int32.Parse(eachItem.Split(' ')[1])));
		  }
		  
		  maxQuantity = result[0].Key;
		  maxWeight = result[0].Value;
		  result.RemoveAt(0);
		  
		  return result;
	  }
	  
	  //maxWeight
	  static List<KeyValuePair<int, int>> filterOverWeight(List<KeyValuePair<int, int>> list)
	  {
	    var result = new List<KeyValuePair<int, int>>();
	    
	    for(int i = 0; i > list.Count; i++)
	    {
	      if(list[i].Key > maxWeight)
	        list.RemoveAt(i);
	    }
	    
	    return result;
	  }
	  
	  static void examineList(List<KeyValuePair<int, int>> list)
	  {
	    foreach(var eachPair in list)
	    {
	      Console.WriteLine("{0} - {1}", eachPair.Key, eachPair.Value);
	    }
	  }
	}
}
 
 */