using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Utils.Interfaces;
using Utils.Models;

namespace DataAccessLayerADO
{
    public class RepositoryADO : ICRUD
    {
        private readonly string connection = string.Empty;
        public RepositoryADO()
        {
            connection = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
        }
        public int DeleteOrderById(int id)
        {
            using (SqlConnection scn = new SqlConnection())
            {
                scn.ConnectionString = connection;
                scn.Open();

                var deleteOrder = "DELETE FROM orders WHERE order_id=@order_id;";

                SqlCommand sqlCommand = new SqlCommand(deleteOrder, scn);
                sqlCommand.Parameters.Add("@order_id", SqlDbType.Int).Value = id;
                var newOrder = sqlCommand.ExecuteNonQuery();
                return newOrder;
            }
        }
        public IList<Waybill> GetInfoAboutWayb()
        {
            var waybillsList = new List<Waybill>();
            var view = "SELECT * FROM Informations";
            var adapter = new SqlDataAdapter(view, connection);
            var waybillsSet = new DataSet();
            adapter.Fill(waybillsSet, "Waybills");
            foreach (DataRow row in waybillsSet.Tables["Waybills"].Rows)
            {
                waybillsList.Add(new Waybill((int)row[0], (string)row[1], (string)row[2], (string)row[3]));
            }
            return waybillsList;
        }

        public int InsertOrders(Order order)
        {
            using (SqlConnection scn = new SqlConnection())
            {
                scn.ConnectionString = connection;
                scn.Open();

                var insertOrder = "INSERT INTO orders(order_id, order_date) Values(@order_id, @order_date)";

                SqlCommand sqlCommand = new SqlCommand(insertOrder, scn);
                sqlCommand.Parameters.Add("@order_id", SqlDbType.Int).Value = order.OrderID;
                sqlCommand.Parameters.Add("@order_date", SqlDbType.DateTime).Value = order.OrderDate;
                var newOrder = sqlCommand.ExecuteNonQuery();
                return newOrder;
            }
        }

        public int UpdateWaybills(int id)
        {
            using (SqlConnection scn = new SqlConnection())
            {
                scn.ConnectionString = connection;
                scn.Open();

                var updateWaybills = "UPDATE waybills set sales='1000' where row_id=@row_id";
                SqlCommand sqlCommand = new SqlCommand(updateWaybills, scn);
                sqlCommand.Parameters.Add("@row_id", SqlDbType.Int).Value = id;
                var newOrder = sqlCommand.ExecuteNonQuery();
                return newOrder;
            }
        }
    }
}