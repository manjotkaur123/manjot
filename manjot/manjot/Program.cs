using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace manjot
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Peter Rules the IT Universe!");

            Download();

            Console.ReadLine();

        }



        static async void Download()

        {
            HttpClient client = new HttpClient();

           var data = await client.GetStringAsync("https://moodle.cestarcollege.com");


            Console.WriteLine(data);
            List mylist = new List();
        }

        class Network

        {

            static public Task Download()

            {

                return Task.Run(() => Thread.Sleep(3000));

            }

        }

    }

}