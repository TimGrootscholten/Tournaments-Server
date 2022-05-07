﻿namespace Dtos
{
    public class UserInfoDto : BaseDto
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<PermissionGroupDto> PermissionGroups { get; set; }
    }
}
