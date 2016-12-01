﻿// Program 0
// CIS 200-10
// Summer 2015
// Due: 5/21/2015
// By: Andrew L. Wright

// File: Parcel.cs
// Parcel serves as the abstract base class of the Parcel hierachy.

//Paige Fenwick
//CIS 200-10
//Program 4
//26 June 2016
//This class uses the IComparable interface to sort data within a list. 
//This class was made with the help of Dr. Wright.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Parcel: IComparable<Parcel>
{
    // Precondition:  None
    // Postcondition: The parcel is created with the specified values for
    //                origin address and destination address
    public Parcel(Address originAddress, Address destAddress)
    {
        OriginAddress = originAddress;
        DestinationAddress = destAddress;
    }

    public Address OriginAddress
    {
        // Precondition:  None
        // Postcondition: The parcel's origin address has been returned
        get;

        // Precondition:  None
        // Postcondition: The parcel's origin address has been set to the
        //                specified value
        set;
    }

    public Address DestinationAddress
    {
        // Precondition:  None
        // Postcondition: The parcel's destination address has been returned
        get;

        // Precondition:  None
        // Postcondition: The parcel's destination address has been set to the
        //                specified value
        set;
    }

    // Precondition:  None
    // Postcondition: The parcel's cost has been returned
    public abstract decimal CalcCost();

    // Precondition:  None
    // Postcondition: A String with the parcel's data has been returned
    public override String ToString()
    {
        return String.Format("Origin Address:{3}{0}{3}{3}Destination Address:{3}{1}{3}Cost: {2:C}",
            OriginAddress, DestinationAddress, CalcCost(), Environment.NewLine);
    }

    //Precondition: none
    //Postcondition: The parcel's list in compared to find the lowest to highest Cost
    public int CompareTo(Parcel p2)
    {
       //correct handling of nulls
        if (this == null && p2 == null)
            return 0;

        if (this == null)
            return -1;

        if (p2 == null)
            return 1;

        int calcCostCompare = decimal.Compare(this.CalcCost(), p2.CalcCost());//cast decimals to ints and compares this parcel to parcel 2

        if (calcCostCompare != 0)//if cost is not null
            return calcCostCompare;//returns compared objects

        return calcCostCompare;//returns compared objects
    }
}
