using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_09_01.VpnServerConfigurations;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum VpnAuthenticationTypeConstant
{
    [Description("AAD")]
    AAD,

    [Description("Certificate")]
    Certificate,

    [Description("Radius")]
    Radius,
}
