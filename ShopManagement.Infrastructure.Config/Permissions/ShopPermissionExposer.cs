using System.Collections.Generic;
using _0_Framwork.Infrastructure;

namespace ShopManagement.Infrastructure.Config.Permissions
{
    public class ShopPermissionExposer:IpermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Product",new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.CreateProduct,"CreateProduct"),
                        new PermissionDto(ShopPermissions.EditProduct,"EditProduct"),
                        new PermissionDto(ShopPermissions.ListProduct,"ListProduct")
                    }
                },
                {
                    "ProductCategory",new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.CreateProductCategory,"CreateProductCategory"),
                        new PermissionDto(ShopPermissions.EditProductCategory,"EditProductCategory"),
                        new PermissionDto(ShopPermissions.ListProductCategory,"ListProductCategory"),
                    }
                }
            };
        }
    }
}
