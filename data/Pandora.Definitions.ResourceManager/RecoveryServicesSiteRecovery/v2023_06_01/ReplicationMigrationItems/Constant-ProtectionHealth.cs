using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.RecoveryServicesSiteRecovery.v2023_06_01.ReplicationMigrationItems;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ProtectionHealthConstant
{
    [Description("Critical")]
    Critical,

    [Description("None")]
    None,

    [Description("Normal")]
    Normal,

    [Description("Warning")]
    Warning,
}
