using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_06_01.VirtualWANs;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum AuthenticationMethodConstant
{
    [Description("EAPMSCHAPv2")]
    EAPMSCHAPvTwo,

    [Description("EAPTLS")]
    EAPTLS,
}
