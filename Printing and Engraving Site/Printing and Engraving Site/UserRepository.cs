using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Printing_and_Engraving_Site
{
    public class UserRepository
    {
        PrintingAndEngravingEntities _Context = new PrintingAndEngravingEntities();

        public List<User> GetUsers()
        {
            return (from e in _Context.Users
                    select e).ToList();
        }

        public int GetUserByPasswordAndUserName(string userName, string password)
        {
            int? userRole = _Context.Users.Where(s => s.UserName == userName && s.UserPassword == password)
                            .Select(q => q.UserRoleID).SingleOrDefault();

            if (userRole != null)
            {
                return (int)userRole;
            }
            else
            {
                return 0;
            }
        }
    }
}