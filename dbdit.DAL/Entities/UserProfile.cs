using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dbdit.DAL.Entities.Base;

namespace dbdit.DAL.Entities
{
    public class UserProfile: EntityBase
    {
        public string UserName { get; set; }
        
        public string Email { get; set; }
    }
}
