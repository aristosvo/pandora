using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ManagementGroups.v2020_05_01.Entities;

internal class Definition : ResourceDefinition
{
    public string Name => "Entities";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new ListOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(InheritedPermissionsConstant),
        typeof(PermissionsConstant),
        typeof(SearchConstant),
        typeof(ViewConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(EntityInfoModel),
        typeof(EntityInfoPropertiesModel),
        typeof(EntityParentGroupInfoModel),
    };
}
