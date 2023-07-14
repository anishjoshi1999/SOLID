using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace SolidDesignPattern.Client
{
    class HPLaserJet : IPrintScanContent
    {
        public bool PrintContent(string content)
        {
            Console.WriteLine("Printing content: " + content);
            return true;
        }

        public bool ScanContent(string content)
        {
            Console.WriteLine("Scanning content: " + content);
            return true;
        }
        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("Photocopying content: " + content);
            return true;
        }
    }
}
