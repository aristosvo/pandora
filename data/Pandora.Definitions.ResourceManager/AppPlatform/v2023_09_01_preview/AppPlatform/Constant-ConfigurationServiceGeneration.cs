using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.AppPlatform.v2023_09_01_preview.AppPlatform;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ConfigurationServiceGenerationConstant
{
    [Description("Gen1")]
    GenOne,

    [Description("Gen2")]
    GenTwo,
}
