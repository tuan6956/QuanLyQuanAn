using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn
{
    class QuanLyQuanAnRepository
    {
        private dbConnection conn;

        public QuanLyQuanAnRepository(string svName, string dbName, string username, string password)
        {
            conn = new dbConnection(svName, dbName, username, password);
            
        }
        public QuanLyQuanAnRepository(dbConnection dbcon)
        {
            this.conn = dbcon;
        }
        public DataTable findAll()
        {
            string query = string.Format("select * from QuanAn");
            SqlParameter[] sqlParameters = new SqlParameter[0];
            //var rs = conn.executeSelectQuery(query, sqlParameters);
            return conn.executeSelectQuery(query, sqlParameters);
        }
        public QuanAn findOne(int _id)
        {
            string query = string.Format("select * from QuanAn where ID = @id");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.Int);
            sqlParameters[0].Value = _id;
            var rs = conn.executeSelectQuery(query, sqlParameters);
            if (rs.Rows.Count == 0)
            {
                return null;
            }
            DataRow dr = rs.Rows[0];
            return new QuanAn(_id, dr["name"].ToString(),dr["timeOpen"].ToString(), dr["timeClose"].ToString(),dr["typeFood"].ToString(), dr["phone"].ToString(), dr["address"].ToString());
        }
        public QuanAn saveOne(QuanAn QuanAn)
        {
            string query = string.Format("insert into QuanAn values(@name, @timeOpen, @timeClose, @typeFood, @phone, @address)");
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@name", SqlDbType.NVarChar);
            sqlParameters[0].Value = QuanAn.name;
            sqlParameters[1] = new SqlParameter("@timeOpen", SqlDbType.NVarChar);
            sqlParameters[1].Value = QuanAn.timeOpen;
            sqlParameters[2] = new SqlParameter("@timeClose", SqlDbType.NVarChar);
            sqlParameters[2].Value = QuanAn.timeClose;
            sqlParameters[3] = new SqlParameter("@typeFood", SqlDbType.NVarChar);
            sqlParameters[3].Value = QuanAn.typeFood;
            sqlParameters[4] = new SqlParameter("@phone", SqlDbType.NVarChar);
            sqlParameters[4].Value = QuanAn.phoneContact;
            sqlParameters[5] = new SqlParameter("@address", SqlDbType.NVarChar);
            sqlParameters[5].Value = QuanAn.address;
            var rs = conn.executeInsertQuery(query, sqlParameters);
            if (!rs)
                return null;
            return QuanAn;
        }
        public QuanAn update(QuanAn QuanAn)
        {
            string query = string.Format("update QuanAn set name = @name, timeOpen = @timeOpen, timeClose = @timeClose, typeFood = @typeFood, phone = @phone, address = @address where ID = @id");
            SqlParameter[] sqlParameters = new SqlParameter[7];

            sqlParameters[0] = new SqlParameter("@name", SqlDbType.NVarChar);
            sqlParameters[0].Value = QuanAn.name;
            sqlParameters[1] = new SqlParameter("@timeOpen", SqlDbType.NVarChar);
            sqlParameters[1].Value = QuanAn.timeOpen;
            sqlParameters[2] = new SqlParameter("@timeClose", SqlDbType.NVarChar);
            sqlParameters[2].Value = QuanAn.timeClose;
            sqlParameters[3] = new SqlParameter("@typeFood", SqlDbType.NVarChar);
            sqlParameters[3].Value = QuanAn.typeFood;
            sqlParameters[4] = new SqlParameter("@phone", SqlDbType.NVarChar);
            sqlParameters[4].Value = QuanAn.phoneContact;
            sqlParameters[5] = new SqlParameter("@address", SqlDbType.NVarChar);
            sqlParameters[5].Value = QuanAn.address;
            sqlParameters[6] = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameters[6].Value = QuanAn.ID;
            var rs = conn.executeUpdateQuery(query, sqlParameters);
            if (!rs)
                return null;
            return QuanAn;
        }
        public QuanAn delete(QuanAn QuanAn)
        {
            string query = string.Format("delete from QuanAn where ID = @id");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.Int);
            sqlParameters[0].Value = QuanAn.ID;
            var rs = conn.executeInsertQuery(query, sqlParameters);
            if (!rs)
                return null;
            return QuanAn;
        }
    }
}
