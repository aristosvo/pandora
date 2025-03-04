using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.PostgreSqlHSC.v2020_10_05_privatepreview.ServerGroups;

internal class Definition : ResourceDefinition
{
    public string Name => "ServerGroups";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CheckNameAvailabilityOperation(),
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
        new ListByResourceGroupOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(CheckNameAvailabilityResourceTypeConstant),
        typeof(CitusVersionConstant),
        typeof(CreateModeConstant),
        typeof(PostgreSQLVersionConstant),
        typeof(ResourceProviderTypeConstant),
        typeof(ServerEditionConstant),
        typeof(ServerRoleConstant),
        typeof(ServerStateConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(MaintenanceWindowModel),
        typeof(NameAvailabilityModel),
        typeof(NameAvailabilityRequestModel),
        typeof(ServerGroupModel),
        typeof(ServerGroupForUpdateModel),
        typeof(ServerGroupPropertiesModel),
        typeof(ServerGroupPropertiesDelegatedSubnetArgumentsModel),
        typeof(ServerGroupPropertiesForUpdateModel),
        typeof(ServerGroupPropertiesPrivateDnsZoneArgumentsModel),
        typeof(ServerNameItemModel),
        typeof(ServerRoleGroupModel),
    };
}
