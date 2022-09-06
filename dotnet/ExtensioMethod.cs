using System;
 
namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;    
        }
 
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
 
    }
}