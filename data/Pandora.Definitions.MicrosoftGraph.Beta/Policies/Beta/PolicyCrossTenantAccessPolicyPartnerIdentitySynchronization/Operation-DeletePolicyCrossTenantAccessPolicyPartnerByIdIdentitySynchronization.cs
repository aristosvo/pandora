// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Policies.Beta.PolicyCrossTenantAccessPolicyPartnerIdentitySynchronization;

internal class DeletePolicyCrossTenantAccessPolicyPartnerByIdIdentitySynchronizationOperation : Operations.DeleteOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
            HttpStatusCode.NoContent,
        };
    public override ResourceID? ResourceId() => new PolicyCrossTenantAccessPolicyPartnerId();
    public override string? UriSuffix() => "/identitySynchronization";
}
