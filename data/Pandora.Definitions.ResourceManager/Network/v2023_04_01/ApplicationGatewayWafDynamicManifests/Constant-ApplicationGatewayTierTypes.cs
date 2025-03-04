using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_04_01.ApplicationGatewayWafDynamicManifests;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ApplicationGatewayTierTypesConstant
{
    [Description("Standard")]
    Standard,

    [Description("Standard_v2")]
    StandardVTwo,

    [Description("WAF")]
    WAF,

    [Description("WAF_v2")]
    WAFVTwo,
}
