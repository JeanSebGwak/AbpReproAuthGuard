using Repro.LocalizationAndAuthGuard.Samples;
using Xunit;

namespace Repro.LocalizationAndAuthGuard.EntityFrameworkCore.Applications;

[Collection(LocalizationAndAuthGuardTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<LocalizationAndAuthGuardEntityFrameworkCoreTestModule>
{

}
