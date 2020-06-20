using System;
namespace Tsueda_Brandon_FinalProject
{
    public class Validation
    {

            public static string ValidateString(string s)
            {
                Console.Write(s);
                string response = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(response))
                {
                    Console.WriteLine("Please do not leave this empty...");
                    response = Console.ReadLine();
                }
                return response;
            }
    }
}
