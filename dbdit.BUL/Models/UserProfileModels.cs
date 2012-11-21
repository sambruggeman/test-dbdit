using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dbdit.DAL.Entities;

namespace dbdit.BLL.Models
{
    public class UserProfileModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public UserProfileModel()
        {

        }

        public UserProfileModel(UserProfile userProfile)
        {
            this.Id = userProfile.Id;
            this.UserName = userProfile.UserName;
            this.Email = userProfile.Email;
        }
    }
}
