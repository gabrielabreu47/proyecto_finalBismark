using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public interface IRepsitory<T>
    {
        bool Add(T item);
        bool Edit(T item);
        bool Delete(T item);
        DataTable Get(int query, string value);
    }
}
