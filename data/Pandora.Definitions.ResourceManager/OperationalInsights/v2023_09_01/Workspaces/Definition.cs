using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.OperationalInsights.v2023_09_01.Workspaces;

internal class Definition : ResourceDefinition
{
    public string Name => "Workspaces";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
        new ListByResourceGroupOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(CapacityReservationLevelConstant),
        typeof(DataIngestionStatusConstant),
        typeof(PublicNetworkAccessTypeConstant),
        typeof(WorkspaceEntityStatusConstant),
        typeof(WorkspaceSkuNameEnumConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(PrivateLinkScopedResourceModel),
        typeof(WorkspaceModel),
        typeof(WorkspaceCappingModel),
        typeof(WorkspaceFeaturesModel),
        typeof(WorkspaceListResultModel),
        typeof(WorkspacePatchModel),
        typeof(WorkspacePropertiesModel),
        typeof(WorkspaceSkuModel),
    };
}
