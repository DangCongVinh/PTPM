using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quản_lý_KaiOKen_Shop.DAO;


namespace Quản_lý_KaiOKen_Shop.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        private string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyShopBanGiay;Integrated Security=True";

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        public DataProvider() { }

        public DataTable ExecuteQuery(string query, object[] parameter = null) // trả về một table dữ liệu
        {
            DataTable datatb = new DataTable();// chưa dữ liệu lấy ra
            // using sẽ giải phóng dữ liệu khi hết using tránh dữ liệu bị sai
            using (SqlConnection connection = new SqlConnection(connectionSTR)) //truyền đường dẫn vào kết nôi db
            {
                connection.Open();//mở cổng kết nối dữ liệu
                SqlCommand command = new SqlCommand(query, connection);// sqlcommand biên dich câu lênh query

                if (parameter != null)
                {
                    string[] list = query.Split(' ');
                    int i = 0;
                    foreach(string item in list)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(datatb);// đổ dữ liêu vào datatable
                
                connection.Close();// đóng kết nối
            }
            return datatb;// trả về datatable để gọi ra ở các hàm khác
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)     // trả về số dòng thành công
        {
            int data = 0;
            // using sẽ giải phóng dữ liệu khi hết using tránh dữ liệu bị sai
            using (SqlConnection connection = new SqlConnection(connectionSTR)) //truyền đường dẫn vào kết nôi db
            {
                connection.Open();//mở cổng kết nối dữ liệu
                SqlCommand command = new SqlCommand(query, connection);// sqlcommand biên dich câu lênh query

                if (parameter != null)
                {
                    string[] list = query.Split(' ');
                    int i = 0;
                    foreach (string item in list)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();
                connection.Close();// đóng kết nối
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)     // thích hợp cho select count(*)
        {
            object data = 0;
            // using sẽ giải phóng dữ liệu khi hết using tránh dữ liệu bị sai
            using (SqlConnection connection = new SqlConnection(connectionSTR)) //truyền đường dẫn vào kết nôi db
            {
                connection.Open();//mở cổng kết nối dữ liệu
                SqlCommand command = new SqlCommand(query, connection);// sqlcommand biên dich câu lênh query

                if (parameter != null)
                {
                    string[] list = query.Split(' ');
                    int i = 0;
                    foreach (string item in list)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();
                connection.Close();// đóng kết nối
            }
            return data;
        }
    }
}
