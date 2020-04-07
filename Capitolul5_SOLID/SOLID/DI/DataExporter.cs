using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public class DataExporter
    {
        public void ExportDataFromFile()
        {
            try
            {
                int b = 0;
                int a = 1 / b; ;  
            }
            catch (IOException ex)
            {
                new ExceptionLogger(new DbLogger()).LogException(ex);
            }
            catch (ArithmeticException ex)
            {
                new ExceptionLogger(new EventLogger()).LogException(ex);
            }
            catch (Exception ex)
            {
                new ExceptionLogger(new FileLogger()).LogException(ex);
            }
        }
    }
}
