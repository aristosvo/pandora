using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.CosmosDB.v2023_11_15.CosmosDB;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum KindConstant
{
    [Description("Primary")]
    Primary,

    [Description("PrimaryReadonly")]
    PrimaryReadonly,

    [Description("Secondary")]
    Secondary,

    [Description("SecondaryReadonly")]
    SecondaryReadonly,
}
