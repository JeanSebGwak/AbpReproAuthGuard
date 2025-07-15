using Repro.LocalizationAndAuthGuard.Samples;
using Xunit;

namespace Repro.LocalizationAndAuthGuard.EntityFrameworkCore.Domains;

[Collection(LocalizationAndAuthGuardTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<LocalizationAndAuthGuardEntityFrameworkCoreTestModule>
{

}
