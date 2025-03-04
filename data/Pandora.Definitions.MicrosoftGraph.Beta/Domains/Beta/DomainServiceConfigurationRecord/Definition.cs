// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Domains.Beta.DomainServiceConfigurationRecord;

internal class Definition : ResourceDefinition
{
    public string Name => "DomainServiceConfigurationRecord";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateDomainByIdServiceConfigurationRecordOperation(),
        new DeleteDomainByIdServiceConfigurationRecordByIdOperation(),
        new GetDomainByIdServiceConfigurationRecordByIdOperation(),
        new GetDomainByIdServiceConfigurationRecordCountOperation(),
        new ListDomainByIdServiceConfigurationRecordsOperation(),
        new UpdateDomainByIdServiceConfigurationRecordByIdOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {

    };
}
