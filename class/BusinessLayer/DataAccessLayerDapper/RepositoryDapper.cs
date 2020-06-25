using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Utils.Interfaces;
using Utils.Models;


namespace DataAccessLayerDapper
{
    public class RepositoryDapper : ICRUD
    {
        private readonly string connection = string.Empty;
        public RepositoryDapper()
        {
            connection = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
        }
        public int DeleteOrderById(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                var deleteOrder = "Delete from orders where order_id=@ord_id";

                var numberResult = sqlConnection.Execute(deleteOrder, new { ord_id = id });
                return numberResult;
            }
        }

        public IList<Waybill> GetInfoAboutWayb()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                var view = "Select * from Informations";
                var select = sqlConnection.Query<Waybill>(view).AsList();
                return select;
            }
        }

        public int InsertOrders(Order order)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                var insertOrder = "INSERT INTO orders(order_id, order_date) " +
                    "Values(@order_id, @order_date)";
                var numberResult = sqlConnection.Execute(insertOrder,
                    new[] { new { order_id = order.OrderID, order_date = order.OrderDate } });
                return numberResult;

            }
        }

        public int UpdateWaybills(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                var updateWaybills = "UPDATE waybills set sales='1000' where row_id=@row_id";
                var numberResult = sqlConnection.Execute(updateWaybills, new { row_id = id });
                return numberResult;
            }
        }
    }
}