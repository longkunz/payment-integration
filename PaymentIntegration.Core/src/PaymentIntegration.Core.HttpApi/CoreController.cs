using PaymentIntegration.Core.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PaymentIntegration.Core;

public abstract class CoreController : AbpControllerBase
{
    protected CoreController()
    {
        LocalizationResource = typeof(CoreResource);
    }
}
