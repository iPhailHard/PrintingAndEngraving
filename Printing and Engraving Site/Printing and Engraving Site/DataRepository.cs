using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Printing_and_Engraving_Site
{
    public class DataRepository
    {
        PrintingAndEngravingEntities _Context = new PrintingAndEngravingEntities();

        public List<User> GetUsers()
        {
            return (from e in _Context.Users
                    select e).ToList();
        }

        public int GetUserByPasswordAndUserName(string userName, string password)
        {
            try
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
            catch
            {
                return 0;
            }
        }

        public List<Item> GetItems()
        {
            return (from Items in _Context.Items
                    join Images in _Context.Images
                    on Items.ItemID equals Images.ItemID
                    select Items).ToList();
        }

        public Image GetImageByItemID(int ItemID)
        {
            Image image = _Context.Images.Where(q => q.ItemID == ItemID)
                                            .Select(q => q)
                                            .SingleOrDefault();

            return image;
        }
    }
}