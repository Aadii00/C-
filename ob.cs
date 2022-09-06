// using System;

// class OutputClass 
// {
//     string myString;

//     public OutputClass(string inputString)
//     {
//         myString = inputString;
//     }

//     public void printString() 
//     {
//         Console.WriteLine("Printing from printString method: {0}", myString);
//     }

//     public string getString() 
//     {
//         return myString;
//     }

//     /*
//     ~OutputClass() 
//     {
//     }
//     */
// }

// class ExampleClass 
// {
//     public static void Main() 
//     {
//         OutputClass outCl = new OutputClass("This is printed by the output class.");

//         outCl.printString();

//         Console.WriteLine("The string is: " + outCl.getString());
//     }
// }



using System;
 
class OutputClass 
{
    string myString = "Initnal value";

    public void printString() 
    {
        Console.WriteLine("Printing from printString method: {0}", myString);
    }
 
    public string getString() 
    {
        return myString;
    }
 
    public void setString(string inpString) 
    {
        myString = inpString;
    }
 
}
 
class ExampleClass 
{
    public static void Main() 
    {
        OutputClass outCl = new OutputClass();
 
        outCl.printString();
 
        Console.WriteLine("The string is: " + outCl.getString());
 
        outCl.setString("Modified string");

        outCl.printString();
 
        Console.WriteLine("The string is: " + outCl.getString());
    }
}