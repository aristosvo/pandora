// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Me.Beta.MeAuthenticationMethod;

internal class Definition : ResourceDefinition
{
    public string Name => "MeAuthenticationMethod";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateMeAuthenticationMethodByIdDisableSmsSignInOperation(),
        new CreateMeAuthenticationMethodByIdEnableSmsSignInOperation(),
        new CreateMeAuthenticationMethodByIdResetPasswordOperation(),
        new CreateMeAuthenticationMethodOperation(),
        new GetMeAuthenticationMethodByIdOperation(),
        new GetMeAuthenticationMethodCountOperation(),
        new ListMeAuthenticationMethodsOperation(),
        new UpdateMeAuthenticationMethodByIdOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(CreateMeAuthenticationMethodByIdResetPasswordRequestModel)
    };
}
