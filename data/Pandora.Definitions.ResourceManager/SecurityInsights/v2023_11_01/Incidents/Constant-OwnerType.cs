using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.SecurityInsights.v2023_11_01.Incidents;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum OwnerTypeConstant
{
    [Description("Group")]
    Group,

    [Description("Unknown")]
    Unknown,

    [Description("User")]
    User,
}
