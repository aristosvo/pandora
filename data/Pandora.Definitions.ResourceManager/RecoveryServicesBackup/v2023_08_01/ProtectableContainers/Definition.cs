using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RecoveryServicesBackup.v2023_08_01.ProtectableContainers;

internal class Definition : ResourceDefinition
{
    public string Name => "ProtectableContainers";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new ListOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(BackupManagementTypeConstant),
        typeof(ProtectableContainerTypeConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(AzureStorageProtectableContainerModel),
        typeof(AzureVMAppContainerProtectableContainerModel),
        typeof(ProtectableContainerModel),
        typeof(ProtectableContainerResourceModel),
    };
}
