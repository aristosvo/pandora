using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Compute.v2022_03_03.GalleryImages;

internal class Definition : ResourceDefinition
{
    public string Name => "GalleryImages";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListByGalleryOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ArchitectureConstant),
        typeof(GalleryProvisioningStateConstant),
        typeof(HyperVGenerationConstant),
        typeof(OperatingSystemStateTypesConstant),
        typeof(OperatingSystemTypesConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(DisallowedModel),
        typeof(GalleryImageModel),
        typeof(GalleryImageFeatureModel),
        typeof(GalleryImageIdentifierModel),
        typeof(GalleryImagePropertiesModel),
        typeof(GalleryImageUpdateModel),
        typeof(ImagePurchasePlanModel),
        typeof(RecommendedMachineConfigurationModel),
        typeof(ResourceRangeModel),
    };
}
