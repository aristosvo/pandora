using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2023_03_01_preview.ProductPolicy;

internal class Definition : ResourceDefinition
{
    public string Name => "ProductPolicy";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new GetEntityTagOperation(),
        new ListByProductOperation(),
        new WorkspaceProductPolicyCreateOrUpdateOperation(),
        new WorkspaceProductPolicyDeleteOperation(),
        new WorkspaceProductPolicyGetOperation(),
        new WorkspaceProductPolicyGetEntityTagOperation(),
        new WorkspaceProductPolicyListByProductOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(PolicyContentFormatConstant),
        typeof(PolicyExportFormatConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(PolicyCollectionModel),
        typeof(PolicyContractModel),
        typeof(PolicyContractPropertiesModel),
    };
}
