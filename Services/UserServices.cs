using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Database;
using Entities;

namespace Services
{
    public class UserServices : Repository, IRepsitory<User>
    {
        public bool Add(User item)
        {
            SqlCommand command = new SqlCommand("INSERT INTO USERS (NAME, LASTNAME, BIRTH, TYPE, USERNAME, PASSWORD, CAREER, MAIL, PICTURE) "
                                               + "VALUES(@name, @lastname, @birth, @type, @user, @password, @career, @mail, @picture)");
            command.Parameters.AddWithValue("@name", item.NAME);
            command.Parameters.AddWithValue("@lastname", item.LASTNAME);
            command.Parameters.AddWithValue("@birth", item.BIRTH);
            command.Parameters.AddWithValue("@type", item.TYPE);
            command.Parameters.AddWithValue("@user", item.USER);
            command.Parameters.AddWithValue("@password", item.PASSWORD);
            command.Parameters.AddWithValue("@career", item.CAREER);
            command.Parameters.AddWithValue("@mail", item.MAIL);
            command.Parameters.AddWithValue("@picture", item.PICTURE);

            return ExecuteDml(command);
        }

        public bool Delete(User item)
        {
            SqlCommand command = new SqlCommand("DELETE FROM USERS WHERE ID = @id");
            command.Parameters.AddWithValue("@id", item.ID);

            return ExecuteDml(command);
        }

        public bool Edit(User item)
        {
            SqlCommand command = new SqlCommand("UPDATE USERS SET NAME = @name, LASTNAME = @lastname, BIRTH = @birth, TYPE = @type, USERNAME = @user, PASSWORD = @password, CAREER = @career, MAIL = @mail, PICTURE = @picture"
                            + " WHERE ID = @id");
            command.Parameters.AddWithValue("@name", item.NAME);
            command.Parameters.AddWithValue("@lastname", item.LASTNAME);
            command.Parameters.AddWithValue("@birth", item.BIRTH);
            command.Parameters.AddWithValue("@type", item.TYPE);
            command.Parameters.AddWithValue("@user", item.USER);
            command.Parameters.AddWithValue("@password", item.PASSWORD);
            command.Parameters.AddWithValue("@career", item.CAREER);
            command.Parameters.AddWithValue("@mail", item.MAIL);
            command.Parameters.AddWithValue("@picture", item.PICTURE);
            command.Parameters.AddWithValue("@id", item.ID);
            return ExecuteDml(command);
        }

        public DataTable Get(int query, string value)
        {
            return ExecuteRead("SELECT * FROM USERS");
        }

        public DataTable Login(string user, string pass)
        {
            return ExecuteRead("SELECT * FROM USERS WHERE USERNAME = '" + user + "' AND PASSWORD = '" + pass + "'");
        }
    }
}
