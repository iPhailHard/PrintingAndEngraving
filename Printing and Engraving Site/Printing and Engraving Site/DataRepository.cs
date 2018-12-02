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

        #region SecuritySession

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

        public int GetUserIDByPasswordAndUserName(string userName, string password)
        {
            try
            {
                int userID = _Context.Users.Where(s => s.UserName == userName && s.UserPassword == password)
                                            .Select(q => q.UserID).SingleOrDefault();

                if (userID < 0)
                {
                    return userID;
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

        #endregion

        #region Orders
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

        public List<Order> GetUserOrderByUserID(int UserID)
        {
            List<Order> orders = _Context.Orders.Where(q => q.UserID == UserID)
                                                .Select(q => q).ToList();

            return orders;
        }

        public bool SaveOrder(Order order)
        {
            bool IsSaved = false;

            Order data = new Order();

            try
            {
                data.Item = order.Item;
                data.OrderDate = DateTime.Now;
                data.OrderNote = order.OrderNote;
                data.TotalPrice = order.TotalPrice;
                data.UserID = order.UserID;
                data.IsOrderComplete = order.IsOrderComplete;
                data.ItemQuantity = order.ItemQuantity;
                data.IsPaid = order.IsPaid;
                data.IsCOD = order.IsCOD;
                data.CustomEngravingMessage = order.CustomEngravingMessage;
                data.OrderDate = order.OrderDate;

                _Context.Orders.Add(data);
                _Context.SaveChanges();

            }
            catch (Exception ex)
            {
                return IsSaved;
            }

            return IsSaved = true;

        }
        #endregion

        #region Checkout

        public bool SavePaymentInformation(Checkout check)
        {
            bool IsSaved = false;

            Checkout chkout = new Checkout();

            //try
            //{
                chkout.UserID = check.UserID;
                chkout.OrderID = check.OrderID;
                chkout.TotalPrice = check.TotalPrice;
                chkout.DateCompleted = check.DateCompleted;
                chkout.CardHolderZip = check.CardHolderZip;
                chkout.CardHolderState = check.CardHolderState;
                chkout.CardHolderCity = check.CardHolderCity;
                chkout.CardHolderAddress1 = check.CardHolderAddress1;
                chkout.CardHolderAddress2 = check.CardHolderAddress2;
                chkout.CardNumber = check.CardNumber;
                chkout.CardHolderName = check.CardHolderName;

                _Context.Checkouts.Add(chkout);
                _Context.SaveChanges();
            //}
            //catch
            //{
            //    return IsSaved;
            //}
            return IsSaved = true;   
        }

        #endregion
    }
}