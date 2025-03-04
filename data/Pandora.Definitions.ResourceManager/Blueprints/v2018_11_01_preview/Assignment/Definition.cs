using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Blueprints.v2018_11_01_preview.Assignment;

internal class Definition : ResourceDefinition
{
    public string Name => "Assignment";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(AssignmentDeleteBehaviorConstant),
        typeof(AssignmentLockModeConstant),
        typeof(AssignmentProvisioningStateConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(AssignmentModel),
        typeof(AssignmentLockSettingsModel),
        typeof(AssignmentPropertiesModel),
        typeof(AssignmentStatusModel),
        typeof(KeyVaultReferenceModel),
        typeof(ParameterValueModel),
        typeof(ResourceGroupValueModel),
        typeof(SecretValueReferenceModel),
    };
}
