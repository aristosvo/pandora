using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Web.v2023_01_01.AppServiceEnvironments;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum UpgradeAvailabilityConstant
{
    [Description("None")]
    None,

    [Description("Ready")]
    Ready,
}
