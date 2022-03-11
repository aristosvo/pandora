using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.Web.v2016_06_01.ConnectionGateways;

internal class ConnectionGatewayInstallationsListOperation : Operations.GetOperation
{
    public override ResourceID? ResourceId() => new LocationId();

    public override Type? ResponseObject() => typeof(ConnectionGatewayInstallationDefinitionCollectionModel);

    public override string? UriSuffix() => "/connectionGatewayInstallations";


}
