using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.RecoveryServicesSiteRecovery.v2023_06_01.ReplicationProtectionIntents;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum AutoProtectionOfDataDiskConstant
{
    [Description("Disabled")]
    Disabled,

    [Description("Enabled")]
    Enabled,
}
