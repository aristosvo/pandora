using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_06_01.ConnectivityConfigurations;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum UseHubGatewayConstant
{
    [Description("False")]
    False,

    [Description("True")]
    True,
}
