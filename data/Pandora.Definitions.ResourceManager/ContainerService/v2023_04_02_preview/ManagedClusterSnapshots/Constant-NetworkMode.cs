using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.ContainerService.v2023_04_02_preview.ManagedClusterSnapshots;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum NetworkModeConstant
{
    [Description("bridge")]
    Bridge,

    [Description("transparent")]
    Transparent,
}
