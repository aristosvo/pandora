// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Me.Beta.MeMailFolderChildFolderMessageExtension;

internal class Definition : ResourceDefinition
{
    public string Name => "MeMailFolderChildFolderMessageExtension";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateMeMailFolderByIdChildFolderByIdMessageByIdExtensionOperation(),
        new DeleteMeMailFolderByIdChildFolderByIdMessageByIdExtensionByIdOperation(),
        new GetMeMailFolderByIdChildFolderByIdMessageByIdExtensionByIdOperation(),
        new GetMeMailFolderByIdChildFolderByIdMessageByIdExtensionCountOperation(),
        new ListMeMailFolderByIdChildFolderByIdMessageByIdExtensionsOperation(),
        new UpdateMeMailFolderByIdChildFolderByIdMessageByIdExtensionByIdOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {

    };
}
