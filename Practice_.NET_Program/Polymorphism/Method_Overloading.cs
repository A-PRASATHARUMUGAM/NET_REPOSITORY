// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

//   int.Parse(value)
//   int32.Parse(value)
// Convert.Toint32(ReadLine);


using System;

public class HelloWorld
{
   
    public static void Main(string[] args)
    {
       
         Adding adding=new Adding();
        //  adding.Add1(4,5);
         adding.Add1(4,5,6);
    }
    
    
    public class Adding{

  //Method - 1 
    public void Add1(int a, int b ){
        
         int c=a+b;
        Console.WriteLine(c);
    
    }
    
    //Method - 2 - overloading this method 
    public void Add1(int a, int b,int c){
        int d=a+b+c;
        Console.WriteLine(d);
    }
    
}

}




