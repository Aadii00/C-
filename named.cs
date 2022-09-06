using System;

class namedWelcome{
    public static void Main(string[] args){
        Console.WriteLine("Hello, {0}!",args[0]);
        Console.WriteLine("Hello, {0}!",args[1]);
        Console.WriteLine("Hello,{1} From {0}!",args[0],args[1]);
        Console.WriteLine("Welcome to the C# Tutorial!");
        Console.ReadLine();  
        
    }
}




// using System;
// class namedWelcome
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Hello, {0}!", args[0]);
//         Console.WriteLine("Hello, {0}!", args[1]);
//         Console.WriteLine("Hello, {1} From {0} !", args[0], args[1]);
//         Console.WriteLine("Welcome to the C# Tutorial!");
//         Console.ReadLine();
//     }
// }