using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using mvcWithoutEntity_FrameWork.Models;

namespace mvcWithoutEntity_FrameWork.Controllers
{
    public class ProductController : Controller
    {
        
        //windowes Athentication
        //string ConnectionString = @"Data Source=192.168.1.7;Initial Catalog=mvcCrudDB;User ID=devuser;Password=DBuser@2020; Integrated Security=True;";

            //server Athentication
        string ConnectionString = @"Server=192.168.1.7;Database=mvcCrudDB;User Id=devuser;Password=DBuser@2020;";

        // GET: Product
        [HttpGet]
        public ActionResult Index()
        {
            DataTable dtblProduct = new DataTable();
            using(SqlConnection sqlCon=new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Product", sqlCon);
                sqlDa.Fill(dtblProduct);
            }
            return View(dtblProduct);
        }

       
        // GET: Product/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View(new ProductModel());
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(ProductModel productModel)
        {
            using(SqlConnection  sqlCon=new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                string Query = "  insert into Product(ProductName,Price,Count) values(@ProductName,@Price,@Count)";
                SqlCommand sqlcmd = new SqlCommand(Query, sqlCon);
                sqlcmd.Parameters.AddWithValue("@ProductName", productModel.ProductName);
                sqlcmd.Parameters.AddWithValue("@Price", productModel.Price);
                sqlcmd.Parameters.AddWithValue("@Count", productModel. Count);
                sqlcmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index");
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            ProductModel productModel = new ProductModel();
            DataTable dtblProduct = new DataTable();
            using(SqlConnection sqlcon=new SqlConnection(ConnectionString))
            {
                sqlcon.Open();
                string Query = "SELECT * FROM Product where ProductId=@ProductId";
                SqlDataAdapter sqlData = new SqlDataAdapter(Query,sqlcon);
                sqlData.SelectCommand.Parameters.AddWithValue("@ProductId", id);
                sqlData.Fill(dtblProduct);
            }
            if(dtblProduct.Rows.Count == 1)
            {
                productModel.ProductId = Convert.ToInt32(dtblProduct.Rows[0][0].ToString());
                productModel.ProductName = dtblProduct.Rows[0][1].ToString();
                productModel.Price = Convert.ToDecimal(dtblProduct.Rows[0][2].ToString());
                productModel.Count = Convert.ToInt32(dtblProduct.Rows[0][3].ToString());
                return View(productModel);
            }
            return RedirectToAction("Index");
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(ProductModel productModel)
        {

            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                string Query = " Update Product SET ProductName=@ProductName,Price=@Price,Count=Count where ProductId=@ProductId";
                SqlCommand sqlcmd = new SqlCommand(Query, sqlCon);
                sqlcmd.Parameters.AddWithValue("@ProductId", productModel.ProductId);
                sqlcmd.Parameters.AddWithValue("@ProductName", productModel.ProductName);
                sqlcmd.Parameters.AddWithValue("@Price", productModel.Price);
                sqlcmd.Parameters.AddWithValue("@Count", productModel.Count);
                sqlcmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index");
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                string Query = "Delete From Product where ProductId=@ProductId";
                SqlCommand sqlcmd = new SqlCommand(Query, sqlCon);
                sqlcmd.Parameters.AddWithValue("@ProductId", id);
                sqlcmd.ExecuteNonQuery();

            }
            return RedirectToAction("Index");
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
