using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.LabServices.v2023_06_07.VirtualMachine;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ProvisioningStateConstant
{
    [Description("Creating")]
    Creating,

    [Description("Deleting")]
    Deleting,

    [Description("Failed")]
    Failed,

    [Description("Locked")]
    Locked,

    [Description("Succeeded")]
    Succeeded,

    [Description("Updating")]
    Updating,
}
