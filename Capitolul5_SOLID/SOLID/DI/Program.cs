﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    class Program
    {
        static void Main(string[] args)
        {
            DataExporter de = new DataExporter();
            de.ExportDataFromFile();
        }
    }
}
