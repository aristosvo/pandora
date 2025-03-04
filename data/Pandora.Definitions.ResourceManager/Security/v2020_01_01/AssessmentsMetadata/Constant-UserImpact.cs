using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Security.v2020_01_01.AssessmentsMetadata;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum UserImpactConstant
{
    [Description("High")]
    High,

    [Description("Low")]
    Low,

    [Description("Moderate")]
    Moderate,
}
