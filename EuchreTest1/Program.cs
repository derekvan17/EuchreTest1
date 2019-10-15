﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace EuchreTest1
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Game.Init();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ImportDLL.Import();

            var form = new Form1();
            Application.Run(form);
        }
    }
}
