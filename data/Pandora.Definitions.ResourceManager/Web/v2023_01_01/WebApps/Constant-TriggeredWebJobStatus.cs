using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Web.v2023_01_01.WebApps;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum TriggeredWebJobStatusConstant
{
    [Description("Error")]
    Error,

    [Description("Failed")]
    Failed,

    [Description("Success")]
    Success,
}
