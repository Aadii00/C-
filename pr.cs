using System;
public class PropertyHolder
{
    private int someProperty = 0;
 
    public PropertyHolder() { }
 
    public PropertyHolder(int iVal)
    {
        SomeProperty = iVal;
    }

    public int SomeProperty
    {
        get
       {
            return someProperty;
        }
        set
       {
            someProperty = value;
        }
    }
 
    public void setPropValue(int iVal)
    {
        SomeProperty = iVal;
    }
}
public class PropertyTester
{
    public static int Main(string[] args)
    {
     PropertyHolder propHold = new PropertyHolder();
     Console.WriteLine(propHold.SomeProperty);
     propHold.SomeProperty = 5;
     Console.WriteLine(propHold.SomeProperty);
     propHold.setPropValue(15);
     Console.WriteLine(propHold.SomeProperty);

     propHold = new PropertyHolder(120);
     Console.WriteLine(propHold.SomeProperty);
    }
}

// {
//  public static int Main(string[] args)
//     {
//      PropertyHolder propHold = new PropertyHolder();
//      Console.WriteLine(propHold.SomeProperty);
//      propHold.SomeProperty = 5;
//      Console.WriteLine(propHold.SomeProperty);
//      propHold.setPropValue(15);
//      Console.WriteLine(propHold.SomeProperty);

//      propHold = new PropertyHolder(120);
//      Console.WriteLine(propHold.SomeProperty);
 
//      return 0;
//     }
// }