using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BinitaDotNet
{

    public class DBConnection
    {
        SqlConnection con;
        public DBConnection()
        {
            con = new SqlConnection(@"Data Source=.\sqlexpress;Database=BCA5TH;Integrated security=True");
        }
        public DataTable GetData(string query)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    return ds.Tables[0];
                else return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ExecuteQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                cmd.Connection.Open();
                return cmd.ExecuteNonQuery();
            }
            catch(Exception ex) 
            { 
                throw ex; 
            } 
            finally
            {
                cmd.Connection.Close(); 
            }
        
           
        }
    }
}
