using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_09_01.ExpressRouteCrossConnectionPeerings;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ExpressRoutePeeringTypeConstant
{
    [Description("AzurePrivatePeering")]
    AzurePrivatePeering,

    [Description("AzurePublicPeering")]
    AzurePublicPeering,

    [Description("MicrosoftPeering")]
    MicrosoftPeering,
}
