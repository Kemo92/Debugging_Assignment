using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debug2
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Billy";
            int age = 15;
            double cost = 2.25;

            //starting Debug
            Debug.WriteLine("Debug Information-Product Starting ");
            Debug.Indent();

            //Display variables
            Debug.WriteLine("My name is  " + name);
            Debug.WriteLine("I am this old " + age);
            Debug.WriteLine("I saved up this much money " + cost);


            //calc and variables
            Debug.WriteLine("My Name is " + name, "Field");
            Debug.WriteLine("I am tis old" + age, "Field");
            Debug.WriteLine("i have this much saved up" + cost, "Field");
            Debug.WriteLine("In 15 years i wil have  " + (age * cost), "Calc");

            //output based on value of logical express
            Debug.WriteLineIf(cost > 2, "Happy");
            Debug.WriteLineIf(cost < 2, "Sad");

            //to show conditions that are false, use Assert
            Debug.Assert(cost > 1, "More money = happy");
            Debug.Assert(cost < 1, "Less money = sad");

            //output to console and text file
            TextWriterTraceListener tr1 = new TextWriterTraceListener(System.Console.Out);
            Debug.Listeners.Add(tr1);
            TextWriterTraceListener tr2 = new TextWriterTraceListener(System.IO.File.CreateText("Debug_Output.txt"));
            Debug.Listeners.Add(tr2);

            //additional sentances
            Debug.WriteLine("My Name is " + name, "Field");
            Debug.WriteLine("I am tis old " + age, "Field");
            Debug.WriteLine("i have this much saved up " + cost, "Field");
            Debug.WriteLine("In 15 years i wil have  " + (age * cost), "Calc");

            //unident and end debug
            Debug.Unindent();
            Debug.WriteLine("ALL DONE!");

            Debug.Flush();
            Console.ReadKey();

          

           


        }
    }
}
