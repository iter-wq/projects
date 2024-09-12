using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mat
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
            Console.ReadLine();
        }
    }
}
