using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_05_01.SecurityPartnerProviders;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum SecurityProviderNameConstant
{
    [Description("Checkpoint")]
    Checkpoint,

    [Description("IBoss")]
    IBoss,

    [Description("ZScaler")]
    ZScaler,
}
