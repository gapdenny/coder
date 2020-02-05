using System;
using Decoder.Model;

namespace Decoder
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = "WEAREDISCOVEREDFLEEATONCE";
            try
            {
                Cipher cipher = new Cipher();

                string result = cipher.getEncryptedData(input, 3);

                Console.WriteLine(result);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadKey();
        }
    }
}
