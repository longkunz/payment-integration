using PaymentIntegration.Core.Localization;
using Volo.Abp.Application.Services;

namespace PaymentIntegration.Core;

public abstract class CoreAppService : ApplicationService
{
    protected CoreAppService()
    {
        LocalizationResource = typeof(CoreResource);
        ObjectMapperContext = typeof(CoreApplicationModule);
    }
}
