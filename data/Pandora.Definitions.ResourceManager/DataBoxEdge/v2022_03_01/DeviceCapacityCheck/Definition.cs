using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DataBoxEdge.v2022_03_01.DeviceCapacityCheck;

internal class Definition : ResourceDefinition
{
    public string Name => "DeviceCapacityCheck";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CheckResourceCreationFeasibilityOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(DeviceCapacityRequestInfoModel),
        typeof(DeviceCapacityRequestInfoPropertiesModel),
        typeof(VMPlacementRequestResultModel),
    };
}
