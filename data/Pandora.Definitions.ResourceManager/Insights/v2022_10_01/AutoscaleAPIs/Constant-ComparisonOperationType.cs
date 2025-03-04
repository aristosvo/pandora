using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Insights.v2022_10_01.AutoscaleAPIs;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ComparisonOperationTypeConstant
{
    [Description("Equals")]
    Equals,

    [Description("GreaterThan")]
    GreaterThan,

    [Description("GreaterThanOrEqual")]
    GreaterThanOrEqual,

    [Description("LessThan")]
    LessThan,

    [Description("LessThanOrEqual")]
    LessThanOrEqual,

    [Description("NotEquals")]
    NotEquals,
}
