using System;
using ShaurmaTruckOwnerExample.V5;

namespace ShaurmaTruckOwnerExample
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
