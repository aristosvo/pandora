using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.NetApp.v2023_07_01.VolumeGroups;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum FileAccessLogsConstant
{
    [Description("Disabled")]
    Disabled,

    [Description("Enabled")]
    Enabled,
}
