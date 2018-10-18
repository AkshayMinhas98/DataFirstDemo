using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DataFirstDemoContext();
            var data = new DataFirst_Table()
            {
                PostID = 100,
                DateofPublish = DateTime.Now,
                Title = "When Air Become Breath",
                Body = "asdadalhhivoirghhaoupejksfchfcpf"

            };
            context.DataFirst_Table.Add(data);
            context.SaveChanges();
            //Console.WriteLine($"Title = {context.DataFirst_Table}");
            Console.ReadKey();
        }
    }
}
