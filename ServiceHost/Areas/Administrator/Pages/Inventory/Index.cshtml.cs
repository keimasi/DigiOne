using System.Collections.Generic;
using _0_Framwork.Infrastructure;
using InventoryManagement.Application.Contracts.Inventory;
using InventoryManagement.Infrastructure.Config.Permissions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.Product;

namespace ServiceHost.Areas.Administrator.Pages.inventory
{
    public class IndexModel : PageModel
    {
        public List<InventoryViewModel> InventoryList;

        private readonly IProductApplication _productApplication;
        private readonly IInventoryApplication _inventoryApplication;

        public IndexModel(IInventoryApplication inventoryApplication, IProductApplication productApplication)
        {
            _inventoryApplication = inventoryApplication;
            _productApplication = productApplication;
        }

        [NeedsPermission(InventoryPermissions.ListInventory)]
        public void OnGet()
        {
            InventoryList = _inventoryApplication.GetInventories();
        }

        [NeedsPermission(InventoryPermissions.CreateInventory)]
        public IActionResult OnGetCreate()
        {
            var command = new CreateInventory()
            {
                Product = _productApplication.GetProducts()
            };
            return Partial("./Create", command);
        }

        [NeedsPermission(InventoryPermissions.CreateInventory)]
        public JsonResult OnPostCreate(CreateInventory command)
        {
            var result = _inventoryApplication.Create(command);
            return new JsonResult(result);
        }

        [NeedsPermission(InventoryPermissions.EditInventory)]
        public IActionResult OnGetEdit(int id)
        {
            var inventory = _inventoryApplication.GetDetails(id);
            inventory.Product = _productApplication.GetProducts();
            return Partial("Edit", inventory);
        }

        [NeedsPermission(InventoryPermissions.EditInventory)]
        public JsonResult OnPostEdit(EditInventory command)
        {
            var result = _inventoryApplication.Edit(command);
            return new JsonResult(result);
        }

        [NeedsPermission(InventoryPermissions.Increase)]
        public IActionResult OnGetIncrease(int id)
        {
            var command = new IncreaseInventory
            {
                InventoryId = id
            };
            return Partial("Increase", command);
        }

        [NeedsPermission(InventoryPermissions.Increase)]
        public JsonResult OnPostIncrease(IncreaseInventory command)
        {
            var result = _inventoryApplication.Increase(command);
            return new JsonResult(result);
        }

        [NeedsPermission(InventoryPermissions.Decrease)]
        public IActionResult OnGetDecrease(int id)
        {
            var command = new DecreaseInventory()
            {
                InventoryId = id
            };
            return Partial("Decrease", command);
        }

        [NeedsPermission(InventoryPermissions.Decrease)]
        public JsonResult OnPostDecrease(DecreaseInventory command)
        {
            var result = _inventoryApplication.Decrease(command);
            return new JsonResult(result);
        }


        [NeedsPermission(InventoryPermissions.OperationLog)]
        public IActionResult OnGetLog(int id)
        {
            var log = _inventoryApplication.GetInventoryOperationLog(id);
            return Partial("InventoryOperationLog", log);
        }
    }
}
