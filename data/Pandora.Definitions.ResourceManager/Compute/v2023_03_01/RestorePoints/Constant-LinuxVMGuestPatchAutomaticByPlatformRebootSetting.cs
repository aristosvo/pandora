using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Compute.v2023_03_01.RestorePoints;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum LinuxVMGuestPatchAutomaticByPlatformRebootSettingConstant
{
    [Description("Always")]
    Always,

    [Description("IfRequired")]
    IfRequired,

    [Description("Never")]
    Never,

    [Description("Unknown")]
    Unknown,
}
