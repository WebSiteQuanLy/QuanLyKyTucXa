using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace QLKTX
{
    public class DataHelper
    {
        private static SqlConnection _connection = null;

        public DataHelper()
        {
            _connection = new SqlConnection(@"Data Source=ASUS\SQLEXPRESS;Initial Catalog=QLKTX;Integrated Security=True");///Chuỗi kết nối với cơ sở dữ liệu
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable table = new DataTable(); ///Tạo 1 bảng ảo chứ dữ liệu 
            ///Bắt ngoại lệ 
            try
            {
                _connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                throw new Exception("Execute query erorr: " + ex.Message);
            }
            finally
            {
                _connection.Close();///Đóng kết nối
            }
            return table;
        }
    }
}
