using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.CostManagement.v2023_08_01.BenefitRecommendations;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ScopeConstant
{
    [Description("Shared")]
    Shared,

    [Description("Single")]
    Single,
}
