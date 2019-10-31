using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace CustomerLog
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Supplier
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set; }
        public string Location { get; set; }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int SupplierId { get; set; }
    }

    class GetData
    {
        SqlConnection con;
        SqlCommand cmd;
        string conString = "data source = IN5CG9292JHT; database = ADOdemo; integrated security = true";

        public void GetProductDetails()
        {
            con = new SqlConnection();
            con.ConnectionString = conString;
            cmd = new SqlCommand();

            cmd.CommandText = "select * from Product";
            cmd.Connection = con;

            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            Console.WriteLine($"Id\tName\n");
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]}\t{rdr[1]}");
            }
            con.Close();

        }

        public void GetSupplierDetails()
        {
            con = new SqlConnection();
            con.ConnectionString = conString;
            cmd = new SqlCommand();

            cmd.CommandText = "select * from Supplier";
            cmd.Connection = con;

            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            Console.WriteLine($"\nId\tCompany Name\tProduct Id\tPrice\tLocation\n");
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]}\t{rdr[1]}\t\t\t{rdr[2]}\t{rdr[3]}\t{rdr[4]}");
            }
            con.Close();

        }

        public void GetSupplierByProduct()
        {
            con = new SqlConnection();
            con.ConnectionString = conString;
            cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select p.Name,s.Id,s.CompanyName,s.Price,s.Location from Supplier s inner join Product p on s.ProductId = p.Id order by p.Name";
            Console.WriteLine($"\nProduct Name\tSupplier Id\tCompany Name\tPrice\tLocation\n");

            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())

            {
                Console.WriteLine($"{rdr[0]}\t\t{rdr[1]}\t\t{rdr[2]}\t\t{rdr[3]}\t{rdr[4]}");
            }

            con.Close();

        }

        public void AddCustomer()
        {
            Console.WriteLine("Enter Customer Details: Name, Product ID, Quantity and Supplier ID\n");
            Customer cus = new Customer();
            cus.Name = Console.ReadLine();
            cus.ProductId = int.Parse(Console.ReadLine());
            cus.Quantity = int.Parse(Console.ReadLine());
            cus.SupplierId = int.Parse(Console.ReadLine());


            con = new SqlConnection();
            con.ConnectionString = conString;
            cmd = new SqlCommand();

            cmd.Parameters.AddWithValue("name", cus.Name);
            cmd.Parameters.AddWithValue("productid", cus.ProductId);
            cmd.Parameters.AddWithValue("quantity", cus.Quantity);
            cmd.Parameters.AddWithValue("supplierid", cus.SupplierId);

            cmd.CommandText = "insert into Customer values (@name,@productid,@quantity,@supplierid)";
            cmd.Connection = con;

            con.Open();
            int row = cmd.ExecuteNonQuery();
            if (row>0)
            {
                Console.WriteLine("Entry Successful!");
                GetCustomer();
            }

            con.Close();

        }

        public void GetCustomer()
        {
            con = new SqlConnection();
            con.ConnectionString = conString;
            cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Customer";

            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            Console.WriteLine($"\nId\tName\tProduct Id  Quantity  Supplier ID\n");

            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]}\t{rdr[1]}\t\t{rdr[2]}\t{rdr[3]}\t{rdr[4]}");
            }
            con.Close();

        }



    }
}
