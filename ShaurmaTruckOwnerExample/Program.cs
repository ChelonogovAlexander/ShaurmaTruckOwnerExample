using System;
using System.IO;
using ConsoleApplication1.V5;

namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var shaurmaOwner = new ShaurmaTruckOwner(
                new ZinaidaCleaner(),
                new AshotCooker(),
                new VasiliyDriver(),
                new IrinaCashier());

            shaurmaOwner.WorkingCycle();

            Console.ReadLine();
        }
    }
}
