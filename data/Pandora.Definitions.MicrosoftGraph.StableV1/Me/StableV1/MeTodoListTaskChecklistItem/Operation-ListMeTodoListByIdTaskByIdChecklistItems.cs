// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Me.StableV1.MeTodoListTaskChecklistItem;

internal class ListMeTodoListByIdTaskByIdChecklistItemsOperation : Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";
    public override ResourceID? ResourceId() => new MeTodoListIdTaskId();
    public override Type NestedItemType() => typeof(ChecklistItemCollectionResponseModel);
    public override string? UriSuffix() => "/checklistItems";
}
