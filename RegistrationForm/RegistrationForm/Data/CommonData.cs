using System;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace ASharp.BasicLayered.Data
{
    public class CommonData
    {
        public static SqlConnection Connection { get; private set; }

        /// <summary>
        ///     Prepare the database connection
        /// </summary>
        public static void ReadyConnection()
        {
            Connection = new SqlConnection();
            Connection.ConnectionString =
                ConfigurationManager.ConnectionStrings["BasicLayeredConnection"].ToString();    ///////////////
            Connection.ConnectionString =
                @"Data Source=DESKTOP-B0R6CS7\SQLEXPRESS;Initial Catalog=BasicLayeredDB;Integrated Security=True";///////////////////
            if (Connection.State != ConnectionState.Open) Connection.Open();
        }

        /// <summary>
        ///     To execute non query data.
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(SqlCommand command)
        {
            try
            {
                ReadyConnection();
                command.Connection = Connection;
                var result = command.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Dispose();
                if (Connection.State == ConnectionState.Open) Connection.Close();
                Connection.Dispose();
            }
        }

        /// <summary>
        ///     To get tabular data.
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(SqlCommand command)
        {
            try
            {
                ReadyConnection();
                command.Connection = Connection;
                return command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static object ExecuteScalar(SqlCommand command)
        {
            try
            {
                ReadyConnection();
                command.Connection = Connection;

                var value = command.ExecuteScalar();
                if (value is DBNull)
                    return default(decimal);
                return value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        
            }
        }


        
       


        
        

     
    
