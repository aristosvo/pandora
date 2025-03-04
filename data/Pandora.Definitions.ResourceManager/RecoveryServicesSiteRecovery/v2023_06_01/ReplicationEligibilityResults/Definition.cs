using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RecoveryServicesSiteRecovery.v2023_06_01.ReplicationEligibilityResults;

internal class Definition : ResourceDefinition
{
    public string Name => "ReplicationEligibilityResults";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new GetOperation(),
        new ListOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(ReplicationEligibilityResultsModel),
        typeof(ReplicationEligibilityResultsCollectionModel),
        typeof(ReplicationEligibilityResultsErrorInfoModel),
        typeof(ReplicationEligibilityResultsPropertiesModel),
    };
}
