using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace SQLInjectionvuln
{
    public partial class CreateLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection conn = new SqlConnection(@" data source= localhost\sqlexpress; integrated security= true; database=IT_Security;");
        SqlCommand cmd = null;
        
        protected void Add_User_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                
                // "INSERT INTO Treatments values(@T_Name, @T_Price, @T_Desc, @T_Image)";

                string SqlString = "INSERT INTO Users values('" + UserTextName.Text + "','" + UserTextPass.Text + "')";


                cmd = new SqlCommand(SqlString, conn);
                cmd.ExecuteNonQuery();

                LabelInfo.Text = "Created User, with the name of " + UserTextName.Text + "";
            }
            catch (Exception ex)
            {

                LabelInfo.Text = ex.Message + ex.StackTrace;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}