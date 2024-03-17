using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata;

namespace FileAppOne
{
    internal class Program
    {

        static async Task Main(string[] args)
        {

            string path = "C:\\Users\\huseyn.hasanli\\Desktop\\PB501Local\\FileOperations\\sinif11.txt";
            // File.Create(path);
         //   List<string> list = new List<string>() { "Rustem", "Nermin", "Ekber", "Fizuli", "Eli", "Yusif", "Nihat", "Ugur" };

           
          
            Console.WriteLine("Islem basladi");

            writeListAsync(path);

            Console.WriteLine("Islem bitdi");
        }

       
        public async static Task writeListAsync(string path)
        {
            List<string> listNew = new List<string>();

            Task task = new Task(() =>
            {
                for (int i = 0; i < 10000000; i++)
                {
                    listNew.Add(Guid.NewGuid().ToString());
                }
                File.AppendAllText(path, string.Join(',', listNew));
            });

            task.Start();
            task.Wait();
          

        }

    }
}
