using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_10_01.BatchDeployment;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum DeploymentProvisioningStateConstant
{
    [Description("Canceled")]
    Canceled,

    [Description("Creating")]
    Creating,

    [Description("Deleting")]
    Deleting,

    [Description("Failed")]
    Failed,

    [Description("Scaling")]
    Scaling,

    [Description("Succeeded")]
    Succeeded,

    [Description("Updating")]
    Updating,
}
