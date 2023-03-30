using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo {
    class Program {
        static void Main(string[] args) {
            Parallel.Invoke(() => PrintLog1(),
                () => PrintLog2());
            Console.ReadLine();
        }

        private static void PrintLog2() {
            var log2 = Logger.GetLogger;
            log2.PrintDetails("Log 2 message");
        }

        private static void PrintLog1() {
            var log1 = Logger.GetLogger;
            log1.PrintDetails("Log 1 message");
        }
    }
}
