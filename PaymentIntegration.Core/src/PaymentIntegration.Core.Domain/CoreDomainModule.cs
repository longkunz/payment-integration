﻿using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace PaymentIntegration.Core;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(CoreDomainSharedModule)
)]
public class CoreDomainModule : AbpModule
{

}
