using System;

class WhileLoop
{
    public static void Main()
    {
        bool strFlag = true;

        Console.Write("Entering the loop...Press Y to Continue, N to exit \n");
        // while (strFlag)
        do
        {
            switch (Console.ReadLine().ToUpper())
            {
                case ("Y"):
                    Console.Write("Continuing in the loop \n");
                    break;

                case "N":
                    Console.Write("Exitting the loop. Good bye.");
                    strFlag = false;
                    break;

                default:
                    Console.Write("Invalid entry...Please enter Y/n or N/n. \n");
                    break;

            }
        } while (strFlag);
    }
}