/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {int a , b ;
    a= Convert.ToInt32(Console.ReadLine());
    b= Convert.ToInt32(Console.ReadLine());
    int a1 , b1;
    a1 = a/10+(a%10);
    b1 = b/10+(b%10);
    if (a1==b1)
        Console.WriteLine("yes");
    else
       Console.WriteLine("no"); 
  }
}
