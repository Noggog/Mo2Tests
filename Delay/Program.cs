using System;
using System.Threading.Tasks;

namespace Delay
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Task.Delay(15000);
        }
    }
}
