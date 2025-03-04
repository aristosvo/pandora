using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.DataBoxEdge.v2023_07_01.Devices;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum JobStatusConstant
{
    [Description("Canceled")]
    Canceled,

    [Description("Failed")]
    Failed,

    [Description("Invalid")]
    Invalid,

    [Description("Paused")]
    Paused,

    [Description("Running")]
    Running,

    [Description("Scheduled")]
    Scheduled,

    [Description("Succeeded")]
    Succeeded,
}
