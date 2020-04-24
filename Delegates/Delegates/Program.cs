using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;

            //processor.Process("photo1.jpg");

            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo1.jpg", filterHandler);
        }

        static void RemoveRedEyeFilter (Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
        }
    }
}
