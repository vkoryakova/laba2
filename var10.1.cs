/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    double m = Convert.ToDouble(Console.ReadLine());
    double b = Convert.ToDouble(Console.ReadLine());
    double a;
    double u;
    if (m>5)
        {u = Convert.ToDouble (Math.Sqrt(b));}
        
    else {
        u = Convert.ToDouble ((Math.Sqrt(b))-m);
    }
        
    if (m<10)
       {a = Convert.ToDouble((Math.Sqrt(m))+5);}
        
    if(m==10)
        {a = Convert.ToDouble((Math.Sqrt(m))-(Math.Cos(m)));}
        
    else
        {a = Convert.ToDouble (Math.Cos(Math.Sqrt(m)));}
        
     double z =  Convert.ToDouble (( a * (Math.Tan(a))-(Math.Sqrt(m)))/(Math.Cos(u)+(u*b)));
    Console.WriteLine(z);
    
  }
}
