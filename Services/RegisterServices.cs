using Database;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RegisterServices : Repository, IRepsitory<Register>
    {
        public bool Add(Register item)
        {
            SqlCommand command = new SqlCommand("INSERT INTO REGISTER (ID_USER, ID_BUILDING, ID_CLASSROOM, ENTRY, EXIT_TIME, REASON) "
                                               + "VALUES(@id_user, @id_building, @id_classroom, @entry, @exit, @reason)");
            command.Parameters.AddWithValue("@id_user", item.ID_USER);
            command.Parameters.AddWithValue("@id_building", item.ID_BUILDING);
            command.Parameters.AddWithValue("@id_classroom", item.ID_CLASSROOM);
            command.Parameters.AddWithValue("@entry", item.ENTRY);
            command.Parameters.AddWithValue("@exit", item.EXIT);
            command.Parameters.AddWithValue("@reason", item.REASON);

            return ExecuteDml(command);
        }

        public bool Delete(Register item)
        {
            SqlCommand command = new SqlCommand("DELETE FROM REGISTER WHERE ID = @id");
            command.Parameters.AddWithValue("@id", item.ID);

            return ExecuteDml(command);
        }

        public bool Edit(Register item)
        {
            SqlCommand command = new SqlCommand("UPDATE REGISTER SET ENTRY = @entry, EXIT_TIME = @exit, REASON = @reason, ID_BUILDING = @building, ID_CLASSROOM = @classroom"
                                        + " WHERE ID = @id");
            command.Parameters.AddWithValue("@entry", item.ENTRY);
            command.Parameters.AddWithValue("@exit", item.EXIT);
            command.Parameters.AddWithValue("@reason", item.REASON);
            command.Parameters.AddWithValue("@building", item.ID_BUILDING);
            command.Parameters.AddWithValue("@classroom", item.ID_CLASSROOM);
            command.Parameters.AddWithValue("@id", item.ID);
            return ExecuteDml(command);
        }

        public DataTable Get(int query, string value)
        {
            if(query == 0)
            return ExecuteRead("SELECT * FROM REGISTER WHERE CAST (ENTRY AS date) = (SELECT CAST( GETDATE() AS Date))");
            else
            return ExecuteRead("SELECT * FROM REGISTER WHERE CAST (ENTRY AS date) = (SELECT CAST( GETDATE() AS Date)) AND ID_BUILDING = " + value);
        }
    }
}
