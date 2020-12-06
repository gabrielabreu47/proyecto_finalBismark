using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public sealed class UserLogged
    {
        public User user { get; set; } = null;

        public static UserLogged Instance { get; } = new UserLogged();

        public void logIn(DataTable dt)
        {
            User user = new User();
            user.ID = Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString());
            user.NAME = dt.Rows[0].ItemArray[1].ToString();
            user.LASTNAME = dt.Rows[0].ItemArray[2].ToString();
            user.BIRTH = Convert.ToDateTime(dt.Rows[0].ItemArray[3].ToString());
            user.TYPE = Convert.ToInt32(dt.Rows[0].ItemArray[4].ToString());
            user.USER = dt.Rows[0].ItemArray[5].ToString();
            user.PASSWORD = dt.Rows[0].ItemArray[6].ToString();
            user.CAREER = dt.Rows[0].ItemArray[7].ToString();
            user.MAIL = dt.Rows[0].ItemArray[8].ToString();
            this.user = user;
        }
        public void logOut()
        {
            User user = new User();
            user.ID = 0;
            user.NAME = "";
            user.LASTNAME = "";
            user.BIRTH = new DateTime();
            user.TYPE = 0;
            user.USER = "";
            user.PASSWORD = "";
            user.CAREER = "";
            user.MAIL = "";
            this.user = user;
        }
    }
}
