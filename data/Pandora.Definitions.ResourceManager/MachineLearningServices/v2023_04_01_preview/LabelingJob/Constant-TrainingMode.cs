using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_04_01_preview.LabelingJob;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum TrainingModeConstant
{
    [Description("Auto")]
    Auto,

    [Description("Distributed")]
    Distributed,

    [Description("NonDistributed")]
    NonDistributed,
}
