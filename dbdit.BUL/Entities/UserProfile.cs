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
    public class UserProfile : EntityBase, IUserProfile
    {
        private readonly IRepository<DAL.Entities.UserProfile> _userProfileRepo;

        public UserProfile(IRepository<DAL.Entities.UserProfile> userProfileRepo)
        {
            _userProfileRepo = userProfileRepo;
        }

        public UserProfileModel GetById(int id, out Lib.BResult result)
        {
            result = new BResult();
            var userDal = _userProfileRepo.Find(id);
            if (userDal == null)
            {
                result.AddError("error", "not found in db");
                return null;
            }

            var user = new UserProfileModel(userDal);
            if (user == null)
            {
                result.AddError("error", "error converting to bll");
                return null;
            }
            else
            {
                return user;
            }
        }
    }
}
