using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithUnitTesting
{
    public class UserRepoFake : IUserRepo
    {
        public string AddUserToDb(UserService.User user)
        {
            return string.Empty;
        }

        public UserService.User GetUserFromDbByEmail(string email)
        {
            return null;
        }
    }
}
