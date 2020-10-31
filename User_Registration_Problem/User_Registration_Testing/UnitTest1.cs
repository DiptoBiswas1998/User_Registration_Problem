using Microsoft.VisualStudio.TestTools.UnitTesting;
using User_Registration_Problem;
namespace User_Registration_Testing
{
    [TestClass]
    public class UnitTest1
    {
        //Happy Test Cases(Test Cases Pass The Entries)
        [TestMethod]
        public void GivenUserFistName_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string firstName = "Dipto";
            //Act
            bool result = user.ValidateFirstName(firstName);
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
            bool result = user.ValidateFirstName(lastName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenEmailId_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string email = "dipto.biswas@gmail.com";
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
            string password = "Dipto@13579";
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsTrue(result);
        }
        //Sad Test Cases(Test Cases Fail The Entry)
        [TestMethod]
        public void GivenUserFistName_WhenValidate_Should_Throw_URCustomException_Indicating_Invalid_FirstName()
        {
            try
            {
                //Arrange
                ValidateUserRegistration user = new ValidateUserRegistration();
                string firstName = "Dipto";
                //Act
                bool result = user.ValidateFirstName(firstName);
            }
            catch (URCustomException e)
            {
                //Assert
                Assert.AreEqual("Invalid first name.", e.Message);
            }
        }
        [TestMethod]
        public void GivenUserLastName_WhenValidate_Should_Throw_URCustomException_Indicating_Invalid_LastName()
        {
            try
            {
                //Arrange
                ValidateUserRegistration user = new ValidateUserRegistration();
                string lastName = "Biswas";
                //Act
                bool result = user.ValidateLastName(lastName);
            }
            catch (URCustomException e)
            {
                //Assert
                Assert.AreEqual("Invalid last name.", e.Message);
            }
        }
        [TestMethod]
        public void GivenUserEmail_WhenValidate_Should_Throw_URCustomException_Indicating_Invalid_Email()
        {
            try
            {
                //Arrange
                ValidateUserRegistration user = new ValidateUserRegistration();
                string email = "dipto.biswas.gmail.com";
                //Act
                bool result = user.ValidateEmail(email);
            }
            catch (URCustomException e)
            {
                //Assert
                Assert.AreEqual("Invalid email address.", e.Message);
            }
        }
        [TestMethod]
        public void GivenUserMobileNumber_WhenValidate_Should_Throw_URCustomException_Indicating_Invalid_MobileNo()
        {
            try
            {
                //Arrange
                ValidateUserRegistration user = new ValidateUserRegistration();
                string mobileNumber = "11 0123456789";
                //Act
                bool result = user.ValidateMobileNo(mobileNumber);
            }
            catch (URCustomException e)
            {
                //Assert
                Assert.AreEqual("Invalid mobile number.", e.Message);
            }
        }
        [TestMethod]
        public void GivenUserPassword_WhenValidate_Should_Throw_URCustomException_Indicating_Invalid_Password()
        {
            try
            {
                //Arrange
                ValidateUserRegistration user = new ValidateUserRegistration();
                string password = "Dipto@13579";
                //Act
                bool result = user.ValidatePassword(password);
            }
            catch (URCustomException e)
            {
                //Assert
                Assert.AreEqual("Invalid password.", e.Message);
            }
        }
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void GivenEmailIds_WhenValidate_ShouldReturnTrue(string email)
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            //Act
            bool result = user.ValidateEmail2(email);
            //Assert
            Assert.IsTrue(result);
        }
    }
}
