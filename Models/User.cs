using System;

namespace Silkroski_C969.Models
{
    public class User // user == consultant per FAQ
    {
        #region Properties / Fields
        // All these are from the Database ERD
        public int UserId { get; set; } // INT, Primary Key
        public string UserName { get; set; } // VARCHAR(50)
        public string Password { get; protected set; } // VARCHAR(50)
        private byte Active { get; set; } // TINYINT in MySQL is just a byte
        // Found on https://www.tutorialspoint.com/What-is-the-Chash-Equivalent-of-SQL-Server-DataTypes

        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; } // VARCHAR(40)
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; } // VARCHAR(40)

        #endregion

        #region Constructors

        public User()
        {

        }

        public User(int userId, string userName, string password, byte active, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            UserId = userId;
            UserName = userName;
            Password = password;
            Active = active;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }

        public User(string userName, string password, byte active)
        {
            UserName = userName;
            Password = password;
            Active = active;
        }

        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
        #endregion
    }
}
