using SSDInternalProject.ViewModels;
using System.Collections.Generic;

namespace SSDInternalProject.Controllers.Repositories {
    public class UserRepo {
        // Static data
        List<UserVM> myUserList = null;

        public UserRepo() {
            myUserList = new List<UserVM>();
            UserVM user1 = new UserVM();
            user1.UserVMId = 1;
            user1.Email = "John@my.bcit.ca";
            user1.FirstName = "John";
            user1.LastName = "Kimber";
            user1.MiddelInitial = "J.K";
            user1.PhoneNumber = "778123456";
            user1.StreetAddress = "Seymour St";
            user1.City = "Vancouver";
            user1.Province = "BC";
            user1.PostalCode = "V6B3H6";
            user1.Country = "Canada";
            myUserList.Add(user1);

            UserVM user2 = new UserVM();
            user2.UserVMId = 2;
            user2.Email = "John@my.bcit.ca";
            user2.FirstName = "Paul";
            user2.LastName = "Brain";
            user2.MiddelInitial = "P.B";
            user2.PhoneNumber = "778654321";
            user2.StreetAddress = "Seymour St";
            user2.City = "Vancouver";
            user2.Province = "BC";
            user2.PostalCode = "V6B3H6";
            user2.Country = "Canada";
            myUserList.Add(user2);
        }

        // Create
        public void Create(UserVM user) {
            // save change to DB in the future...
        }

        // Read
        public UserVM GetUserInfo(int id) {
            UserVM user = null;
            for (int i = 0; i < myUserList.Count; i++)
            {
                if (id == myUserList[i].UserVMId)
                {
                    user = myUserList[i];
                    break;
                }
            }
            return user;
        }

        public UserVM GetUserInfo(string name) {
            return myUserList[0];
        }

        public List<UserVM> GetUsrInfoList() {
            return myUserList;
        }

        // Update
        public void Update(UserVM user) {
            // save change to DB in the future...
        }

        // Delete
        public void Delete(int userId) {
            // save change to DB in the future...
        }

    }
}