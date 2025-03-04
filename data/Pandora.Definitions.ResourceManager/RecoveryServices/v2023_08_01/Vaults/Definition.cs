using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RecoveryServices.v2023_08_01.Vaults;

internal class Definition : ResourceDefinition
{
    public string Name => "Vaults";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListByResourceGroupOperation(),
        new ListBySubscriptionIdOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(AlertsStateConstant),
        typeof(BackupStorageVersionConstant),
        typeof(CrossRegionRestoreConstant),
        typeof(CrossSubscriptionRestoreStateConstant),
        typeof(EnhancedSecurityStateConstant),
        typeof(ImmutabilityStateConstant),
        typeof(InfrastructureEncryptionStateConstant),
        typeof(MultiUserAuthorizationConstant),
        typeof(PrivateEndpointConnectionStatusConstant),
        typeof(ProvisioningStateConstant),
        typeof(PublicNetworkAccessConstant),
        typeof(ResourceMoveStateConstant),
        typeof(SecureScoreLevelConstant),
        typeof(SkuNameConstant),
        typeof(SoftDeleteStateConstant),
        typeof(StandardTierStorageRedundancyConstant),
        typeof(TriggerTypeConstant),
        typeof(VaultPrivateEndpointStateConstant),
        typeof(VaultSubResourceTypeConstant),
        typeof(VaultUpgradeStateConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(AzureMonitorAlertSettingsModel),
        typeof(ClassicAlertSettingsModel),
        typeof(CmkKekIdentityModel),
        typeof(CmkKeyVaultPropertiesModel),
        typeof(CrossSubscriptionRestoreSettingsModel),
        typeof(ImmutabilitySettingsModel),
        typeof(MonitoringSettingsModel),
        typeof(PatchVaultModel),
        typeof(PrivateEndpointModel),
        typeof(PrivateEndpointConnectionModel),
        typeof(PrivateEndpointConnectionVaultPropertiesModel),
        typeof(PrivateLinkServiceConnectionStateModel),
        typeof(RestoreSettingsModel),
        typeof(SecuritySettingsModel),
        typeof(SkuModel),
        typeof(SoftDeleteSettingsModel),
        typeof(UpgradeDetailsModel),
        typeof(VaultModel),
        typeof(VaultPropertiesModel),
        typeof(VaultPropertiesEncryptionModel),
        typeof(VaultPropertiesMoveDetailsModel),
        typeof(VaultPropertiesRedundancySettingsModel),
    };
}
