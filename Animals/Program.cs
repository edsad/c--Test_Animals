﻿using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Animal
    {
        public string Name { get; set; } = "";
        public string Species { get; set; } = "";
        public double Walk { get; set; } = 0.0;

        public string Rename (string NewName)
        {
            return NewName;
        }

        public string AnotherRename (string NewName)
        {
            return NewName;
        }

        public string AnotherSpecies (string NewSpecies)
        {
            return NewSpecies;
        }

        public string OneMoreSpecies (string NewSpecies)
        {
            return NewSpecies;
        }

        public double ThisFast (double fast)
        {
            return 5;
        }

        public double Wow (double fast)
        {
            return 10;
        }

    }
    public class Dog
    {
        public string Name { get; set; } = "";
        public string Species { get; set; } = "";
        public double Walk { get; set; } = 0.0;

        public string RenameAgain (string NewName)
        {
            return NewName;
        }

        public string RenameDog (string NewName)
        {
            return NewName;
        }

        public string Species2 (string NewName)
        {
            return NewName;
        }

        public string Species3 (string NewName)
        {
            return NewName;
        }

        public double ThisFast2 (double fast)
        {
            return 6;
        }

        public double ThisFast3 (double fast)
        {
            return 7;
        }

        public double ThisFast4 (double fast)
        {
            return 10;
        }

        public double ThisFast5 (double fast)
        {
            return 12;
        }
        // public bool AddNewName (String Dog);
    
        
        }
    }

    public class Cat
    {
        public string Name { get; set; } = "";
        public string Species { get; set; } = "";
        public double Walk { get; set; } = 0.0;

        public double ThisFast6 (double Fast)
        {
            return 15;
        }

        public string Species4 (string NewKind)
        {
            return NewKind;
        }

        public string ReName1 (string AnotherName1)
        {
            return AnotherName1;
        }

    }

