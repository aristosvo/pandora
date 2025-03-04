using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Nginx.v2023_04_01.NginxCertificate;

internal class Definition : ResourceDefinition
{
    public string Name => "NginxCertificate";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CertificatesCreateOrUpdateOperation(),
        new CertificatesDeleteOperation(),
        new CertificatesGetOperation(),
        new CertificatesListOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ProvisioningStateConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(NginxCertificateModel),
        typeof(NginxCertificatePropertiesModel),
    };
}
