using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.RedHatOpenShift.v2023_09_04.OpenShiftClusters;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum OutboundTypeConstant
{
    [Description("Loadbalancer")]
    Loadbalancer,

    [Description("UserDefinedRouting")]
    UserDefinedRouting,
}
