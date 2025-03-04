using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Kusto.v2023_05_02.DatabasePrincipalAssignments;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum DatabasePrincipalAssignmentTypeConstant
{
    [Description("Microsoft.Kusto/clusters/databases/principalAssignments")]
    MicrosoftPointKustoClustersDatabasesPrincipalAssignments,
}
