using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Batch.v2023_11_01.Pool;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ComputeNodeDeallocationOptionConstant
{
    [Description("Requeue")]
    Requeue,

    [Description("RetainedData")]
    RetainedData,

    [Description("TaskCompletion")]
    TaskCompletion,

    [Description("Terminate")]
    Terminate,
}
