using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.TrafficManager.v2022_04_01;

public partial class Definition : ApiVersionDefinition
{
    public string ApiVersion => "2022-04-01";
    public bool Preview => false;
    public Source Source => Source.ResourceManagerRestApiSpecs;

    public IEnumerable<ResourceDefinition> Resources => new List<ResourceDefinition>
    {
        new Endpoints.Definition(),
        new GeographicHierarchies.Definition(),
        new HeatMaps.Definition(),
        new Profiles.Definition(),
        new RealUserMetrics.Definition(),
    };
}
