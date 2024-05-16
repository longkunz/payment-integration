﻿using Volo.Abp;
using Volo.Abp.MongoDB;

namespace PaymentIntegration.Core.MongoDB;

public static class CoreMongoDbContextExtensions
{
    public static void ConfigureCore(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
