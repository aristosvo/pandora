using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Media.v2022_07_01.Encodings;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ComplexityConstant
{
    [Description("Balanced")]
    Balanced,

    [Description("Quality")]
    Quality,

    [Description("Speed")]
    Speed,
}
