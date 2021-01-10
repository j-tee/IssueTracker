using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace TrackerLibrary.Shared
{
    public static class DBQueryExtensionHelper
    {
        public static int GetTotalCount(this DbContext context, string sql, params SqlParameter[] sqlparams)
        {
            int count;
            using (var connection = context.Database.GetDbConnection())
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    // command.Parameters.Add(sqlparams);
                    foreach (var param in sqlparams)
                    {
                        command.Parameters.Add(param);
                    }
                    command.CommandText = sql;
                    string result = command.ExecuteScalar().ToString();

                    int.TryParse(result, out count);
                }
                connection.Close();
                connection.Dispose();
            }
            return count;
        }
    }
}
