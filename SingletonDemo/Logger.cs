using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo {
    public sealed class Logger {
        private static int counter = 0;
        public static readonly Lazy<Logger> logger = new Lazy<Logger>(() => new Logger());

        public static Logger GetLogger => logger.Value;
       

        private Logger() {
            counter++;
            Console.WriteLine("Counter value is: " +  counter.ToString());

        }
        public void PrintDetails(string message) {
            Console.WriteLine(message);
        }
    }
}
