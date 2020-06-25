using System.Collections.Generic;
using Utils.Models;

namespace Utils.Interfaces
{
    public interface ICRUD
    {
        IList<Waybill> GetInfoAboutWayb();
        int InsertOrders(Order order);
        int DeleteOrderById(int id);
        int UpdateWaybills(int id);
    }
}