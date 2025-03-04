using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.StorageSync.v2022_09_01.WorkflowResource;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum OperationDirectionConstant
{
    [Description("cancel")]
    Cancel,

    [Description("do")]
    Do,

    [Description("undo")]
    Undo,
}
