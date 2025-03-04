using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.HDInsight.v2021_06_01.Applications;

internal class Definition : ResourceDefinition
{
    public string Name => "Applications";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListByClusterOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(DaysOfWeekConstant),
        typeof(PrivateIPAllocationMethodConstant),
        typeof(PrivateLinkConfigurationProvisioningStateConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(ApplicationModel),
        typeof(ApplicationGetEndpointModel),
        typeof(ApplicationGetHTTPSEndpointModel),
        typeof(ApplicationPropertiesModel),
        typeof(AutoscaleModel),
        typeof(AutoscaleCapacityModel),
        typeof(AutoscaleRecurrenceModel),
        typeof(AutoscaleScheduleModel),
        typeof(AutoscaleTimeAndCapacityModel),
        typeof(ComputeProfileModel),
        typeof(DataDisksGroupsModel),
        typeof(ErrorsModel),
        typeof(HardwareProfileModel),
        typeof(IPConfigurationModel),
        typeof(IPConfigurationPropertiesModel),
        typeof(LinuxOperatingSystemProfileModel),
        typeof(OsProfileModel),
        typeof(PrivateLinkConfigurationModel),
        typeof(PrivateLinkConfigurationPropertiesModel),
        typeof(ResourceIdModel),
        typeof(RoleModel),
        typeof(RuntimeScriptActionModel),
        typeof(ScriptActionModel),
        typeof(SshProfileModel),
        typeof(SshPublicKeyModel),
        typeof(VirtualNetworkProfileModel),
    };
}
