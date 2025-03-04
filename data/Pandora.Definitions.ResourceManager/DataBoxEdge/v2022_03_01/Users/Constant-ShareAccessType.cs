using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.DataBoxEdge.v2022_03_01.Users;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ShareAccessTypeConstant
{
    [Description("Change")]
    Change,

    [Description("Custom")]
    Custom,

    [Description("Read")]
    Read,
}
