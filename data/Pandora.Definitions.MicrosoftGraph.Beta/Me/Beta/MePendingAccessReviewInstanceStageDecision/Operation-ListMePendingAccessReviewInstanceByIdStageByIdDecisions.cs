// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Me.Beta.MePendingAccessReviewInstanceStageDecision;

internal class ListMePendingAccessReviewInstanceByIdStageByIdDecisionsOperation : Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";
    public override ResourceID? ResourceId() => new MePendingAccessReviewInstanceIdStageId();
    public override Type NestedItemType() => typeof(AccessReviewInstanceDecisionItemCollectionResponseModel);
    public override string? UriSuffix() => "/decisions";
}
