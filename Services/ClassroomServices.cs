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
    public class ClassroomServices : Repository, IRepsitory<Classroom>
    {
        public bool Add(Classroom item)
        {
            SqlCommand command = new SqlCommand("INSERT INTO CLASSROOM (ID_BUILDING, CAPACITY) VALUES(@building, @capacity)");
            command.Parameters.AddWithValue("@building", item.ID_BUILDING);
            command.Parameters.AddWithValue("@capacity", item.CAPACITY);

            return ExecuteDml(command);
        }

        public bool Delete(Classroom item)
        {
            SqlCommand command = new SqlCommand("DELETE FROM CLASSROOM WHERE ID = @id");
            command.Parameters.AddWithValue("@id", item.ID);

            return ExecuteDml(command);
        }

        public bool Edit(Classroom item)
        {
            SqlCommand command = new SqlCommand("UPDATE CLASSROOM SET CAPACITY = @capacity WHERE ID = @id");
            command.Parameters.AddWithValue("@capacity", item.CAPACITY);
            command.Parameters.AddWithValue("@id", item.ID);
            return ExecuteDml(command);
        }

        public DataTable Get(int query, string value)
        {
            return ExecuteRead("SELECT * FROM CLASSROOM WHERE ID_BUILDING = " + value);

        }
    }
}
