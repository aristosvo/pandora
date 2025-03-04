using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RecoveryServicesBackup.v2023_04_01.BackupResourceEncryptionConfigs;

internal class Definition : ResourceDefinition
{
    public string Name => "BackupResourceEncryptionConfigs";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new GetOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(EncryptionAtRestTypeConstant),
        typeof(InfrastructureEncryptionStateConstant),
        typeof(LastUpdateStatusConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(BackupResourceEncryptionConfigModel),
        typeof(BackupResourceEncryptionConfigExtendedModel),
        typeof(BackupResourceEncryptionConfigExtendedResourceModel),
        typeof(BackupResourceEncryptionConfigResourceModel),
    };
}
