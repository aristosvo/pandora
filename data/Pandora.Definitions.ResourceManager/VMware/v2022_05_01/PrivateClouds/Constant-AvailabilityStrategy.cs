using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.VMware.v2022_05_01.PrivateClouds;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum AvailabilityStrategyConstant
{
    [Description("DualZone")]
    DualZone,

    [Description("SingleZone")]
    SingleZone,
}
