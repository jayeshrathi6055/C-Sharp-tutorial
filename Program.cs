using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HELLO_C_SHARP
{
    class Program
    {
        static int sum(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            // Print Statements------------------------------------------------------>
            // Console.WriteLine("Hello World!");    // It also give extra line
            // Console.Write("Hello Sir ");          // This will not give extra line
            // Console.WriteLine("I am J");

            // // Datatypes in C# - int , float , char , bool , string , long , short , double ----------------------------->
            // int a = 5;
            // float b = 5.4f;
            // char c = 'J';
            // bool d = true;
            // string e = "Jayesh Rathi";
            // Console.WriteLine("Integer value is - "+a);
            // Console.WriteLine("float value is - "+b);
            // Console.WriteLine("char value is - "+c);
            // Console.WriteLine("boolean value is - "+d);
            // Console.WriteLine("string value is - "+e);

            // // Type Casting------------------------------------------------------------>
            // // 1. Implicit casting - char to int to long to float to double.
            // int y = 5;
            // double z = y;
            // Console.WriteLine(z);

            // char a= 'y';
            // Console.WriteLine(a);
            // int b = a;
            // Console.WriteLine(b);    //-------> It will give ASCII value
            // float c = b; 
            // Console.WriteLine(c);    //-------> It will give ASCII value

            // // 2. Explict Casting
            // int x = (int)3.5;
            // Console.WriteLine(x);

            // char m = (char)x;
            // Console.WriteLine(m);    //-------> It will give nothing

            // float varr = Convert.ToInt32(3.54);
            // Console.WriteLine(varr);

            // // Input from user---------------------------------------------------------->
            // string a = Console.ReadLine();
            // Console.Write(a);

            // string b = Console.ReadLine();
            // Console.Write("you got "+(Convert.ToInt16(b)+4));

            // // Operators-------------------------------------------------------------------->
            // // Arithmetic Operators
            // int a = 5,b = 4;
            // Console.WriteLine("Addition is "+(a+b));
            // Console.WriteLine("Subtraction is "+(a-b));
            // Console.WriteLine("Multiplication is "+(a*b));
            // Console.WriteLine("Division is "+(a/b));
            // Console.WriteLine("Division is "+(a%b));

            // // Assignment Operators ->  =, +=, -=, *=, /=

            // // Logical Operator -> &&,||,!

            // // Comparison Operator ->  >, <, ==, >=, <=, !=

            // // Math class-------------------------------------------------------->
            // double a = Math.Max(20, 21);
            // double b = Math.Min(20, 21);
            // double c = Math.Sqrt(64);
            // double d = Math.Abs(5-6);
            // double e = Math.Max(20, 21);
            // double f = Math.Pow(2, 2);
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // Console.WriteLine(c);
            // Console.WriteLine(d);
            // Console.WriteLine(e);
            // Console.WriteLine(f);

            // // String properties ---------------------------------------------------------->
            // string s = "Hello Jayesh";
            // Console.WriteLine(s.Length);
            // Console.WriteLine(s.ToUpper());
            // Console.WriteLine(s.ToLower());
            // Console.WriteLine(s.Substring(5));

            // string s1 = "Rathi";
            // Console.WriteLine($"{s} {s1}"); //--------------> String interpolation
            // 
            // Console.WriteLine(s1[2]);  //--------->Indexing

            // // If-Else Statement----------------------------------------------------------------->
            // int age = 10;
            // if (age>18){
            //     Console.WriteLine("You can drive");
            // }
            // else{
            //     Console.WriteLine("You cannot drive");
            // }

            // if (age<5){
            //     Console.WriteLine("bache");
            // }
            // else if (age<15){
            //     Console.WriteLine("Do your homework");
            // }
            // else if(age<18){
            //     Console.WriteLine("You cannot drive");
            // }
            // else{
            //     Console.WriteLine("You can drive");
            // }

            // // switch Case--------------------------------------------------------------->
            // int age = 15;
            // switch (age){
            //     case 10:
            //         Console.WriteLine("You are 10");
            //         break;
            //     case 20:
            //         Console.WriteLine("You are 20");
            //         break;
            //     default:
            //         Console.WriteLine("not applicable");
            //         break;
            // }

            // // Loops------------------------------------------------------------------------>

            // // while loop
            // int i = 0;
            // while(i<10){
            //     Console.WriteLine(i);
            //     i++;
            // }

            // // Do-While loop
            // int i1 = 0;
            // do{
            //     Console.WriteLine(i1);
            //     i1++;
            // }while(i1<10);

            // // For loop
            // for (int a = 0; a < 5; a++)
            // {
            //     Console.WriteLine(a);
            // }

            // // Functions/Methods-------------------------------------------------->
            // int x = sum(5,4);
            // Console.WriteLine(x);

             // // OOPS---------------------------------------------------------------->
             // player tom = new player();
             // Console.WriteLine(tom.age);
             // tom.setage(15);
             // Console.WriteLine(tom.age);


            Console.ReadLine();                  // It says stop console give time for reading
        }
    }
}
