using SSDInternalProject.ViewModels;

namespace SSDInternalProject.Controllers.Repositories {
    public class AccountRepo {
        public void CreateAccount(string Name, string Password, 
                string Phone, string Address) {
            // save change to DB in the future...
        }

        public AccountVM GetAccountInfo(string userName) {
            // Hard code now, query the DB in the future
            return CreateFakeAccount();
        }

        public AccountVM GetAccountInfoByID(int ID) {
            // Hard code now, query the DB in the future
            return CreateFakeAccount();
        }

        public AccountVM CreateFakeAccount() {
            // Hard code now, query the DB in the future
            AccountVM item = new AccountVM();
            item.ID = 1;
            item.Name = "Pat";
            item.Password = "1234";
            item.Phone = "778123456";
            item.Address = "V6B 3H6";
            return item;
        }
        
        public void EditAccount(AccountVM aVm) {
            // save change to DB in the future...
        }
        
    }
}