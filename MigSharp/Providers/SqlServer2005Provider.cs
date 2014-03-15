using System.Data;

namespace MigSharp.Providers
{
    [ProviderExport(ProviderNames.SqlServer2005, "System.Data.SqlClient", MaximumDbObjectNameLength = MaximumDbObjectNameLength)]
    [Supports(DbType.Xml)]
    internal class SqlServer2005Provider : SqlServerProvider
    {
    }
}