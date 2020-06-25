using DataAccessLayerADO;
using System.Collections.Generic;
using Utils.Interfaces;
using Utils.Models;

namespace BusinessLayer
{
    public class Manager
    {
        private readonly ICRUD repository;
        public Manager()
        {
            repository = new RepositoryADO();
            //repository = new RepositoryDapper();
        }
        public IList<Waybill> GetInfoAboutWayb()
        {
            return repository.GetInfoAboutWayb();

        }
        public int InsertOrders(Order order)
        {
            return repository.InsertOrders(order);
        }
        public int DeleteOrderById(int id)
        {
            return repository.DeleteOrderById(id);
        }
        public int UpdateWaybills(int id)
        {
            return repository.UpdateWaybills(id);
        }
    }
}