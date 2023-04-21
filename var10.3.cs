/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    int a = Convert.ToInt32(Console.ReadLine());
      if (a>=1 && a<=3)
      {
          if (a==1){
              Console.WriteLine("Север-Северо-Восток");
          }
          if (a==2){
              Console.WriteLine("Северо-Восток");
          }
          Console.WriteLine("Восток");
      }
      if (a>=9 && a<=12)
      {
          if (a==11){
              Console.WriteLine("Север-Северо-Запад");
              
          }
          f (a==10){
              Console.WriteLine("Северо-Запад");
              
          }
          Console.WriteLine("Север");
      }
      if (a>=6 && a<=9)
      {
          if (a==7){
              Console.WriteLine("Юг-Юго-Запад");
          }
          if (a==8){
              Console.WriteLine("Юго-Запад");
          }
          Console.WriteLine("Запад");
      }
      if (a>3 && a<=6)
      {
          if (a==4){
              Console.WriteLine("Юг-Юго-Восток");
          }
          if (a==5){
              Console.WriteLine("Юго-Восток");
          }
          Console.WriteLine("Юг");
      }
 
  }
}
