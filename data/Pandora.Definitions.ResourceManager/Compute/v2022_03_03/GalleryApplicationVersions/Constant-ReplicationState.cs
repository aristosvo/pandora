using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Compute.v2022_03_03.GalleryApplicationVersions;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ReplicationStateConstant
{
    [Description("Completed")]
    Completed,

    [Description("Failed")]
    Failed,

    [Description("Replicating")]
    Replicating,

    [Description("Unknown")]
    Unknown,
}
