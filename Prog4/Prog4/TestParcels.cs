﻿// Program 1
// CIS 200-10
// Summer 2015
// Due: 6/3/2015
// By: Andrew L. Wright

// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and generates specified reports using LINQ.

//Paige Fenwick
//CIS 200-10
//Program 4
//26 June 2016
//This class uses the IComparable and IComparer interface to sort data within a list by using Sort(). 
//This class was made with the help of Dr. Wright.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and reports generated using LINQ
        static void Main(string[] args)
        {
            // Test Data - Magic Numbers OK
            Address a1 = new Address("John Smith", "123 Any St.", "Apt. 45",
                "Louisville", "KY", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.", "",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            Address a5 = new Address("John Doe", "111 Market St.", "",
                "Jeffersonville", "IN", 47130); // Test Address 5
            Address a6 = new Address("Jane Smith", "55 Hollywood Blvd.", "Apt. 9",
                "Los Angeles", "CA", 90212); // Test Address 6
            Address a7 = new Address("Captain Robert Crunch", "21 Cereal Rd.", "Room 987",
                "Bethesda", "MD", 20810); // Test Address 7
            Address a8 = new Address("Vlad Dracula", "6543 Vampire Way", "Apt. 1",
                "Bloodsucker City", "TN", 37210); // Test Address 8

            Letter letter1 = new Letter(a1, a2, 3.95M);                            // Letter test object
            Letter letter2 = new Letter(a3, a4, 4.25M);                            // Letter test object
            GroundPackage gp1 = new GroundPackage(a5, a6, 14, 10, 5, 12.5);        // Ground test object
            GroundPackage gp2 = new GroundPackage(a7, a8, 8.5, 9.5, 6.5, 2.5);     // Ground test object
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a3, a5, 9.5, 6.0, 5.5, // Next Day test object
                5.25, 5.25M);
            NextDayAirPackage ndap3 = new NextDayAirPackage(a2, a7, 10.5, 6.5, 9.5, // Next Day test object
                15.5, 5.00M);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a5, a7, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a8, a1, 15.0, 9.5, 6.5,   // Two Day test object
                75.5, TwoDayAirPackage.Delivery.Early);
            TwoDayAirPackage tdap3 = new TwoDayAirPackage(a6, a4, 12.0, 12.0, 6.0,  // Two Day test object
                5.5, TwoDayAirPackage.Delivery.Saver);

            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list
            parcels.Add(letter2);
            parcels.Add(gp1);
            parcels.Add(gp2);
            parcels.Add(ndap1);
            parcels.Add(ndap2);
            parcels.Add(ndap3);
            parcels.Add(tdap1);
            parcels.Add(tdap2);
            parcels.Add(tdap3);

            Console.WriteLine("Original List:");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)//displays the original original list
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();

            parcels.Sort();//calls the parcel class, compareto method
            Console.WriteLine("Sorted List (by CalcCost in Ascending Order)");
            Console.WriteLine("===============================================");
            foreach (Parcel p in parcels)//displays the sorted data
            {
                Console.WriteLine(p);
                Console.WriteLine("=======================");
            }
            Pause();

            parcels.Sort(new ReverseZipOrder());//sorts the data according to the reverse zip order class, compare method
            Console.WriteLine("Sorted in Reverse Order");
            Console.WriteLine("========================");
            foreach (Parcel p in parcels)//displays the sorted data
            {
                Console.WriteLine(p);
                Console.WriteLine("==================");
            }
            Pause();

            parcels.Sort(new MultiLevelSort());//sorts the data according to the multilevel sort class, compare method
            Console.WriteLine("Multilevel Sort");
            Console.WriteLine("================");
            foreach (Parcel p in parcels)//displays the sorted data
            {
                Console.WriteLine(p);
                Console.WriteLine("===================");
            }
            Pause();
        }

        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();

            Console.Clear(); // Clear screen
        }
    }
}
