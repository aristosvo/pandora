using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.CostManagement.v2023_08_01.CostAllocationRules;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum RuleStatusConstant
{
    [Description("Active")]
    Active,

    [Description("NotActive")]
    NotActive,

    [Description("Processing")]
    Processing,
}
