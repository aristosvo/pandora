using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Automation.v2022_08_08.AutomationAccount;

internal class Definition : ResourceDefinition
{
    public string Name => "AutomationAccount";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
        new ListByResourceGroupOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(AutomationAccountStateConstant),
        typeof(EncryptionKeySourceTypeConstant),
        typeof(SkuNameEnumConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(AutomationAccountModel),
        typeof(AutomationAccountCreateOrUpdateParametersModel),
        typeof(AutomationAccountCreateOrUpdatePropertiesModel),
        typeof(AutomationAccountPropertiesModel),
        typeof(AutomationAccountUpdateParametersModel),
        typeof(AutomationAccountUpdatePropertiesModel),
        typeof(EncryptionPropertiesModel),
        typeof(EncryptionPropertiesIdentityModel),
        typeof(KeyVaultPropertiesModel),
        typeof(PrivateEndpointConnectionModel),
        typeof(PrivateEndpointConnectionPropertiesModel),
        typeof(PrivateEndpointPropertyModel),
        typeof(PrivateLinkServiceConnectionStatePropertyModel),
        typeof(SkuModel),
    };
}
