﻿using Volo.Abp.Modularity;

namespace PaymentIntegration.Core;

[DependsOn(
    typeof(CoreApplicationModule),
    typeof(CoreDomainTestModule)
    )]
public class CoreApplicationTestModule : AbpModule
{

}
