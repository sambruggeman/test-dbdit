using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dbdit.BLL.Entities.Base;
using dbdit.DAL.Entities;
using dbdit.DAL.Repositories;
using dbdit.BLL.Lib;
using dbdit.BLL.Models;

namespace dbdit.BLL.Entities
{
    public class Security : EntityBase, ISecurity
    {
        private readonly IRepository<DAL.Entities.UserProfile> _userProfileRepo;

        public Security(IRepository<DAL.Entities.UserProfile> userProfileRepo)
        {
            _userProfileRepo = userProfileRepo;
        }

        public int Login(LoginModel loginModel, out Lib.BResult result)
        {
            result = new BResult();

            var user = _userProfileRepo.Get().Where(x => x.UserName.Equals(loginModel.UserName, StringComparison.CurrentCultureIgnoreCase));
            if (user == null || user.Count() != 1)
            {
                result.AddError("error", "not found");
                return -1;
            }
            else
            {
                return user.First().Id;
            }
        }

        public bool IsInRole(string userName, string roleName)
        {
            return false;
        }
    }
}
