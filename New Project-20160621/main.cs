using System.IO;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Add rows and columns to the List.
	//
	List<List<int>> list = new List<List<int>>();
	string CommandResult = "01001|0092279227|001|F|F01001|0092279227|001|0|00343402005 |0092279227 |2|8|3|0|1.73|12|1|19980423 |20160223 |0|JVg6 |11|G251982-7       |DEMO                 |* MR ERIC LEE                                      |FLAT B 12/F                              |TOWER 2 HILLSBOROUGH COURT               |18 OLD PEAK RD                           |HK                                       |0|                                                   |FAX 28584738       |                   |                   |                   |         |                   |12|S-CSL0   |8985200060949154963  |11|3||***CHG ICF NO.886989981332 ON 21/09/13 BY SUSANN(?P?q)***** *CHG ICF NO. 81-8012919722 (JAPAN) ON 18/10/13 BY FT26** *CUT ROAMING-DATA ON 27/2/14 BY FT12***ADD ROAMING DATA ON 31/3/14 BY FT12*****JOIN ROAMING DAYPASS ON 4/4/14 BY FT12** REQ JOIN MB BY SUSANN E-MAIL ON 11/4/2014 * ";
	string[] words = CommandResult.Split('|');
	for (int i = 0; i < 1; i++)
	{
	    //
	    // Put some integers in the inner lists.
	    List<int> sublist = new List<int>();
	    
	    int ColCount = words.Length; 
	    for (int v = 0; v < ColCount; v++)
	    //foreach (string s in words)
	    {
		    sublist.Add(ColCount);
	    }
	    //
	    // Add the sublist to the top-level List reference.
	    //
	    list.Add(sublist);
	}
	Display(list, words);
    }
    
    static void Display(List<List<int>> list, string[] w )
    {
	//
	// Display everything in the List.
	//
	//Console.WriteLine("Elements:");
	//foreach (var sublist in list)
	//{
	    
	    //foreach (var value in sublist)
	//    foreach (string value in w)
	//    {
    //		Console.Write(value);
    //		Console.Write('|');
	//    }
	//        Console.WriteLine();
	//}
	//
	// Display element at 3, 3.
	//
	//if (list.Count > 3 && list[3].Count > 3)
	
	for (int i=1; i < list.Count; i++)
	{
	//    for (int j=1; j < list[i].Count; j++)
	//    {
	//    Console.WriteLine(String.Format("Element at {0}, {1}:",i,j));
	//    Console.WriteLine(list[i][j].ToString());
	//    }
	    Console.WriteLine(String.Format("Element at {0}:",i));
	    Console.WriteLine(list[i][j].ToString());
	}
	//
	// Display total count.
	//
	int count = 0;
	foreach (var sublist in list)
	{
	    count += sublist.Count;
	    
	}
    	Console.WriteLine("Count:");
    	Console.WriteLine(count);
    }

}
