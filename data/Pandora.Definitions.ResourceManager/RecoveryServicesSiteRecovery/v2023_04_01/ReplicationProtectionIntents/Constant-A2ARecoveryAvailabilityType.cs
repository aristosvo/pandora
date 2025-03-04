using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.RecoveryServicesSiteRecovery.v2023_04_01.ReplicationProtectionIntents;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum A2ARecoveryAvailabilityTypeConstant
{
    [Description("AvailabilitySet")]
    AvailabilitySet,

    [Description("AvailabilityZone")]
    AvailabilityZone,

    [Description("Single")]
    Single,
}
