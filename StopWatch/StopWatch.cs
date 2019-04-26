using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    public class StopWatch
    {
        public void StartTimer()
        {
            var startTime = new TimeSpan(0, 0, 0);
            // var startTime = DateTime.Now;
            // var endTime = 
            // var duration = endTime - startTime;
            //Console.WriteLine("Start Time: " + startTime);
            Console.WriteLine("Start Time: " + startTime.ToString());
            Console.Write("Please enter how long you want the watch to run: ");
            string input = Console.ReadLine();
            var duration = startTime + input;
        }

        public void StopTimer()
        {

        }
    }
}
