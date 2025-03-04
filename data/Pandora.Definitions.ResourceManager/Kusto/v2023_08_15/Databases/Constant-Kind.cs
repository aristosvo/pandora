using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Kusto.v2023_08_15.Databases;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum KindConstant
{
    [Description("ReadOnlyFollowing")]
    ReadOnlyFollowing,

    [Description("ReadWrite")]
    ReadWrite,
}
