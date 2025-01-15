using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FunWithUnitTesting.UserService;


namespace FunWithUnitTesting
{
    public interface IUserRepo
    {
        User GetUserFromDbByEmail(string email);

        string AddUserToDb(User user);

    }

    public interface IPasswordService
    {
        string Hash(string value);
    }
}
