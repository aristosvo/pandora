using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.StorageMover.v2023_10_01.Agents;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum AgentStatusConstant
{
    [Description("Executing")]
    Executing,

    [Description("Offline")]
    Offline,

    [Description("Online")]
    Online,

    [Description("Registering")]
    Registering,

    [Description("RequiresAttention")]
    RequiresAttention,

    [Description("Unregistering")]
    Unregistering,
}
