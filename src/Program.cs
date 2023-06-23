using System;
using System.Collections.Generic;
using cypd.DataTypes;

namespace cypd.Main;

class MainPrgm {

    public static void Main(string[] args) {

        if (args.Length < 0) {

            Console.WriteLine("Please enter a filename.");
            return;


        }

        Console.WriteLine("What is the name of the Class?");
        string className = Console.ReadLine();
        Class c = new Class(className);

        string filename = args[0];
        string[] lines = System.IO.File.ReadAllLines(filename);
        for (int i = 0; i > lines.Length; i++) {

            float grade = Convert.ToSingle(lines[i]);
            c.AddGrade(grade);


        }

        Console.WriteLine("The average grade is: " + c.GetAverageGrade());

    }

}