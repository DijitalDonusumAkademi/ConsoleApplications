using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNetWind.Entities;

namespace AdoNetWind.Dal
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;
            Initial Catalog=ETrade;
            Integrated Security=True;
            Connect Timeout=30;
            Encrypt=False;TrustServerCertificate=False;
            ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public DataTable GetDataTableList()
        {


            ConnectionControl();

            SqlCommand command=new SqlCommand("select * from Products",_connection);
            SqlDataReader dataReader= command.ExecuteReader();

            DataTable dataTable=new DataTable();
            dataTable.Load(dataReader);
            dataReader.Close();
            _connection.Close();
            return  dataTable;
        }

        public List<Product> GetAllList()
        {
            

            ConnectionControl();

            SqlCommand command = new SqlCommand("select * from Products", _connection);
            SqlDataReader dataReader = command.ExecuteReader();


            List<Product> products=new List<Product>();

            while (dataReader.Read())
            {
                Product product=new Product
                {
                    Id = Convert.ToInt32(dataReader["Id"]),
                    Name = dataReader["Name"].ToString(),
                    Price = Convert.ToDecimal(dataReader["Price"]),
                    StockAmount = Convert.ToInt32(dataReader["StockAmount"])
                };

                products.Add(product);
            }
             
            dataReader.Close();
            _connection.Close();
            return products;
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void Add(Product product)
        {
            ConnectionControl();

            SqlCommand command=new SqlCommand("insert into products values(@name,@price,@stockAmount)",_connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@price", product.Price);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);

            command.ExecuteNonQuery();
            _connection.Close();
        }


        public void Update(Product product)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("update Products " +
    "set Name=@name,Price=@price,StockAmount=@stockAmount where Id=@Id", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@price", product.Price);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@Id", product.Id);

            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Delete(Product product)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("delete from Products where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Id", product.Id);

            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
