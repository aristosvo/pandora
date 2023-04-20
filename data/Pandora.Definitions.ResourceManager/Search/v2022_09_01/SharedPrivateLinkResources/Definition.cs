using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Search.v2022_09_01.SharedPrivateLinkResources;

internal class Definition : ResourceDefinition
{
    public string Name => "SharedPrivateLinkResources";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListByServiceOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(SharedPrivateLinkResourceProvisioningStateConstant),
        typeof(SharedPrivateLinkResourceStatusConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(SharedPrivateLinkResourceModel),
        typeof(SharedPrivateLinkResourcePropertiesModel),
    };
}
