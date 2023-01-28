using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection
{
    public class DisposeSample : IDisposable
    {
        public void Dispose()
        {
            Cleaning(true);
            GC.SuppressFinalize(this);
        }

        ~DisposeSample()
        {
            Cleaning(false);
        }

        public bool isDisposed = false;

        public void Cleaning(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Releasing managed resources");
                }
                Console.WriteLine("Releasing unmanaged resources");
            }
            isDisposed = true;
        }
        
    }
}
