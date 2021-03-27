using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapperProfileExample.Dto
{
    public class UserInfo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
    }

   public class ListofUserInfo
   {
       public IList<UserInfo> data { get; set; }
   }
}
