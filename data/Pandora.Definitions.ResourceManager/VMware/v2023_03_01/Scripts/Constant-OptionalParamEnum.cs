using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.VMware.v2023_03_01.Scripts;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum OptionalParamEnumConstant
{
    [Description("Optional")]
    Optional,

    [Description("Required")]
    Required,
}
