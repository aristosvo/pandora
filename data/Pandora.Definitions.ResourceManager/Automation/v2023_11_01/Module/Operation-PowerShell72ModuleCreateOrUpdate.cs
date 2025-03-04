using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Automation.v2023_11_01.Module;

internal class PowerShell72ModuleCreateOrUpdateOperation : Pandora.Definitions.Operations.PutOperation
{
    public override Type? RequestObject() => typeof(ModuleCreateOrUpdateParametersModel);

    public override ResourceID? ResourceId() => new PowerShell72ModuleId();

    public override Type? ResponseObject() => typeof(ModuleModel);


}
