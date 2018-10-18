using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aws
{
    public partial class Awspage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnInsertion_Click(object sender, EventArgs e)
        {
            //try
            //{
                /* Insertion After Validations*/
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "Insert into myschema.employee values(@ID,@Name,@Gender,@Email,@Mobile)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@ID", Convert.ToInt32(txtEmpID.Text)));
                    cmd.Parameters.Add(new NpgsqlParameter("@Name", txtEmpName.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@Gender", txtEmpGender.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@Email", txtEmpEmail.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@Mobile", Convert.ToInt32(txtEmpMobile.Text)));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();
                    txtEmpEmail.Text = "";
                    txtEmpName.Text = "";
                    txtEmpID.Text = "";
                    txtEmpGender.Text = "";
                    txtEmpMobile.Text = "";
                    lblmsg.Text = "Data Has been Saved";
                }
            //}
            //catch (Exception ex) { }
        }
    }
}