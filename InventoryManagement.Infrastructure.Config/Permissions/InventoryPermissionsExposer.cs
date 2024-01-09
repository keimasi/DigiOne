using System.Collections.Generic;
using _0_Framwork.Infrastructure;

namespace InventoryManagement.Infrastructure.Config.Permissions
{
    public class InventoryPermissionsExposer : IpermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Inventory", new List<PermissionDto>
                    {
                        new PermissionDto(InventoryPermissions.CreateInventory, "CreateInventory"),
                        new PermissionDto(InventoryPermissions.EditInventory, "EditInventory"),
                        new PermissionDto(InventoryPermissions.ListInventory, "ListInventory"),
                        new PermissionDto(InventoryPermissions.Increase, "Increase"),
                        new PermissionDto(InventoryPermissions.Decrease, "Decrease"),
                        new PermissionDto(InventoryPermissions.OperationLog, "OperationLog"),
                    }
                }
            };
        }
    }
}
