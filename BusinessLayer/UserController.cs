using Model;

namespace BusinessLayer
{
    public class UserController
    {
        #region Attributes

        /// <summary>
        /// Attribute that is being used to give an error in the GUI. Its set to true if exceptions are encounterd
        /// </summary>
        public bool UserError { get; set; }
        /// <summary>
        /// The user that is logged in. Is used to handle permissions
        /// </summary>
        public static User LoggedInUser { get; set; }

        #endregion


        /// <summary>
        /// Login function. 
        /// </summary>
        public bool Login(string userN, string userP)
        {
            IEnumerable<User> users = PublicMedia_Controller.Instance.Context.UserRepository.GetAll();
            foreach (User user in users)
            {
                if (user.UserName == userN && user.Password == userP)
                {
                    LoggedInUser = user;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Creates a list of users
        /// </summary>
        /// <returns></returns>
        public List<User> GetUserList()
        {
            var query1 = from p in PublicMedia_Controller.Instance.Context.UserRepository.GetAll()
                         select p;

            return query1.ToList();
        }

       /// <summary>
       /// Method to create user
       /// </summary>
       /// <param name="userName"></param>
       /// <param name="password"></param>
       /// <param name="acess"></param>
       /// <param name="role"></param>
       /// <param name="fName"></param>
       /// <param name="lName"></param>
        public void CreateUser(string userName, string password, string acess, string role, string fName, string lName )
        {
            try
            {
                User newUser = new User();
                IEnumerable<User> users = PublicMedia_Controller.Instance.Context.UserRepository.GetAll();

                    newUser.UserId = 0;
                    newUser.UserName = userName;
                    newUser.Password = password;
                  newUser.AcessRights = acess;
                newUser.Role = role;
                newUser.FirstName = fName;
                newUser.LastName = lName;
            }
            catch (NullReferenceException e)
            {
                UserError = true;
            }
        }

        /// <summary>
        /// Method to update a users password.
        /// </summary>
        /// <param name="userN"></param>
        /// <param name="newPassword"></param>
        public void UpdatePassword(string userN, string newPassword)
        {
            try
            {
                IEnumerable<User> Users = PublicMedia_Controller.Instance.Context.UserRepository.GetAll();
                User UpdatedPassword = new User();
                var p = from q in Users
                        where q.UserName.Equals(userN)
                        select q;

                    if (UpdatedPassword.UserName != p.First().UserName)
                    {
                        UpdatedPassword.Password = newPassword;

                        foreach (var item in Users.Where(x => x.UserName == p.First().UserName))
                        {
                            item.Password = newPassword;
                        }
                        PublicMedia_Controller.Instance.Save();
                    }
            }
            catch (NullReferenceException e)
            {
                UserError = true;
            }
        }

        /// <summary>
        /// Method to update a users permission.
        /// </summary>
        /// <param name="userN"></param>
        /// <param name="newAcess"></param>
        public void UpdatePermission(string userN, string newAcess)
        {
            try
            {
                IEnumerable<User> Users = PublicMedia_Controller.Instance.Context.UserRepository.GetAll();
                var p = from q in Users
                        where q.UserName.Equals(userN)
                        select q;

                User updatedAcess = new User();

                    if (updatedAcess.UserName != p.First().UserName)
                    {
                        foreach (var item in Users.Where(x => x.UserName == p.First().UserName))
                        {
                            item.AcessRights = newAcess;
                        }
                        PublicMedia_Controller.Instance.Save();
                    }
            }
            catch (NullReferenceException e)
            {
                UserError = true;
            }
        }
    }
}