using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploConstrutores.Model
{
    public class Log
    {
        private static Log? _log;
        public string PropriedadeLog { get; set; }

        private Log()
        {
            PropriedadeLog = string.Empty;
        }

        public static Log GetInstance()
        {
            if (_log == null)
                _log = new Log();

            return _log;
        }
    }
}