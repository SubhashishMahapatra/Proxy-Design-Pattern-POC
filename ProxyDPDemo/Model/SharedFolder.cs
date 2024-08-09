using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxyDPDemo.Global_Interface;

namespace ProxyDPDemo.Model
{
    public class SharedFolder : ISharedFolder
    {
        public void ReadWriteOperation()
        {
            Console.WriteLine("This is Original Folder");
            Console.WriteLine("Performed Read Write Operation");
        }
    }
}
