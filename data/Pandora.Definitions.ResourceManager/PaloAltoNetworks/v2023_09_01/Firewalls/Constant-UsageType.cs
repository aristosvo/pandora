using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.PaloAltoNetworks.v2023_09_01.Firewalls;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum UsageTypeConstant
{
    [Description("COMMITTED")]
    COMMITTED,

    [Description("PAYG")]
    PAYG,
}
