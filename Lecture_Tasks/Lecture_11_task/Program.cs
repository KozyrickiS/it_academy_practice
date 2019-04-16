using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_11_task
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseDir = ApplicationSettings.BaseDirectory;
            var baseDir1 = ApplicationSettings.BaseDirectory;

            UnigueItem.EnterId(5);
            UnigueItem item1 = new UnigueItem();
            UnigueItem item2 = new UnigueItem();
            UnigueItem item3 = new UnigueItem();
            UnigueItem item4 = new UnigueItem();
            UnigueItem item5 = new UnigueItem();

            Console.WriteLine(UnigueItem.Id);
            Console.ReadKey();
        }

        static class ApplicationSettings
        {
            public static string BaseDirectory { get; set; }
            static ApplicationSettings()
            {
                BaseDirectory = Environment.CurrentDirectory;
            }
        }
        public class UnigueItem
        {
            public static int Id { get; set; }
            public UnigueItem()
            {
                Id++;
            }
            public static void EnterId(int id)
            {
                Id = id;
            }
        }
    }
}
