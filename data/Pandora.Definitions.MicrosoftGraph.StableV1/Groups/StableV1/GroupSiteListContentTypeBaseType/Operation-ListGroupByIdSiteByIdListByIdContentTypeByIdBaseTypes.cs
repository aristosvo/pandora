// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Groups.StableV1.GroupSiteListContentTypeBaseType;

internal class ListGroupByIdSiteByIdListByIdContentTypeByIdBaseTypesOperation : Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";
    public override ResourceID? ResourceId() => new GroupIdSiteIdListIdContentTypeId();
    public override Type NestedItemType() => typeof(ContentTypeCollectionResponseModel);
    public override string? UriSuffix() => "/baseTypes";
}
