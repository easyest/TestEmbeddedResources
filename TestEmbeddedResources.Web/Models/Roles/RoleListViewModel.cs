using System.Collections.Generic;
using TestEmbeddedResources.Roles.Dto;

namespace TestEmbeddedResources.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}