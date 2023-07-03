using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace linqproj
{
    class Program
    {
        public static decimal Billing()
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-NE6M66C; database= master ;user id= sa; password =P@ssw0rd");
            Console.WriteLine("Enter the number of products to be purchased");
            int x = Convert.ToInt32(Console.ReadLine());
            decimal sum = 0;
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine("Please choose a product id:");
                int prodid = Convert.ToInt32(Console.ReadLine());
                SqlCommand cmd = new SqlCommand("select Price,productName,ProductId from product where productid =" + prodid + "", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                decimal price = (decimal)dr[0];


                Console.WriteLine("Enter the  quantity of the product:");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Item: " + dr[1] + "  Quantity: " + n + "  Price: Rs." + dr[0]);
                con.Close();
                price = price * n;
                sum = sum + price;

            }
            Console.WriteLine("Total amount is Rs." + sum);
            return sum;

        }
        public static void Display()
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-NE6M66C; database= master ;user id= sa; password =P@ssw0rd");
            SqlCommand cmd = new SqlCommand("SELECT Price, ProductName, ProductId FROM product", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string price = dr["Price"].ToString();
                string productName = dr["ProductName"].ToString();
                string productId = dr["ProductId"].ToString();

                Console.WriteLine("Product ID: " + productId);
                Console.WriteLine("Price: " + price);
                Console.WriteLine("Product Name: " + productName);
               
                Console.WriteLine("----------------------------------------");
            }

            dr.Close();
            con.Close();
        }

        static void Main(string[] args)
        {

            
            Display();
            Billing();

            
            Console.ReadLine();
        }
    }
}
