using FunWithUnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FunWithUnitTesting.UserService;

namespace UnitTestOne
{
    public class UserServiceTester
    {
        //[Fact]

        //public void RegistrationTest_return_ok()
        //{
        //    var service = new UserService(new UserRepoFake(), new PasswordServiceFake());
        //    var user = new User{ Email = "test@wp.pl", Password = "password1" };

        //    var result = service.RegistryUser(user);

        //    Assert.Equal("OK",result);
        //}
        //[Fact]
        //public void RegistrationTest_return_incorrect_password_error_length ()
        //{
        //    var service = new UserService(new UserRepoFake(), new PasswordServiceFake());
        //    var user = new User { Email = "test@wp.pl", Password = "pass" };

        //    var result = service.RegistryUser(user);
        //    Assert.NotEmpty(result);
        //    Assert.Equal("haslo ma mniej za 8 symbolow", result);
        //}
        //[Fact]
        //public void RegistrationTest_return_incorrect_password_error_null()
        //{
        //    var service = new UserService(new UserRepoFake(), new PasswordServiceFake());
        //    var user = new User { Email = "test@wp.pl", Password = "" };

        //    var result = service.RegistryUser(user);
        //    Assert.NotEmpty(result);
        //    Assert.Equal("haslo jest puste", result);
        //}
        //[Fact]

        //public void RegistrationTest_return_error_null_user()
        //{
        //    var service = new UserService(new UserRepoFake(), new PasswordServiceFake());
        //    var user = (User)null;

        //    var result = service.RegistryUser(user);

        //    Assert.Equal("User must be not null", result);
        //}
        //[Fact]

        //public void RegistrationTest_return_error_registred_mail()
        //{
        //    var service = new UserService(new UserRepoFakeRegistredEmail(), new PasswordServiceFake());
        //    var user = new User { Email = "test@wp.pl", Password = "password1" };

        //    var result = service.RegistryUser(user);

        //    Assert.Equal("Email jest zajety", result);
        //}
        //[Fact]

        //public void RegistrationTest_return_error_add_to_db()
        //{
        //    var service = new UserService(new UserRepoFakeFree(), new PasswordServiceFake());
        //    var user = new User { Email = "test@wp.pl", Password = "password1" };

        //    var result = service.RegistryUser(user);

        //    Assert.Equal("err", result);
        //}



        [Fact]
        public void RegistrationTest_return_ok()
        {
            var userRepo = new Mock<IUserRepo>();
            userRepo.Setup(ur => ur.GetUserFromDbByEmail(It.IsAny<string>())).Returns((User)null);
            userRepo.Setup(ur => ur.AddUserToDb(It.IsAny<User>())).Returns(String.Empty);

            var passwordService = new Mock<IPasswordService>();
            passwordService.Setup(ps => ps.Hash(It.IsAny<string>())).Returns("pass");


            var service = new UserService(userRepo.Object, passwordService.Object);
            var user = new User { Email = "test@wp.pl", Password = "password1" };

            var result = service.RegistryUser(user);

            Assert.Equal("OK", result);
        }

        [Fact]
        public void RegistrationTest_return_incorrect_password_error_length()
        {
            var userRepo = new Mock<IUserRepo>();
            var passwordService = new Mock<IPasswordService>();

            var service = new UserService(userRepo.Object, passwordService.Object);
            var user = new User { Email = "test@wp.pl", Password = "pass" };

            var result = service.RegistryUser(user);

            Assert.NotEmpty(result);
            Assert.Equal("haslo ma mniej za 8 symbolow", result);
        }

        [Fact]
        public void RegistrationTest_return_incorrect_password_error_null()
        {
            var userRepo = new Mock<IUserRepo>();
            var passwordService = new Mock<IPasswordService>();

            var service = new UserService(userRepo.Object, passwordService.Object);
            var user = new User { Email = "test@wp.pl", Password = String.Empty };

            var result = service.RegistryUser(user);

            Assert.Equal("haslo jest puste", result);
        }

        [Fact]
        public void RegistrationTest_return_null_user_error()
        {
            var userRepo = new Mock<IUserRepo>();
            var passwordService = new Mock<IPasswordService>();

            var service = new UserService(userRepo.Object, passwordService.Object);
            var user = (User)null;

            var result = service.RegistryUser(user);

            Assert.Equal("User must be not null", result);
        }

        [Fact]
        public void RegistrationTest_return_get_from_db_error()
        {
            var userRepo = new Mock<IUserRepo>();
            userRepo.Setup(ur => ur.GetUserFromDbByEmail(It.IsAny<string>())).Returns(new User());
            var passwordService = new Mock<IPasswordService>();

            var service = new UserService(userRepo.Object, passwordService.Object);
            var user = new User { Email = "test@wp.pl", Password = "password1" };

            var result = service.RegistryUser(user);

            Assert.Equal(result, "Email jest zajety");
        }

        [Fact]
        public void RegistrationTest_return_add_to_db_error()
        {
            var userRepo = new Mock<IUserRepo>();
            userRepo.Setup(ur => ur.AddUserToDb(It.IsAny<User>())).Returns("err");
            var passwordService = new Mock<IPasswordService>();

            var service = new UserService(userRepo.Object,passwordService.Object);
            var user = new User { Email = "test@wp.pl", Password = "password1" };

            var result = service.RegistryUser(user);

            Assert.Equal(result,"err");
        }

    }

}
