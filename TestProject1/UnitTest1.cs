using ClassLibrary1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstNameIsNotEmpty()
        {
            var user = new DummyUser();
            var presenter = new UserInfoPresenter(user);

            user.FirstName = "Bob";
            user.LastName = "Booooob";
            user.Email = "Bob@";
            user.Phone = "+74735762867";
            user.Place_of_residence = "Russia";
            user.Gender = "Male";
            user.Save();

            Assert.AreEqual(expected: "Bob", actual: user.FirstName, message: "The FirstName field should be initialized as Bob");
            Assert.IsFalse(user.ShowFormErrors, "Null first name should trigger validation error");
            Assert.AreEqual(expected: null, actual: user.ErrorMessage, "Empty FirstName should have correct error msg");
        }

        [TestMethod]
        public void LastNameIsNotEmpty()
        {
            var user = new DummyUser();
            var presenter = new UserInfoPresenter(user);

            user.FirstName = "Bob";
            user.LastName = "Booooob";
            user.Email = "Bob@";
            user.Phone = "+74735762867";
            user.Place_of_residence = "Russia";
            user.Gender = "Male";
            user.Save();

            Assert.AreEqual(expected: "Booooob", actual: user.LastName, message: "The Email field should be initialized as Booooob");
            Assert.IsFalse(user.ShowFormErrors, "Null LastName should trigger validation error");
            Assert.AreEqual(expected: null, actual: user.ErrorMessage, "Empty LastName should have correct error msg");
        }

        [TestMethod]
        public void EmailIsNotEmpty()
        {
            var user = new DummyUser();
            var presenter = new UserInfoPresenter(user);

            user.FirstName = "Bob";
            user.LastName = "Booooob";
            user.Email = "Bob@";
            user.Phone = "+74735762867";
            user.Place_of_residence = "Russia";
            user.Gender = "Male";
            user.Save();

            Assert.AreEqual(expected: "Bob@", actual: user.Email, message: "The Email field should be initialized as Bob@");
            Assert.IsFalse(condition: user.ShowFormErrors, message: "An appropriate filled in Email should not trigger an error");
            Assert.AreEqual(expected: null, actual: user.ErrorMessage, "Filled in Email should remove error message");
        }

        [TestMethod]
        public void EmailHasAtSymbol()
        {
            var user = new DummyUser();
            var presenter = new UserInfoPresenter(user);

            user.FirstName = "Bob";
            user.LastName = "Booooob";
            user.Email = "Bob@";
            user.Phone = "+74735762867";
            user.Place_of_residence = "Russia";
            user.Gender = "Male";
            user.Save();

            Assert.AreEqual(expected: "Bob@", actual: user.Email, message: "The Email field should be initialized as 'Bob@'");
            Assert.IsFalse(user.ShowFormErrors, "Invalid Email should trigger validation error");
            Assert.AreEqual(expected: null, actual: user.ErrorMessage, "Incorrecct Email should have correct error msg") ;
        }

        [TestMethod]
        public void Place_of_residenceIsRussia_Eng()
        {
            var user = new DummyUser();
            var presenter = new UserInfoPresenter(user);

            user.FirstName = "Bob";
            user.LastName = "Booooob";
            user.Email = "Bob@";
            user.Phone = "+74735762867";
            user.Place_of_residence = "Russia";
            user.Gender = "Male";
            user.Save();

            Assert.AreEqual(expected: "Russia", actual: user.Place_of_residence, message: "The Place of residence field should be initialized as Russia");
            Assert.IsFalse(condition: user.ShowFormErrors, message: "An appropriate filled in Place of residence should not trigger an error");
            Assert.AreEqual(expected: null, actual: user.ErrorMessage, "Filled in Place of residence should remove error message");
        }

        [TestMethod]
        public void Place_of_residenceIsRussia_Rus()
        {
            var user = new DummyUser();
            var presenter = new UserInfoPresenter(user);

            user.FirstName = "Bob";
            user.LastName = "Booooob";
            user.Email = "Bob@";
            user.Phone = "+74735762867";
            user.Place_of_residence = "Россия";
            user.Gender = "Male";
            user.Save();

            Assert.AreEqual(expected: "Россия", actual: user.Place_of_residence, message: "The Place of residence field should be initialized as Россия");
            Assert.IsFalse(condition: user.ShowFormErrors, message: "An appropriate filled in Place of residence should not trigger an error");
            Assert.AreEqual(expected: null, actual: user.ErrorMessage, "Filled in Place of residence should remove error message");
        }

        [TestMethod]
        public void GenderMale()
        {
            var user = new DummyUser();
            var presenter = new UserInfoPresenter(user);

            user.FirstName = "Bob";
            user.LastName = "Booooob";
            user.Email = "Bob@";
            user.Phone = "+74735762867";
            user.Place_of_residence = "Russia";
            user.Gender = "Male";
            user.Save();

            Assert.AreEqual(expected: "Male", actual: user.Gender, message: "The Gender field should be initialized as Male");
            Assert.IsFalse(condition: user.ShowFormErrors, message: "An appropriate filled in Gender should not trigger an error");
            Assert.AreEqual(expected: null, actual: user.ErrorMessage, "Filled in Gender should remove error message");
        }

        [TestMethod]
        public void GenderFemale()
        {
            var user = new DummyUser();
            var presenter = new UserInfoPresenter(user);

            user.FirstName = "Bob";
            user.LastName = "Booooob";
            user.Email = "Bob@";
            user.Phone = "+74735762867";
            user.Place_of_residence = "Russia";
            user.Gender = "Female";
            user.Save();

            Assert.AreEqual(expected: "Female", actual: user.Gender, message: "The Gender field should be initialized as Female");
            Assert.IsFalse(condition: user.ShowFormErrors, message: "An appropriate filled in Gender should not trigger an error");
            Assert.AreEqual(expected: null, actual: user.ErrorMessage, "Filled in Gender should remove error message");
        }

    }

    class DummyUser : IUserInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Place_of_residence { get; set; }
        public string Gender { get; set; }
        public string ErrorMessage { get; set; }
        public bool ShowFormErrors { get; set; }
        public event EventHandler? SaveAttempted;

        // Imitate button click s
        public void Save() => SaveAttempted?.Invoke(this, EventArgs.Empty);
    }
}