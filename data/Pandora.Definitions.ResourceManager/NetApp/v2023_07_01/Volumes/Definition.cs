using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.NetApp.v2023_07_01.Volumes;

internal class Definition : ResourceDefinition
{
    public string Name => "Volumes";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
        new PopulateAvailabilityZoneOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(AvsDataStoreConstant),
        typeof(ChownModeConstant),
        typeof(CoolAccessRetrievalPolicyConstant),
        typeof(EnableSubvolumesConstant),
        typeof(EncryptionKeySourceConstant),
        typeof(EndpointTypeConstant),
        typeof(FileAccessLogsConstant),
        typeof(NetworkFeaturesConstant),
        typeof(ReplicationScheduleConstant),
        typeof(SecurityStyleConstant),
        typeof(ServiceLevelConstant),
        typeof(SmbAccessBasedEnumerationConstant),
        typeof(SmbNonBrowsableConstant),
        typeof(VolumeStorageToNetworkProximityConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(ExportPolicyRuleModel),
        typeof(MountTargetPropertiesModel),
        typeof(PlacementKeyValuePairsModel),
        typeof(ReplicationObjectModel),
        typeof(VolumeModel),
        typeof(VolumePatchModel),
        typeof(VolumePatchPropertiesModel),
        typeof(VolumePatchPropertiesDataProtectionModel),
        typeof(VolumePatchPropertiesExportPolicyModel),
        typeof(VolumePropertiesModel),
        typeof(VolumePropertiesDataProtectionModel),
        typeof(VolumePropertiesExportPolicyModel),
        typeof(VolumeRelocationPropertiesModel),
        typeof(VolumeSnapshotPropertiesModel),
    };
}
