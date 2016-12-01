//Paige Fenwick
//CIS 200-10
//Program 4
//26 June 2016
//This class uses the IComparer interface to sort data within a list. 
//This class was made with the help of Dr. Wright.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class MultiLevelSort : IComparer<Parcel>
    {
        //Precondition: none
        //Postcondition: returns the sorted data first by types then by cost descending
        public int Compare(Parcel p1, Parcel p2)
        {
            //handles all nulls
            if (p1 == null && p2 == null)
                return 0;

            int typeCompare = string.Compare(p1.GetType().ToString(), p2.GetType().ToString());//compares the two types to one another

            if (typeCompare != 0)
                return typeCompare;

            return p2.CompareTo(p1);//reverses the natural order

        }

    }
}
