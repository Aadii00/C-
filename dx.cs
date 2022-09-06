using System;
 
namespace DynamicProgSample  
{  
    class DynamicKeyword  
    {  
        static void Main(string[] args)  
        {  
            dynamic lastName = "Kumar";  
            dynamic dynAuthor = new Author();  
            Console.WriteLine(dynAuthor.FullNameMethod(lastName));  

            Console.ReadKey();  
        }         
    }  

    public class Author  
    {  
        // Define a dynamic field.   
        dynamic name;  
 
        // Define a dynamic method with a dynamic parameter type.   
        public dynamic FullNameMethod(dynamic d)  
        {  
            name = "Mukesh";  
            dynamic firstname = name;              
            return firstname + " " + d;  
        }  
    }  
}