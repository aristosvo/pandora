using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.VMware.v2023_03_01.HcxEnterpriseSites;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum HcxEnterpriseSiteStatusConstant
{
    [Description("Available")]
    Available,

    [Description("Consumed")]
    Consumed,

    [Description("Deactivated")]
    Deactivated,

    [Description("Deleted")]
    Deleted,
}
