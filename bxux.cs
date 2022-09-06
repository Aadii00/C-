using System;
 
class BoxUnbox
{
  public static void Main()
  {
    //boxing
        int num = 200;
        object obj = num;
        num = 300;

        System.Console.WriteLine("Value of num is : {0}", num);
        System.Console.WriteLine("Value of obj is : {0}", obj);
 
    // unboxing
    int i = (int)obj;
    Console.WriteLine("Value of ob object is : " + obj);
    Console.WriteLine("Value of i is : " + i);
  }
}
