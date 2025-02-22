﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day_5_Practice
{
    class Program
    {
        /*static void Main(string[] args)
        {
            Collection<string> dinosaurs = new Collection<string>();
            dinosaurs.Add("Psitticosaurus");
            dinosaurs.Add("Caudipteryx");
            dinosaurs.Add("Compsognathus");
            dinosaurs.Add("Muttaburrasaurus");

            Console.WriteLine("{0} dinosaurs:", dinosaurs.Count);
            Display(dinosaurs);

            Console.WriteLine("\nIndexOf(\"Muttaburrasaurus\"): {0}", dinosaurs.IndexOf("Muttaburrasaurus"));

            Console.WriteLine("\nContains(\"Caudipteryx\"): {0}", dinosaurs.Contains("Caudipteryx"));

            Console.WriteLine("\nInsert(2, \"Nanotyrannus\")");
            dinosaurs.Insert(2, "Nanotyrannus");
            Display(dinosaurs);

            Console.WriteLine("\ndinosaurs[2]: {0}", dinosaurs[2]);

            Console.WriteLine("\ndinosaurs[2] = \"Microraptor\"");
            dinosaurs[2] = "Microraptor";
            Display(dinosaurs);

            Console.WriteLine("\nRemove(\"Microraptor\")");
            dinosaurs.Remove("Microraptor");
            Display(dinosaurs);

            Console.WriteLine("\nRemoveAt(0)");
            dinosaurs.RemoveAt(0);
            Display(dinosaurs);

            Console.WriteLine("\ndinosaurs.Clear()");
            dinosaurs.Clear();
            Console.WriteLine("Count: {0}", dinosaurs.Count);

            Console.ReadLine();
        }*/

        //main class for collection object
        static void Main(string[] args)
        {
            Dinosaurs dinosaurs = new Dinosaurs();

            dinosaurs.Changed += ChangedHandler;

            dinosaurs.Add("Psitticosaurus");
            dinosaurs.Add("Caudipteryx");
            dinosaurs.Add("Compsognathus");
            dinosaurs.Add("Muttaburrasaurus");

            Display(dinosaurs);

            Console.WriteLine("\nIndexOf(\"Muttaburrasaurus\"): {0}",
                dinosaurs.IndexOf("Muttaburrasaurus"));

            Console.WriteLine("\nContains(\"Caudipteryx\"): {0}",
                dinosaurs.Contains("Caudipteryx"));

            Console.WriteLine("\nInsert(2, \"Nanotyrannus\")");
            dinosaurs.Insert(2, "Nanotyrannus");

            Console.WriteLine("\ndinosaurs[2]: {0}", dinosaurs[2]);

            Console.WriteLine("\ndinosaurs[2] = \"Microraptor\"");
            dinosaurs[2] = "Microraptor";

            Console.WriteLine("\nRemove(\"Microraptor\")");
            dinosaurs.Remove("Microraptor");

            Console.WriteLine("\nRemoveAt(0)");
            dinosaurs.RemoveAt(0);

            Display(dinosaurs);

            Console.ReadLine();
        }

        private static void Display(Collection<string> dinosaurs)
        {
            Console.WriteLine();
            foreach (string item in dinosaurs)
            {
                Console.WriteLine(item);
            }
        }

        private static void ChangedHandler(object source,
        DinosaursChangedEventArgs e)
        {

            if (e.ChangeType == ChangeType.Replaced)
            {
                Console.WriteLine("{0} was replaced with {1}", e.ChangedItem,
                    e.ReplacedWith);
            }
            else if (e.ChangeType == ChangeType.Cleared)
            {
                Console.WriteLine("The dinosaur list was cleared.");
            }
            else
            {
                Console.WriteLine("{0} was {1}.", e.ChangedItem, e.ChangeType);
            }
        }
    }


    //collection class

    public class Dinosaurs : Collection<string>
    {
        public event EventHandler<DinosaursChangedEventArgs> Changed;

        protected override void InsertItem(int index, string newItem)
        {
            base.InsertItem(index, newItem);

            EventHandler<DinosaursChangedEventArgs> temp = Changed;
            if (temp != null)
            {
                temp(this, new DinosaursChangedEventArgs(
                    ChangeType.Added, newItem, null));
            }
        }

        protected override void SetItem(int index, string newItem)
        {
            string replaced = Items[index];
            base.SetItem(index, newItem);

            EventHandler<DinosaursChangedEventArgs> temp = Changed;
            if (temp != null)
            {
                temp(this, new DinosaursChangedEventArgs(
                    ChangeType.Replaced, replaced, newItem));
            }
        }

        protected override void RemoveItem(int index)
        {
            string removedItem = Items[index];
            base.RemoveItem(index);

            EventHandler<DinosaursChangedEventArgs> temp = Changed;
            if (temp != null)
            {
                temp(this, new DinosaursChangedEventArgs(
                    ChangeType.Removed, removedItem, null));
            }
        }

        protected override void ClearItems()
        {
            base.ClearItems();

            EventHandler<DinosaursChangedEventArgs> temp = Changed;
            if (temp != null)
            {
                temp(this, new DinosaursChangedEventArgs(
                    ChangeType.Cleared, null, null));
            }
        }
    }

    // Event argument for the Changed event.
    //
    public class DinosaursChangedEventArgs : EventArgs
    {
        public readonly string ChangedItem;
        public readonly ChangeType ChangeType;
        public readonly string ReplacedWith;

        public DinosaursChangedEventArgs(ChangeType change, string item,
            string replacement)
        {
            ChangeType = change;
            ChangedItem = item;
            ReplacedWith = replacement;
        }
    }

    public enum ChangeType
    {
        Added,
        Removed,
        Replaced,
        Cleared
    };
}
