using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Insights.v2022_06_01.DataCollectionEndpoints;

internal class Definition : ResourceDefinition
{
    public string Name => "DataCollectionEndpoints";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListByResourceGroupOperation(),
        new ListBySubscriptionOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(KnownDataCollectionEndpointProvisioningStateConstant),
        typeof(KnownDataCollectionEndpointResourceKindConstant),
        typeof(KnownLocationSpecProvisioningStatusConstant),
        typeof(KnownPublicNetworkAccessOptionsConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(ConfigurationAccessEndpointSpecModel),
        typeof(DataCollectionEndpointModel),
        typeof(DataCollectionEndpointResourceModel),
        typeof(FailoverConfigurationSpecModel),
        typeof(LocationSpecModel),
        typeof(LogsIngestionEndpointSpecModel),
        typeof(MetadataModel),
        typeof(MetricsIngestionEndpointSpecModel),
        typeof(NetworkRuleSetModel),
        typeof(PrivateLinkScopedResourceModel),
        typeof(ResourceForUpdateModel),
    };
}
