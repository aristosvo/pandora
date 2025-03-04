// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Applications.StableV1;

public partial class Definition : ApiVersionDefinition
{
    public string ApiVersion => "StableV1";
    public bool Preview => false;
    public Source Source => Source.MicrosoftGraphMetadata;

    public IEnumerable<ResourceDefinition> Resources => new List<ResourceDefinition>
    {
        new Application.Definition(),
        new ApplicationAppManagementPolicy.Definition(),
        new ApplicationCreatedOnBehalfOf.Definition(),
        new ApplicationExtensionProperty.Definition(),
        new ApplicationFederatedIdentityCredential.Definition(),
        new ApplicationHomeRealmDiscoveryPolicy.Definition(),
        new ApplicationLogo.Definition(),
        new ApplicationOwner.Definition(),
        new ApplicationSynchronization.Definition(),
        new ApplicationSynchronizationJob.Definition(),
        new ApplicationSynchronizationJobSchema.Definition(),
        new ApplicationSynchronizationJobSchemaDirectory.Definition(),
        new ApplicationSynchronizationSecret.Definition(),
        new ApplicationSynchronizationTemplate.Definition(),
        new ApplicationSynchronizationTemplateSchema.Definition(),
        new ApplicationSynchronizationTemplateSchemaDirectory.Definition(),
        new ApplicationTokenIssuancePolicy.Definition(),
        new ApplicationTokenLifetimePolicy.Definition()
    };
}
