using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeWesfandron // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {

            
            var client = new HttpClient();

            var url = "https://api.kanye.rest";

            var response = client.GetStringAsync(url).Result;

            var kaynequote = JObject.Parse(response).GetValue("quote").ToString();

            Console.WriteLine($"*************DISCUSSION KANYE & RON****************************");
            Console.WriteLine();
            Console.WriteLine($"Kanye:  {kaynequote}");

            Console.WriteLine("--------------------------------------------------------------------------");


            var client2 = new HttpClient();
            var url2 = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var resnpose2 = client2.GetStringAsync(url2).Result;
            var ronquote = JArray.Parse(resnpose2).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            
            Console.WriteLine($"Ron : {ronquote}");
            Console.WriteLine();
            Console.WriteLine("PRESS ENTER TO KNOW MORE :");
            Console.WriteLine($"PRESS 'E' TO EXIT THE PROGRAM");
              
               var useranwer = Console.ReadLine().ToLower();
                

                
               if (useranwer == "e")
                {

                    Environment.Exit(0);

                }


              Console.Clear();
            } while (true);






        }






    }
}