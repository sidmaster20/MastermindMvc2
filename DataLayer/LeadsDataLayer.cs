using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DataModels;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;

namespace DataLayer
{
    public class LeadsDataLayer
    {
        public void SaveContact(ContactDataModel objContactDm)
        {
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["Mastermind"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_SaveContact", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = objContactDm.FirstName;
                        cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = objContactDm.LastName;
                        cmd.Parameters.Add("@CompanyName", SqlDbType.VarChar).Value = objContactDm.CompanyName;
                        cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = objContactDm.Email;
                        cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = objContactDm.Phone;
                        cmd.Parameters.Add("@Message", SqlDbType.VarChar).Value = objContactDm.Message;

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
