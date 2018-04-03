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
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        DataSet ds;
        DataTable dt;
        SqlConnection conn = new SqlConnection(@" data source= localhost\sqlexpress; integrated security= true; database=IT_Security;");
        SqlCommand cmd = null;
        SqlDataReader rdr = null;


        protected void Add_Product_Button_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();

                // "INSERT INTO Treatments values(@T_Name, @T_Price, @T_Desc, @T_Image)";
                
                string SqlString = "INSERT INTO Products values('" + ProductNameText.Text +"','"+ Convert.ToInt32(ProductPriceText.Text) + "')";


                cmd = new SqlCommand(SqlString, conn);
                cmd.ExecuteNonQuery();

                LabelSearch.Text = "Inserted Product";
            }
            catch (Exception ex) {

                LabelSearch.Text = ex.Message + ex.StackTrace;
            }
            finally {
                conn.Close();
            }
        }

        protected void Search_Product_Button_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();

                // "INSERT INTO Treatments values(@T_Name, @T_Price, @T_Desc, @T_Image)";

                string SqlString = "SELECT * from Products WHERE ";


                cmd = new SqlCommand(SqlString, conn);
                cmd.ExecuteNonQuery();

                LabelSearch.Text = "Inserted Product";
            }
            catch (Exception ex)
            {

                LabelSearch.Text = ex.Message + ex.StackTrace;
            }
            finally
            {
                conn.Close();
            }

        }
    }
}