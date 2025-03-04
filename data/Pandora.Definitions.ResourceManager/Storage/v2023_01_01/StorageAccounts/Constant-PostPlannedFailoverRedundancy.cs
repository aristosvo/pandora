using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Storage.v2023_01_01.StorageAccounts;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum PostPlannedFailoverRedundancyConstant
{
    [Description("Standard_GRS")]
    StandardGRS,

    [Description("Standard_GZRS")]
    StandardGZRS,

    [Description("Standard_RAGRS")]
    StandardRAGRS,

    [Description("Standard_RAGZRS")]
    StandardRAGZRS,
}
