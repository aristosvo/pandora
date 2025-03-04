using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_10_01.Schedule;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum MonitorComputeIdentityTypeConstant
{
    [Description("AmlToken")]
    AmlToken,

    [Description("ManagedIdentity")]
    ManagedIdentity,
}
