using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Sql.v2021_11_01.LocationCapabilities;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum StorageAccountTypeConstant
{
    [Description("GRS")]
    GRS,

    [Description("GZRS")]
    GZRS,

    [Description("LRS")]
    LRS,

    [Description("ZRS")]
    ZRS,
}
