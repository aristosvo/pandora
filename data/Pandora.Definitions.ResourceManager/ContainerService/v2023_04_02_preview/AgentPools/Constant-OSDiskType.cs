using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.ContainerService.v2023_04_02_preview.AgentPools;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum OSDiskTypeConstant
{
    [Description("Ephemeral")]
    Ephemeral,

    [Description("Managed")]
    Managed,
}
