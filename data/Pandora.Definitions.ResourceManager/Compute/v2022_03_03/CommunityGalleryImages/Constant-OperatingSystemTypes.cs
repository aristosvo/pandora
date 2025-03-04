using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Compute.v2022_03_03.CommunityGalleryImages;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum OperatingSystemTypesConstant
{
    [Description("Linux")]
    Linux,

    [Description("Windows")]
    Windows,
}
