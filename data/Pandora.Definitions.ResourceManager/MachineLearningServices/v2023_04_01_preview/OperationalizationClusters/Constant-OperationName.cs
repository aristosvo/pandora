using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_04_01_preview.OperationalizationClusters;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum OperationNameConstant
{
    [Description("Create")]
    Create,

    [Description("Delete")]
    Delete,

    [Description("Reimage")]
    Reimage,

    [Description("Restart")]
    Restart,

    [Description("Start")]
    Start,

    [Description("Stop")]
    Stop,
}
