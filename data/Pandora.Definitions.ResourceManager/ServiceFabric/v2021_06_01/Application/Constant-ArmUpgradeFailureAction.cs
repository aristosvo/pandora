using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.ServiceFabric.v2021_06_01.Application;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ArmUpgradeFailureActionConstant
{
    [Description("Manual")]
    Manual,

    [Description("Rollback")]
    Rollback,
}
