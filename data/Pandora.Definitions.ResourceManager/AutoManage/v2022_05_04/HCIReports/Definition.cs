using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.AutoManage.v2022_05_04.HCIReports;

internal class Definition : ResourceDefinition
{
    public string Name => "HCIReports";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new GetOperation(),
        new ListByConfigurationProfileAssignmentsOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(AssignmentReportPropertiesModel),
        typeof(ErrorAdditionalInfoModel),
        typeof(ErrorDetailModel),
        typeof(ReportModel),
        typeof(ReportListModel),
        typeof(ReportResourceModel),
    };
}
