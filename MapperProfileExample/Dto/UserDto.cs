using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapperProfileExample.Dto
{
    public class UserDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public ListofUserInfo JsonString { get; set; }
        public long Age { get; set; }
    }
}
