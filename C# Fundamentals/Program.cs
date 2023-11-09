using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {   /*
        
        // constant değiştirilemez
        const double PI = 3.141159265359;
        const int weeks = 52, months = 12;

        */
        static void Main(string[] args)
        {
           /*
             

            Console.ForegroundColor = ConsoleColor.DarkBlue; // Yazı rengi değişti
            Console.BackgroundColor = ConsoleColor.DarkGray; // Arkaplan rengi değişti
            Console.Clear(); // Tamamı gri oldu

            Console.WriteLine(PI);

            int age = 15;
            Console.WriteLine("Hello World!");
            Console.WriteLine(age);

            string name = "furkan";
            name.ToUpper();
            Console.WriteLine(name);

            Console.Write("Enter a value:"); // input girme
            string readInput = Console.ReadLine();
            Console.WriteLine("Entered value " + readInput);

            //Console.Read(); // tekrar input almasını araştır

            // impilicit conversion
            int num = 12794565;
            long bigNum = num;

            // explicit conversion
            float myFloat = 6.655F;
            double myDouble;
            myDouble = (double)myFloat;

            // type conversion
            string myString = myDouble.ToString();
            Console.WriteLine(myString + 1);

            bool myBool = false;
            string myString2 = myBool.ToString();
            Console.WriteLine(myString2 + " is a string");

            string s1 = "15";
            string s2 = "17";
            int i1 = int.Parse(s1); // 2 farklı şekilde int yazılabilir
            int i2 = Int32.Parse(s2);

            Console.WriteLine(s1 + s2);
            Console.WriteLine(i1 + i2);

            string s3 = "1.15";
            float f1 = float.Parse(s3);
            Console.WriteLine(f1 + i1);

            // String formatting
            int myAge = 22;
            string myName = "Furkan";
            Console.WriteLine("My name is {0}, I am {1} years old", myName, myAge);

            // String interpolation
            Console.WriteLine($"My name is {myName}\nI am {myAge} years old"); // \n yeni satıra geçer

            
            // Vertabim strings
              // Aşağıdaki gibi dosya yapılarını belirmek için kullanılır
            Console.WriteLine(@"C:\User\Admin\Nancy.png
                Birçok alanda Java'yı kendisine örnek alır ve C# da java gibi C ve C++ kod sözdizimine benzer bir kod yapısındadır. 

                .NET kütüphanelerini kullanmak amacıyla yazılan programların çalıştığı bilgisayarlarda uyumlu bir kütüphanenin ve yorumlayıcının bulunması gereklidir.
                Bu, Microsoft'un .NET Framework'u olabileceği gibi ECMA standartlarına uygun herhangi bir kütüphane ve yorumlayıcı da olabilir.
                Yaygın diğer kütüphanelere örnek olarak Portable.Net ve Mono verilebilir.");
             
             
            string firstName = "Furkan";
            string lastName = "Çetin";
            string fullName = string.Concat(" ", firstName + " " + lastName);
            Console.WriteLine(fullName);
            Console.WriteLine(firstName.Substring(3)); //kan
            Console.WriteLine(lastName.ToLower()); // çetin
            Console.WriteLine(fullName.Trim()); //Sol taraftaki boşluğu sildi
            Console.WriteLine(firstName.IndexOf("k")); // 3
            Console.WriteLine(String.IsNullOrWhiteSpace(firstName)); // false

            
            //araştır
            var name2 = "Ebru";
            String.Format("My name is {0}", name2);
            Console.WriteLine(name2);


            */

            /*  METODLAR
           
            WriteSomething();
            int result = Add(1, 5);
            Console.WriteLine(result);


            string s = "HeY ThErE !";
            s = LowUpper(s);
            Console.WriteLine(s);
            Count(s);
            */

            /*  TRY CATCH
             
            Console.Write("Enter a num:");
            string numS = Console.ReadLine();
            //Console.ReadKey();
            int numInput = 0;
            try
            {
                numInput = int.Parse(numS);
            }
            catch (FormatException) {

                Console.WriteLine("Format exception");
            }
            catch (OverflowException){
                Console.WriteLine("Overflow Exception");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Argument null Exception");
            }
            finally
            {
                Console.WriteLine(numInput);
            }
            */


            /*

            Console.WriteLine("What is the pemperature like?");
            string temperature= Console.ReadLine();
            int numTemp;
            int number;
            bool enteredNumber = int.TryParse(temperature, out number);
            if (enteredNumber)
            {
                numTemp = number;
                Console.WriteLine("Temperature is "+ numTemp);
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("You entered was no number");
            }
            */

            /*
            Console.Write("Enter a number? ");
            string numbers = Console.ReadLine();
            int num = int.Parse(numbers);
          
            int evenOrOdd = num % 2;
            
            if (evenOrOdd.Equals(0))
            {
                Console.WriteLine("Even");
            }
            else{
                Console.WriteLine("Odd");
            }
             */
            


        }



        /* METODLAR
         
        public static string LowUpper(string s)
        {
            return s + s.ToLower();

        }

        public static void Count(string s)
        {
            Console.WriteLine(s.Length);
        }



        public static void WriteSomething() // access modifier(static)
        {
            Console.WriteLine("This is a method");
            //Console.Read();

        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;

        }
        */

    }
}
