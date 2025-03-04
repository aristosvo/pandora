using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.DataProtection.v2023_12_01.FetchSecondaryRecoveryPoints;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum RehydrationStatusConstant
{
    [Description("COMPLETED")]
    COMPLETED,

    [Description("CREATE_IN_PROGRESS")]
    CREATEINPROGRESS,

    [Description("DELETED")]
    DELETED,

    [Description("DELETE_IN_PROGRESS")]
    DELETEINPROGRESS,

    [Description("FAILED")]
    FAILED,
}
