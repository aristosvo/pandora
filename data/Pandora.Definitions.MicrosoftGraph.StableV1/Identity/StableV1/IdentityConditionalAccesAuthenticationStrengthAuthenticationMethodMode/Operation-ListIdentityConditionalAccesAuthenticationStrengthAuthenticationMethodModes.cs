// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Identity.StableV1.IdentityConditionalAccesAuthenticationStrengthAuthenticationMethodMode;

internal class ListIdentityConditionalAccesAuthenticationStrengthAuthenticationMethodModesOperation : Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";
    public override ResourceID? ResourceId() => null;
    public override Type NestedItemType() => typeof(AuthenticationMethodModeDetailCollectionResponseModel);
    public override string? UriSuffix() => "/identity/conditionalAccess/authenticationStrength/authenticationMethodModes";
}
