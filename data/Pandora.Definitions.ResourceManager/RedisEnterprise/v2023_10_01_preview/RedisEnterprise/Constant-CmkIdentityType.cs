using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.RedisEnterprise.v2023_10_01_preview.RedisEnterprise;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum CmkIdentityTypeConstant
{
    [Description("systemAssignedIdentity")]
    SystemAssignedIdentity,

    [Description("userAssignedIdentity")]
    UserAssignedIdentity,
}
