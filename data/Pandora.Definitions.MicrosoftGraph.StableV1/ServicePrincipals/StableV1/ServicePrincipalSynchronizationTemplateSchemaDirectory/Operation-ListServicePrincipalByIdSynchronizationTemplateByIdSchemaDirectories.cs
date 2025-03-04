// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.ServicePrincipals.StableV1.ServicePrincipalSynchronizationTemplateSchemaDirectory;

internal class ListServicePrincipalByIdSynchronizationTemplateByIdSchemaDirectoriesOperation : Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";
    public override ResourceID? ResourceId() => new ServicePrincipalIdSynchronizationTemplateId();
    public override Type NestedItemType() => typeof(DirectoryDefinitionCollectionResponseModel);
    public override string? UriSuffix() => "/schema/directories";
}
