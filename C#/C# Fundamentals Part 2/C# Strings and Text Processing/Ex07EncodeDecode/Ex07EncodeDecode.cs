using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that encodes and decodes a string using given encryption key (cipher). 
//The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) 
//operation over the first letter of the string with the first of the key, the second – with the second, etc.
//When the last key character is reached, the next is the first.

namespace Ex07EncodeDecode
{
    class Ex07EncodeDecode
    {
        static string Encode(string text, string key)
        {
            StringBuilder sb = new StringBuilder(text.Length);

            for (int i = 0; i < text.Length; i++)
                sb.Append((char)(text[i] ^ key[i % key.Length]));

            return sb.ToString();
        }

        static string Decode(string text, string key)
        {
            return Encode(text, key);
        }

        static void Main()
        {
            string message = "sometext";
            string key = "abc";
            string encoded = Encode(message, key);
            string decoded = Decode(encoded, key);

            Console.WriteLine(encoded);     
            Console.WriteLine(decoded);
        }               
    }
}
