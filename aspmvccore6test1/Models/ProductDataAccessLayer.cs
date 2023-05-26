using aspmvccore6test1.Utility;
using System.Data.SqlClient;


namespace aspmvccore6test1.Models
{
    public class ProductDataAccessLayer
    {
        //link to Utility/CName    
        public static string  connectionString = ConnectionString.CName;



        //read data
        public static Product GetStudentData()
        {
            Product product = new Product();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM P_Product";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Product.NOP = rdr["NOP"].ToString();
                }
            }
            return product;
        }



    }
}
