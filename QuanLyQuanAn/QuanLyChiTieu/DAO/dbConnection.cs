using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn
{
    class dbConnection
    {
        private SqlDataAdapter myAdapter;
        private SqlConnection conn;
        public dbConnection(string svName, string dbName, string username, string password)
        {
            string connString = @"Data Source=" + svName + ";Initial Catalog="
                        + dbName;
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                connString += ";User ID=" + username + ";Password=" + password;
            }
            conn = new SqlConnection(connString);
        }
        private SqlConnection openConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }
        private void closeConnection()
        {
            if (conn.State == ConnectionState.Open || conn.State == ConnectionState.Connecting)
            {
                conn.Close();
            }
        }
        public bool IsAvailable()
        {
            try
            {
                conn.Open();
                conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public DataTable executeSelectQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            myAdapter = new SqlDataAdapter();
            dataTable = null;
            DataSet ds = new DataSet();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myCommand.ExecuteNonQuery();
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (SqlException e)
            {
                return null;
            }
            finally
            {
                closeConnection();
            }
            return dataTable;
        }
        public bool executeInsertQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            myAdapter = new SqlDataAdapter();

            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.InsertCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                return false;
            }
            finally
            {
                closeConnection();
            }
            return true;
        }
        public bool executeUpdateQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            myAdapter = new SqlDataAdapter();

            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.UpdateCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                return false;
            }
            finally
            {
                closeConnection();
            }
            return true;
        }
        public bool executeDeleteQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            myAdapter = new SqlDataAdapter();

            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.DeleteCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                return false;
            }
            finally
            {
                closeConnection();
            }
            return true;
        }
    }
}
