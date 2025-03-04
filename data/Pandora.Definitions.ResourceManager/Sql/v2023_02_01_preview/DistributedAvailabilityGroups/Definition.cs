using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Sql.v2023_02_01_preview.DistributedAvailabilityGroups;

internal class Definition : ResourceDefinition
{
    public string Name => "DistributedAvailabilityGroups";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListByInstanceOperation(),
        new SetRoleOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(InstanceRoleConstant),
        typeof(LinkRoleConstant),
        typeof(ReplicaConnectedStateConstant),
        typeof(ReplicaSynchronizationHealthConstant),
        typeof(ReplicationModeTypeConstant),
        typeof(RoleChangeTypeConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(CertificateInfoModel),
        typeof(CreateOrUpdatePropertiesModel),
        typeof(DistributedAvailabilityGroupModel),
        typeof(DistributedAvailabilityGroupDatabaseModel),
        typeof(DistributedAvailabilityGroupPropertiesModel),
        typeof(DistributedAvailabilityGroupSetRoleModel),
        typeof(DistributedAvailabilityGroupsCreateOrUpdateRequestBodyModel),
    };
}
