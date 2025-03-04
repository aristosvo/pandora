using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_04_01.Schedule;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum OutputDeliveryModeConstant
{
    [Description("ReadWriteMount")]
    ReadWriteMount,

    [Description("Upload")]
    Upload,
}
