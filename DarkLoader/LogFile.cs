﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkLoader
{
    class LogFile
    {
        public static void WriteToLog(string text)
        {
            using (StreamWriter sw = File.AppendText("Rogue.log"))
            {
                sw.WriteLine(System.DateTime.Now + ":" + text);
            }
        }
    }
}