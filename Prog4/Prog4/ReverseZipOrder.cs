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
    class ReverseZipOrder : IComparer<Parcel>//new comparer class
    {
        //Precondition: None
        //Postcondition: returns the highest to lowest parcels based on zip codes
        public int Compare(Parcel p1, Parcel p2)
        {
            //handles null values
            if (p1 == null && p2 == null)
                return 0;

            if (p2 == null)
                return -1;

            int zipCompare = p2.DestinationAddress.Zip - p1.DestinationAddress.Zip;//compares the zips

            if (zipCompare != 0)
                return zipCompare;//returns compared zips if not null

            return zipCompare;
        }
    }
}
