using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Cognitive.v2023_05_01.Skus;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ResourceSkuRestrictionsReasonCodeConstant
{
    [Description("NotAvailableForSubscription")]
    NotAvailableForSubscription,

    [Description("QuotaId")]
    QuotaId,
}
