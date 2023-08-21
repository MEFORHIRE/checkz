using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;

namespace CheckCasher
{
    public interface SQLDB
    {
          void close();
          void connect();
          int ExecuteNonQuery(String sql);
          DbDataReader ExecuteQuery(String sql);
          int UpdateImage(string sql, object data, string param);
          DbDataReader GetImage(string sql);
    }
}
