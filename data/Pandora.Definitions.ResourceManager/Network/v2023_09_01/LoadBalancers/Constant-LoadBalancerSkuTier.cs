using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_09_01.LoadBalancers;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum LoadBalancerSkuTierConstant
{
    [Description("Global")]
    Global,

    [Description("Regional")]
    Regional,
}
