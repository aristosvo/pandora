using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Compute.v2023_04_02.Snapshots;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum NetworkAccessPolicyConstant
{
    [Description("AllowAll")]
    AllowAll,

    [Description("AllowPrivate")]
    AllowPrivate,

    [Description("DenyAll")]
    DenyAll,
}
