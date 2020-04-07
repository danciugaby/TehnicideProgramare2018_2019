using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    class ExceptionLogger
    {
        ILogger _logger;
        public ExceptionLogger(ILogger aLogger)
        {
            this._logger = aLogger;
        }

        public void LogException(Exception aException)
        {
            string strMessage = GetUserReadableMessage(aException);
            this._logger.LogMessage(strMessage);
        }



        private string  GetUserReadableMessage(Exception ex)
        {
            string strMessage = string.Empty;  
     
            return strMessage;
        }
    }
}
