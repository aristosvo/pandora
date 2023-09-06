using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Resources.v2023_07_01.Providers;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum AliasTypeConstant
{
    [Description("Mask")]
    Mask,

    [Description("NotSpecified")]
    NotSpecified,

    [Description("PlainText")]
    PlainText,
}
