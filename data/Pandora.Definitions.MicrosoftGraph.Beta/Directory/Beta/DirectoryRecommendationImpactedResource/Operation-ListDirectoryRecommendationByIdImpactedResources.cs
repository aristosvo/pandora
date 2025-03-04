// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Directory.Beta.DirectoryRecommendationImpactedResource;

internal class ListDirectoryRecommendationByIdImpactedResourcesOperation : Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";
    public override ResourceID? ResourceId() => new DirectoryRecommendationId();
    public override Type NestedItemType() => typeof(ImpactedResourceCollectionResponseModel);
    public override string? UriSuffix() => "/impactedResources";
}
