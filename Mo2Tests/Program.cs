using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mo2Tests
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //System.Console.WriteLine("Started single subprocess");
            //var process = Process.Start("Delay.exe");
            //await Task.Delay(2000);
            //process.Kill();
            //process.WaitForExit();
            //System.Console.WriteLine("Killed single subprocess");
            //System.Console.WriteLine("Press enter to continue");
            //System.Console.ReadLine();

            System.Console.WriteLine("Started subprocesses");
            await Task.WhenAll(Enumerable.Range(0, 25).Select(_ => Task.Run(async () =>
            {
                var process = Process.Start("Delay.exe");
                await Task.Delay(2000);
                process.Kill();
                process.WaitForExit();
            })));
            System.Console.WriteLine("Killed subprocesses");
            System.Console.WriteLine("Press enter to exit");
            System.Console.ReadLine();
        }
    }
}
