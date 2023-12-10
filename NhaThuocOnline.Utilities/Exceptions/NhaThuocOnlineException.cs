using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhaThuocOnline.Utilities.Exceptions
{
    public class NhaThuocOnlineException : Exception
    {
        public NhaThuocOnlineException()
        {
        }

        public NhaThuocOnlineException(string message)
            : base(message)
        {
        }

        public NhaThuocOnlineException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
