using System.Collections.Generic;
using TestEmbeddedResources.Roles.Dto;
using TestEmbeddedResources.Users.Dto;

namespace TestEmbeddedResources.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}