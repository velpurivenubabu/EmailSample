using System;

namespace EmailSample
{
    internal class Program
    {
        static void Main(string[] args)
        {MyPattern myObj = new MyPattern();
            Console.WriteLine("Hello, World! Welcome to Email Sample Programme");
            Console.WriteLine("Valid Email Sampiles");
            Console.WriteLine(myObj.ValidateEmailName("abc@yaho.com"));
            Console.WriteLine(myObj.ValidateEmailName("abc-100@yaho.com"));
            Console.WriteLine(myObj.ValidateEmailName("abc.100@yaho.com"));
            Console.WriteLine(myObj.ValidateEmailName("abc.111@yaho.com"));
            Console.WriteLine(myObj.ValidateEmailName("abc.100@yaho.net"));
            Console.WriteLine(myObj.ValidateEmailName("abc.111@yaho.com.au"));
            Console.WriteLine(myObj.ValidateEmailName("abc@gmail.com.com"));
            Console.WriteLine(myObj.ValidateEmailName("abc+100@gmail.com"));
            Console.WriteLine("InValid Email Sampiles");
            Console.WriteLine(myObj.ValidateEmailName("abc"));
            Console.WriteLine(myObj.ValidateEmailName(".abc@.com.my"));
            Console.WriteLine(myObj.ValidateEmailName("abc123@gmail.a"));
            Console.WriteLine(myObj.ValidateEmailName(".abc123@gmail.com.com"));
            Console.WriteLine(myObj.ValidateEmailName(".abc123@.abc.com"));
            Console.WriteLine(myObj.ValidateEmailName(".abc()*@gmail.com"));
            Console.WriteLine(myObj.ValidateEmailName(".abc@@gmail.com.aa.au"));
            Console.WriteLine(myObj.ValidateEmailName(".abc@abc@gmail.com"));
            Console.WriteLine(myObj.ValidateEmailName(".abc..@gmail.com"));


        }
    }
}