using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DataDog.v2022_06_01.Agreements;

internal class Definition : ResourceDefinition
{
    public string Name => "Agreements";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new MarketplaceAgreementsCreateOrUpdateOperation(),
        new MarketplaceAgreementsListOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(DatadogAgreementPropertiesModel),
        typeof(DatadogAgreementResourceModel),
    };
}
