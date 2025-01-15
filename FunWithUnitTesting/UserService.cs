using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithUnitTesting
{
    public class UserService
    {
        private readonly IUserRepo userRepo;
        private readonly IPasswordService passwordService;

        public UserService(IUserRepo userRepo, IPasswordService passwordService)
        {
            this.userRepo = userRepo;
            this.passwordService = passwordService;
        }
        public string RegistryUser(User user)
        {
            //sprawzam email

            if (user is null) return "User must be not null";


            var error = CheckPassword(user.Password);

            if (!string.IsNullOrEmpty(error))
            {

                return error;
            }

            var userFromDb = userRepo.GetUserFromDbByEmail(user.Email);

            if (userFromDb != null)
            {
                return "Email jest zajety";
            }

            var hashedPassword = passwordService.Hash(user.Password);

            error = userRepo.AddUserToDb(new User { Email = user.Email, Password = hashedPassword });

            if (!string.IsNullOrEmpty(error))
            {
                return error;
            }


            return "OK";
        }

        private string CheckPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return "haslo jest puste";
            }
            if (password.Length < 8)
            {
                return "haslo ma mniej za 8 symbolow";
            }
            return "";
        }

        public class User
        {

            public string Email { get; set; }
            public string Password { get; set; }
        }
    }
    //private User ReadDB(string query)
    //{
    //    var list = new List<Song>();
    //    using (var sqlConnection = new SqlConnection(_connectionString))
    //    {
    //        sqlConnection.Open();
    //        using (var sqlCommand = new SqlCommand(query, sqlConnection))
    //        {
    //            var reader = sqlCommand.ExecuteReader();
    //            while (reader.Read())
    //            {
    //                var id = int.Parse(reader["Id"].ToString());
    //                var title = reader["Title"].ToString();
    //                var album = reader["Album"].ToString();
    //                var year = int.Parse(reader["Year"].ToString());
    //                var artist = reader["Artist"].ToString();
    //                var song = new Song(id, title, album, year, artist);
    //                list.Add(song);
    //            }
    //        }
    //    }
    //    return list.ToArray();
    //}
    
   
}
