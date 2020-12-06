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
    public class BuildingServices : Repository, IRepsitory<Building>
    {
        public bool Add(Building item)
        {
            SqlCommand command = new SqlCommand("INSERT INTO BUILDING (NAME) VALUES(@name)");
            command.Parameters.AddWithValue("@name", item.NAME);

            return ExecuteDml(command);
        }

        public bool Delete(Building item)
        {
            SqlCommand command = new SqlCommand("DELETE FROM BUILDING WHERE ID = @id");
            command.Parameters.AddWithValue("@id", item.ID);

            return ExecuteDml(command);
        }

        public bool Edit(Building item)
        {
            SqlCommand command = new SqlCommand("UPDATE BUILDING SET NAME = @name WHERE ID = @id");
            command.Parameters.AddWithValue("@name", item.NAME);
            command.Parameters.AddWithValue("@id", item.ID);
            return ExecuteDml(command);
        }

        public DataTable Get(int query, string value)
        {
            return ExecuteRead("SELECT * FROM BUILDING");
        }
    }
}
