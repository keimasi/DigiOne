using System.Collections.Generic;
using System.Linq;
using _0_Framwork.Domain;

namespace InventoryManagement.Domain.Inventory
{
    public class InventoryEntity : EntityBace
    {
        public int ProductId { get; private set; }
        public double UnitPrice { get; private set; }
        public bool InStock { get; private set; }
        public List<OperationInventory> OperationInventories { get; private set; }

        protected InventoryEntity()
        {
        }

        public InventoryEntity(int productId, double unitPrice)
        {

            InStock = false;
        }

        public void Edit(int productId, double unitPrice)
        {
            ProductId = productId;
            UnitPrice = unitPrice;
        }

        public int CalculationCurrentCount()
        {
            var plus = OperationInventories.Where(x => x.OperationType).Sum(x => x.Count);
            var minus = OperationInventories.Where(x => !x.OperationType).Sum(x => x.Count);
            return plus - minus;
        }

        public void Increase(int operatorId, int count, string description)
        {
            var currentCount = CalculationCurrentCount() + count;
            var operation = new OperationInventory(operatorId, 0, true, currentCount, description, count, Id);
            OperationInventories.Add(operation);
            InStock = currentCount > 0;
        }

        public void Decrease(int operatorId, int count, string description,int orderId)
        {
            var currentCount = CalculationCurrentCount() - count;
            var operation=new OperationInventory(operatorId,orderId,false,currentCount,description,count, Id);
            OperationInventories.Add(operation);
            InStock= currentCount > 0;
        }
    }
}
