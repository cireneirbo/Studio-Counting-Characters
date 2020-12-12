using System;
using System.Collections.Generic;

namespace Studio_Counting_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            Console.WriteLine("Do you want to use your own text? y/n");
            string inputBool = Console.ReadLine();
            if (inputBool.ToLower() == "y" )
            {
                Console.WriteLine("Please input your text:");
                string inputText = Console.ReadLine();
                text = inputText;
            }



            Console.WriteLine(CountCharacters.countCharactersInString(text));

        }
    }
}
