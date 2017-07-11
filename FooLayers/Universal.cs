using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Reflection;

namespace DataLayer.FooEnterprises
{
    internal static class Universal
    {
        /// <summary>
        /// The encryption key that LayerGen uses internally to encrypt data.
        /// </summary>
        public static string LayerGenEncryptionKey = "L@y3rG3n";

        /// <summary>
        /// Gets the connection string to connect to the database
        /// </summary>
        /// <returns>A string containing the connection string</returns>
        internal static string GetConnectionString()
        {
            // If this is an ASP.NET application, you can use a line like the following to pull
            // the connection string from the Web.Config:
            // return System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            return "Data Source=DESKTOP-JIRI3DO;Initial Catalog=FooEnterprises;Integrated Security=True";
        }

        /// <summary>
        /// Executes a stored procedure that does not return any results.
        /// </summary>
        /// <param name="procedureName">The name of the stored procedure to execute.</param>
        /// <param name="procedureParams">A dictionary of parameter/value pairs. This can be null if there are no parameters.</param>
        /// <returns>The number of rows affected.</returns>
        internal static int ExecuteNonQueryFromStoredProcedure(string procedureName, Dictionary<string, object> procedureParams)
        {
            using (var connection = new SqlConnection())
            {
                connection.ConnectionString = GetConnectionString();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = procedureName;
                    if (procedureParams != null && procedureParams.Count > 0)
                    {
                        foreach (KeyValuePair<string, object> kvp in procedureParams)
                        {
                            command.Parameters.AddWithValue(kvp.Key, kvp.Value);
                        }
                    }

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Executes a Sql query that does not return any results.
        /// </summary>
        /// <param name="sql">The sql query to execute.</param>
        /// <param name="sqlParams">Optional <see cref="System.String.Format"/> like parameters</param>
        /// <returns></returns>
        internal static int ExecuteNonQueryFromSqlStatement(string sql, params object[] sqlParams)
        {
            int paramNdx = 0;
            int valNdx = 1;
            var paramValDictionary = new Dictionary<string, string>();

            foreach (object param in sqlParams)
            {
                if (param is string)
                {
                    sql = sql.Replace("'{" + paramNdx + "}'", "@val" + valNdx);
                    sql = sql.Replace("{" + paramNdx + "}", "@val" + valNdx);
                    paramValDictionary.Add("@val" + valNdx, (string)param);
                    valNdx++;
                }
                else
                {
                    sql = sql.Replace("{" + paramNdx + "}", param.ToString());
                }
                paramNdx++;
            }

            using (var connection = new SqlConnection())
            {
                connection.ConnectionString = GetConnectionString();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = sql;
                    foreach (KeyValuePair<string, string> kvp in paramValDictionary)
                    {
                        command.Parameters.AddWithValue(kvp.Key, kvp.Value);
                    }

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Retrieves rows from a Sql Server Database based on a query
        /// </summary>
        /// <param name="sql">The Sql query to execute</param>
        /// <param name="sqlParams">Optional <see cref="System.String.Format"/> like parameters</param>
        /// <returns>A <see cref="System.Data.DataTable" /> with all the data.</returns>
        internal static DataTable GetDataFromSqlStatement(string sql, params object[] sqlParams)
        {
            int paramNdx = 0;
            int valNdx = 1;
            var paramValDictionary = new Dictionary<string, string>();

            foreach (object param in sqlParams)
            {
                if (param is string)
                {
                    sql = sql.Replace("'{" + paramNdx + "}'", "@val" + valNdx);
                    sql = sql.Replace("{" + paramNdx + "}", "@val" + valNdx);
                    paramValDictionary.Add("@val" + valNdx, (string)param);
                    valNdx++;
                }
                else
                {
                    sql = sql.Replace("{" + paramNdx + "}", param.ToString());
                }
                paramNdx++;
            }

            using (var connection = new SqlConnection())
            {
                connection.ConnectionString = GetConnectionString();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = sql;
                    foreach (KeyValuePair<string, string> kvp in paramValDictionary)
                    {
                        command.Parameters.AddWithValue(kvp.Key, kvp.Value);
                    }

                    connection.Open();
                    using (var adapter = new SqlDataAdapter())
                    {
                        using (var ds = new DataSet())
                        {
                            adapter.SelectCommand = command;
                            adapter.Fill(ds);

                            if (ds.Tables.Count > 0)
                            {
                                return ds.Tables[0];
                            }
                        }
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Retrieves rows from a Sql Server Database based on a stored procedure.
        /// </summary>
        /// <param name="procedureName">The name of the stored procedure to execute.</param>
        /// <param name="procedureParams">A dictionary of parameter/value pairs. This can be null if there are no parameters.</param>
        /// <returns>A <see cref="System.Data.DataTable" /> with all the data.</returns>
        internal static DataTable GetDataFromStoredProcedure(string procedureName, Dictionary<string, object> procedureParams)
        {
            using (var connection = new SqlConnection())
            {
                connection.ConnectionString = GetConnectionString();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = procedureName;
                    if (procedureParams != null && procedureParams.Count > 0)
                    {
                        foreach (KeyValuePair<string, object> kvp in procedureParams)
                        {
                            command.Parameters.AddWithValue(kvp.Key, kvp.Value);
                        }
                    }

                    connection.Open();
                    using (var adapter = new SqlDataAdapter())
                    {
                        using (var ds = new DataSet())
                        {
                            adapter.SelectCommand = command;
                            adapter.Fill(ds);

                            if (ds.Tables.Count > 0)
                            {
                                return ds.Tables[0];
                            }
                        }
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Retrieves rows from a Sql Server Database based on a stored procedure.
        /// </summary>
        /// <param name="procedureName">The name of the stored procedure to execute.</param>
        /// <returns>A <see cref="System.Data.DataTable" /> with all the data.</returns>
        public static DataTable GetDataFromStoredProcedure(string procedureName)
        {
            return GetDataFromStoredProcedure(procedureName, null);
        }

    }
}

namespace BusinessLayer.FooEnterprises
{

    /// <summary>
    /// Enumeration of various serialization formats
    /// </summary>
    public enum SerializationFormats
    {
        /// <summary>
        /// JSON format
        /// </summary>
        Json = 1,
        /// <summary>
        /// XML format
        /// </summary>
        Xml = 2,
        /// <summary>
        /// Base 64 encoded BSON format
        /// </summary>
        BsonBase64 = 3
    }

    internal static class Mapper<T>
    where T : class
    {
        private static readonly Dictionary<string, PropertyInfo> PropertyMap;

        static Mapper()
        {
            PropertyMap = typeof(T).GetProperties().ToDictionary(p => p.Name.ToLower(), p => p);
        }

        public static void Map(ExpandoObject source, T destination)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            if (destination == null)
                throw new ArgumentNullException("destination");

            foreach (var kv in source)
            {
                PropertyInfo p;
                if (PropertyMap.TryGetValue(kv.Key.ToLower(), out p))
                {
                    var propType = p.PropertyType;
                    if (kv.Value == null)
                    {
                        if (!propType.IsByRef && propType.Name != "Nullable`1")
                        {
                            throw new ArgumentException("not nullable");
                        }
                    }
                    p.SetValue(destination, kv.Value == DBNull.Value ? default(T) : kv.Value, null);
                }
            }
        }
    }

    public static class ExecuteNonQuery
    {
        /// <summary>
        /// Executes a Sql query that does not return any results.
        /// </summary>
        /// <param name="sql">The sql query to execute.</param>
        /// <param name="sqlParams">Optional <see cref="System.String.Format"/> like parameters</param>
        /// <returns>The number of rows affected.</returns>
        public static int FromSqlStatement(string sql, params object[] sqlParams)
        {
            return DataLayer.FooEnterprises.Universal.ExecuteNonQueryFromSqlStatement(sql, sqlParams);
        }
    }

    public static class LoadData
    {
        /// <summary>
        /// Loads data from a Sql query and returns the results in a list
        /// </summary>
        /// <typeparam name="T">The type of class to load the data into</typeparam>
        /// <param name="sql">The sql query to execute.</param>
        /// <param name="sqlParams">Optional <see cref="System.String.Format"/> like parameters</param>
        /// <returns>A list of type T containing the results of the query</returns>
        public static List<T> FromSqlStatement<T>(string sql, params object[] sqlParams)
            where T : class, new()
        {
            DataTable dt = DataLayer.FooEnterprises.Universal.GetDataFromSqlStatement(sql, sqlParams);
            var objects = new List<dynamic>();

            foreach (DataRow row in dt.Rows)
            {
                dynamic obj = new ExpandoObject();

                foreach (DataColumn column in dt.Columns)
                {
                    var x = (IDictionary<string, object>)obj;
                    x.Add(column.ColumnName, row[column.ColumnName]);
                }
                objects.Add(obj);
            }

            var retval = new List<T>();
            foreach (dynamic item in objects)
            {
                var o = new T();
                Mapper<T>.Map(item, o);
                retval.Add(o);
            }

            return retval;
        }       
    }


    /// <summary>
    /// The exception that is thrown when data in memory is out of sync with data in the database.
    /// </summary>
    public class OutOfSyncException : System.Exception
    {
        public OutOfSyncException()
        {
        }

        public OutOfSyncException(string message)
            : base(message)
        {
        }

        public OutOfSyncException(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }

    /// <summary>
    /// The exception that is thrown when data in memory is in a read only state.
    /// </summary>
    public class ReadOnlyException : System.Exception
    {
        public ReadOnlyException()
        {
        }

        public ReadOnlyException(string message)
            : base(message)
        {
        }

        public ReadOnlyException(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }

    /// <summary>
    /// The exception that is thrown when trying to read from a row that doesn't exist.
    /// </summary>
    public class RowNotFoundException : System.Exception
    {
        public RowNotFoundException()
        {
        }

        public RowNotFoundException(string message)
            : base(message)
        {
        }

        public RowNotFoundException(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }

    public class LayerGenConnectionString
    {
        private string _connectionString;

        public string ConnectionString
        {
            get
            {
                return _connectionString;
            }
            set
            {
                _connectionString = value;
            }
        }
    }

    public class Encryption64
    {
        private byte[] _key = {};
        private readonly byte[] _iv = {65, 108, 97, 110, 32, 66, 46, 9};

        public string Encrypt(string stringToEncrypt, string encryptionKey)
        {
            try
            {
                _key = System.Text.Encoding.UTF8.GetBytes(encryptionKey.Substring(0, 8));
                using (System.Security.Cryptography.DESCryptoServiceProvider des = new System.Security.Cryptography.DESCryptoServiceProvider())
                {
                    byte[] inputByteArray = System.Text.Encoding.UTF8.GetBytes(stringToEncrypt);
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                    {
                        using (System.Security.Cryptography.CryptoStream cs = new System.Security.Cryptography.CryptoStream(ms, des.CreateEncryptor(_key, _iv), System.Security.Cryptography.CryptoStreamMode.Write))
                        {
                            cs.Write(inputByteArray, 0, inputByteArray.Length);
                            cs.FlushFinalBlock();
                            return Convert.ToBase64String(ms.ToArray());
                        }
                    }
                }
            } catch
            {
                return "";
            }
        }

        public string Decrypt(string stringToDecrypt, string encryptionKey)
        {
            try
            {
                _key = System.Text.Encoding.UTF8.GetBytes(encryptionKey.Substring(0, 8));
                using (System.Security.Cryptography.DESCryptoServiceProvider des = new System.Security.Cryptography.DESCryptoServiceProvider())
                {
                    byte[] inputByteArray = Convert.FromBase64String(stringToDecrypt);
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                    {
                        using (System.Security.Cryptography.CryptoStream cs = new System.Security.Cryptography.CryptoStream(ms, des.CreateDecryptor(_key, _iv), System.Security.Cryptography.CryptoStreamMode.Write))
                        {
                            cs.Write(inputByteArray, 0, inputByteArray.Length);
                            cs.FlushFinalBlock();
                            System.Text.Encoding encoding = System.Text.Encoding.UTF8;
                            return encoding.GetString(ms.ToArray());
                        }
                    }
                }
            } catch
            {
                return "";
            }
        }
    }
}
