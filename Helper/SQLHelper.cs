using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace LoginAPI.Helper
{
    public class SQLHelper
    {
        #region Declaration

        string connection = ConfigurationManager.ConnectionStrings["Connection"].ToString();
        #endregion
    }
}