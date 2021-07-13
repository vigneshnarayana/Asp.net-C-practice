using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DemoPracticeMVC.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contry { get; set; }

        public Customer(int Id, string Name, string Country)
        {
            this.Id = Id;
            this.Name = Name;
            this.Contry = Country;
        }

        public Customer()
        {
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();

            //1. create db connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=192.168.1.7;Database=Employee;User Id=devuser;Password=DBuser@2020;";
            con.Open();
            //2. create db comment
            SqlCommand cmd = new SqlCommand("select * from Customers", con);
            //3.Fill dataset
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ada.Fill(ds);

            //4. convert our dataset in to model
            customers = (from DataRow dr in ds.Tables[0].Rows
                         select new Customer()
                         {
                             Id = Convert.ToInt32(dr["CustomerId"]),
                             Name = Convert.ToString(dr["Name"]),
                             Contry = Convert.ToString(dr["Country"])

                         }).ToList();
            //5. return model
            return customers;

        }

        public Customer GetCustomerById(int id)
        {
            List<Customer> customers = new List<Customer>();

            customers = GetAllCustomers();
            Customer customer = (from n in customers
                                 where n.Id == id
                                 select n).FirstOrDefault();



            return customer;
        }
        public void AddCustomer() {
            Dictionary<string, string> param = new Dictionary<string, string>();

            param.Add("@Name", this.Name);
            param.Add("@Country", this.Contry);
            param.Add("@Id ", "");
            ExecuteSp("Sp_AddCustomer", param);
        }
        public void UpdateCustomer() {
            Dictionary<string, string> param = new Dictionary<string, string>();

            param.Add("@Name", this.Name);
            param.Add("@Country", this.Contry);
            param.Add("@Id", this.Id.ToString());
            ExecuteSp("Sp_UpdateCustomer", param);
        }
        public void DeleteCustomer()
        {
            Dictionary<string, string> param = new Dictionary<string, string>();

            param.Add("@Name", "");
            param.Add("@Country", "");
            param.Add("@Id ",this.Id.ToString());
            ExecuteSp("Sp_deleteCustomer", param);
        }
        public void ExecuteSp(string SpName,Dictionary<string,string> parametters) {

            List<Customer> customers = new List<Customer>();

            //1. create db connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=192.168.1.7;Database=Employee;User Id=devuser;Password=DBuser@2020;";
            con.Open();
            //2. create db comment
            SqlCommand cmd = new SqlCommand(SpName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param;

            foreach(KeyValuePair<string,string> data in parametters)
            {
                param = new SqlParameter(data.Key, data.Value);
                cmd.Parameters.Add(param);
            }
            cmd.ExecuteNonQuery();
        }
    }
}