using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.CostManagement.v2023_03_01;

public partial class Definition : ApiVersionDefinition
{
    public string ApiVersion => "2023-03-01";
    public bool Preview => false;
    public Source Source => Source.ResourceManagerRestApiSpecs;

    public IEnumerable<ResourceDefinition> Resources => new List<ResourceDefinition>
    {
        new Alerts.Definition(),
        new BenefitRecommendations.Definition(),
        new BenefitUtilizationSummaries.Definition(),
        new BenefitUtilizationSummariesAsync.Definition(),
        new CostDetails.Definition(),
        new Dimensions.Definition(),
        new Exports.Definition(),
        new Forecast.Definition(),
        new PriceSheets.Definition(),
        new Query.Definition(),
        new ReservedInstances.Definition(),
        new ScheduledActions.Definition(),
        new UsageDetails.Definition(),
        new Views.Definition(),
    };
}
