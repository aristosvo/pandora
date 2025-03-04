// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ResellerDelegatedAdminRelationshipStatusConstant
{
    [Description("Activating")]
    @activating,

    [Description("Active")]
    @active,

    [Description("ApprovalPending")]
    @approvalPending,

    [Description("Approved")]
    @approved,

    [Description("Created")]
    @created,

    [Description("Expired")]
    @expired,

    [Description("Expiring")]
    @expiring,

    [Description("Terminated")]
    @terminated,

    [Description("Terminating")]
    @terminating,

    [Description("TerminationRequested")]
    @terminationRequested,
}
