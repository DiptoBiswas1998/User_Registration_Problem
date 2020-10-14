using Microsoft.VisualStudio.TestTools.UnitTesting;
using User_Registration_Problem;
namespace User_Registration_Testing
{
    [TestClass]
    public class UnitTest1
    {
        //Happy Test Cases(Test Cases Pass The Entries)
        [DataRow("Dipto")]
        [TestMethod]
        public void GivenUserFistName_WhenValidate_ShouldReturnTrue(string msg)
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            //string firstName = "Dipto";
            //Act
            bool result = user.ValidateFirstName(msg);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenUserLastName_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string lastName = "Biswas";
            //Act
            bool result = user.ValidateLastName(lastName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenEmailId_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string email = "diptobiswas1998@gmail.com";
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenMobileNumber_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string mobileNumber = "91 9876543210";
            //Act
            bool result = user.ValidateMobileNo(mobileNumber);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenPassword_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string password = "Dipto@1998";
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsTrue(result);
        }
        //Sad Test Cases(Test Cases Fail The Entry)
        [TestMethod]
        public void GivenUserFistName_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string firstName = "dipto";
            //Act
            bool result = user.ValidateFirstName(firstName);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenUserLastName_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string lastName = "biswas";
            //Act
            bool result = user.ValidateLastName(lastName);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenEmailId_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string email = "diptobiswas1998";
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenMobileNumber_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string mobileNumber = "91 0123456789";
            //Act
            bool result = user.ValidateMobileNo(mobileNumber);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenPassword_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string password = "dipto@1998";
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsFalse(result);
        }
    }
}
