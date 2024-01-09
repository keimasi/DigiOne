using System.Collections.Generic;

namespace _0_Framwork.Infrastructure
{
    public interface IpermissionExposer
    {
        Dictionary<string, List<PermissionDto>> Expose();
    }
}
