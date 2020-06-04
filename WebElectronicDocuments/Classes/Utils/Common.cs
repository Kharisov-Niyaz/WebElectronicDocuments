using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebElectronicDocuments.Classes.Utils
{
    public class Common
    {
        public enum ErrorCode
        {
            NO_ERROR,
            SAVE_ERROR,
            EMAIL_EXIST,
            USER_NOT_FOUND
        };
    }
}
