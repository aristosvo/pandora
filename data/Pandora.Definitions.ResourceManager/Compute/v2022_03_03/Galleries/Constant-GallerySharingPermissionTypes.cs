using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Compute.v2022_03_03.Galleries;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum GallerySharingPermissionTypesConstant
{
    [Description("Community")]
    Community,

    [Description("Groups")]
    Groups,

    [Description("Private")]
    Private,
}
