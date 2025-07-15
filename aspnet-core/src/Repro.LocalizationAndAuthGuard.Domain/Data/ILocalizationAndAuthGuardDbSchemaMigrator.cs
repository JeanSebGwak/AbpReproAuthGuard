using System.Threading.Tasks;

namespace Repro.LocalizationAndAuthGuard.Data;

public interface ILocalizationAndAuthGuardDbSchemaMigrator
{
    Task MigrateAsync();
}
