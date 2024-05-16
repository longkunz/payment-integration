﻿using Volo.Abp.Modularity;

namespace PaymentIntegration.Core;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class CoreDomainTestBase<TStartupModule> : CoreTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
