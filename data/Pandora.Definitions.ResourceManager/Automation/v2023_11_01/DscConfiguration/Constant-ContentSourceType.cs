using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Automation.v2023_11_01.DscConfiguration;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ContentSourceTypeConstant
{
    [Description("embeddedContent")]
    EmbeddedContent,

    [Description("uri")]
    Uri,
}
