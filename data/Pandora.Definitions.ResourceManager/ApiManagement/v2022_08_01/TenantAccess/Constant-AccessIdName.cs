using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.ApiManagement.v2022_08_01.TenantAccess;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum AccessIdNameConstant
{
    [Description("access")]
    Access,

    [Description("gitAccess")]
    GitAccess,
}
