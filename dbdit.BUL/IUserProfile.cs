using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dbdit.BLL.Models;

namespace dbdit.BLL
{
    public interface IUserProfile
    {
        UserProfileModel GetById(int id, out Lib.BResult result);
    }
}
