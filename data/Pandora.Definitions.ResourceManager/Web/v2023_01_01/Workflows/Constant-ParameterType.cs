using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Web.v2023_01_01.Workflows;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ParameterTypeConstant
{
    [Description("Array")]
    Array,

    [Description("Bool")]
    Bool,

    [Description("Float")]
    Float,

    [Description("Int")]
    Int,

    [Description("NotSpecified")]
    NotSpecified,

    [Description("Object")]
    Object,

    [Description("SecureObject")]
    SecureObject,

    [Description("SecureString")]
    SecureString,

    [Description("String")]
    String,
}
