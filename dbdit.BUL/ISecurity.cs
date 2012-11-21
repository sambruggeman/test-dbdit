using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dbdit.BLL.Base;
using dbdit.BLL.Lib;
using dbdit.BLL.Models;

namespace dbdit.BLL
{
    public interface ISecurity: IEntityBase
    {
        int Login(LoginModel loginModel, out BResult result);
        bool IsInRole(string userName, string roleName);
    }
}
