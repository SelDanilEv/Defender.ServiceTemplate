﻿namespace Rentel.ServiceTemplate.Domain.Models;

public static class Roles
{
    public const string User = "User";
    public const string Admin = "Admin";
    public const string SuperAdmin = "SuperAdmin";

    public const string Any = "SuperAdmin,Admin,User";
}
