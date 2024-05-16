﻿using Volo.Abp.Reflection;

namespace PaymentIntegration.Core.Permissions;

public class CorePermissions
{
    public const string GroupName = "Core";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(CorePermissions));
    }
}
