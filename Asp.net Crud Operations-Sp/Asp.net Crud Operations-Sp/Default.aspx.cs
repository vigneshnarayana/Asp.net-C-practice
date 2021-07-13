using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            getProductList();
        }
    }

    SqlConnection con = new SqlConnection(@"Data Source=192.168.1.7;Initial Catalog=db_test;Persist Security Info=True;User ID=devuser;Password=DBuser@2020");
         
    protected void Button1_Click(object sender, EventArgs e)
    {
        int ProductId = int.Parse(TextBox2.Text);
        string iteamName = TextBox3.Text;
        string Specification = TextBox4.Text;
        string Unit = DropDownList1.SelectedValue;
        string Status = RadioButtonList1.SelectedValue;
        DateTime cdate = DateTime.Parse(TextBox7.Text);
        con.Open();
        SqlCommand com = new SqlCommand("exec ProductSetup_Sp '"+ ProductId + "', '"+ iteamName + "','"+ Specification + "','"+ Unit + "','"+ Status + "','"+ cdate + "'",con);
        com.ExecuteNonQuery();
        con.Close();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Inserted');",true);

        getProductList();
    }

    void getProductList()
    {
        SqlCommand com = new SqlCommand("exec ProductList_Sp", con);
        SqlDataAdapter sd = new SqlDataAdapter(com);
        DataTable tb = new DataTable();
        sd.Fill(tb);
        GridView1.DataSource = tb;
        GridView1.DataBind();



    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        int ProductId = int.Parse(TextBox2.Text);
        string iteamName = TextBox3.Text;
        string Specification = TextBox4.Text;
        string Unit = DropDownList1.SelectedValue;
        string Status = RadioButtonList1.SelectedValue;
        DateTime cdate = DateTime.Parse(TextBox7.Text);
        con.Open();
        SqlCommand com = new SqlCommand("exec UpdateProduct_Sp '" + ProductId + "', '" + iteamName + "','" + Specification + "','" + Unit + "','" + Status + "','" + cdate + "'", con);
        com.ExecuteNonQuery();
        con.Close();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);

        getProductList();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        //

        int ProductId = int.Parse(TextBox2.Text);
      
        con.Open();
        SqlCommand com = new SqlCommand("exec DeleteProduct_Sp '" + ProductId + "'", con);
        com.ExecuteNonQuery();
        con.Close();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Deleted');", true);

        getProductList();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        //


        //////////////////
        ///
        int ProductId = int.Parse(TextBox2.Text);

        con.Open();
        SqlCommand com = new SqlCommand("exec SearchProduct_Sp '" + ProductId + "'", con);
        SqlDataAdapter sd = new SqlDataAdapter(com);
        DataTable tb = new DataTable();
        sd.Fill(tb);
        GridView1.DataSource = tb;
        GridView1.DataBind();

        ///

    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        getProductList(); 
    }
}