using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.NetworkCloud.v2023_07_01.Networkclouds;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum VirtualMachineDetailedStatusConstant
{
    [Description("Available")]
    Available,

    [Description("Error")]
    Error,

    [Description("Provisioning")]
    Provisioning,

    [Description("Running")]
    Running,

    [Description("Scheduling")]
    Scheduling,

    [Description("Stopped")]
    Stopped,

    [Description("Terminating")]
    Terminating,

    [Description("Unknown")]
    Unknown,
}
