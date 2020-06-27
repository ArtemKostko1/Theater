using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theater.Classes
{
	public class PrfessionsName
	{
        public int UserId { get; set; }
        public string ProfessionName { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public string UserFIO { get; set; }
        public Nullable<System.DateTime> UserDOB { get; set; }
        public string UserSex { get; set; }
        public string UserHight { get; set; }
        public string UserExperience { get; set; }
        public string UserSalary { get; set; }
        public Nullable<int> UserСhildrens { get; set; }
        public string UserAwards { get; set; }
    }
}
