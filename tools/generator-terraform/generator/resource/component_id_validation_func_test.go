package resource

import (
	"strings"
	"testing"

	"github.com/hashicorp/pandora/tools/generator-terraform/generator/models"

	"github.com/hashicorp/pandora/tools/sdk/resourcemanager"
)

func TestComponentIDValidationFunc_CommonResourceID_Disabled(t *testing.T) {
	input := models.ResourceInput{
		ResourceTypeName: "Example",
		SdkResourceName:  "sdkresource",
		Details: resourcemanager.TerraformResourceDetails{
			GenerateIdValidation: false,
			ResourceIdName:       "CustomSubscriptionId",
		},
		ResourceIds: map[string]resourcemanager.ResourceIdDefinition{
			"CustomSubscriptionId": {
				CommonAlias: stringPointer("SubscriptionId"),
			},
		},
	}
	actual, err := idValidationFunctionForResource(input)
	if err != nil {
		t.Fatalf("error: %+v", err)
	}
	if actual != nil {
		t.Fatalf("expected `actual` to be nil but got %q", *actual)
	}
}

func TestComponentIDValidationFunc_CommonResourceID_Enabled(t *testing.T) {
	input := models.ResourceInput{
		ResourceTypeName: "Example",
		SdkResourceName:  "sdkresource",
		Details: resourcemanager.TerraformResourceDetails{
			GenerateIdValidation: true,
			ResourceIdName:       "CustomSubscriptionId",
		},
		ResourceIds: map[string]resourcemanager.ResourceIdDefinition{
			"CustomSubscriptionId": {
				CommonAlias: stringPointer("Subscription"),
			},
		},
	}
	actual, err := idValidationFunctionForResource(input)
	if err != nil {
		t.Fatalf("error: %+v", err)
	}
	expected := strings.TrimSpace(`
func (r ExampleResource) IDValidationFunc() pluginsdk.SchemaValidateFunc {
	return commonids.ValidateSubscriptionID
}
`)
	assertTemplatedCodeMatches(t, expected, *actual)
}

func TestComponentIDValidationFunc_RegularResourceID_Disabled(t *testing.T) {
	input := models.ResourceInput{
		ResourceTypeName: "Example",
		SdkResourceName:  "sdkresource",
		Details: resourcemanager.TerraformResourceDetails{
			GenerateIdValidation: false,
			ResourceIdName:       "CustomSubscriptionId",
		},
		ResourceIds: map[string]resourcemanager.ResourceIdDefinition{
			"CustomSubscriptionId": {
				Id: "/customSubscriptions/{subscriptionId}",
				Segments: []resourcemanager.ResourceIdSegment{
					{
						ExampleValue: "customSubscriptions",
						FixedValue:   stringPointer("customSubscriptions"),
						Name:         "staticCustomSubscriptions",
						Type:         resourcemanager.StaticSegment,
					},
					{
						ExampleValue: "000000-0000-0000-0000-00000000",
						Name:         "subscriptionId",
						Type:         resourcemanager.SubscriptionIdSegment,
					},
				},
			},
		},
	}
	actual, err := idValidationFunctionForResource(input)
	if err != nil {
		t.Fatalf("error: %+v", err)
	}
	if actual != nil {
		t.Fatalf("expected `actual` to be nil but it wasn't: %q", *actual)
	}
}

func TestComponentIDValidationFunc_RegularResourceID_Enabled(t *testing.T) {
	input := models.ResourceInput{
		ResourceTypeName: "Example",
		SdkResourceName:  "sdkresource",
		Details: resourcemanager.TerraformResourceDetails{
			GenerateIdValidation: true,
			ResourceIdName:       "CustomSubscriptionId",
		},
		ResourceIds: map[string]resourcemanager.ResourceIdDefinition{
			"CustomSubscriptionId": {
				Id: "/customSubscriptions/{subscriptionId}",
				Segments: []resourcemanager.ResourceIdSegment{
					{
						ExampleValue: "customSubscriptions",
						FixedValue:   stringPointer("customSubscriptions"),
						Name:         "staticCustomSubscriptions",
						Type:         resourcemanager.StaticSegment,
					},
					{
						ExampleValue: "000000-0000-0000-0000-00000000",
						Name:         "subscriptionId",
						Type:         resourcemanager.SubscriptionIdSegment,
					},
				},
			},
		},
	}
	actual, err := idValidationFunctionForResource(input)
	if err != nil {
		t.Fatalf("error: %+v", err)
	}
	expected := strings.TrimSpace(`
func (r ExampleResource) IDValidationFunc() pluginsdk.SchemaValidateFunc {
	return sdkresource.ValidateCustomSubscriptionID
}
`)
	assertTemplatedCodeMatches(t, expected, *actual)
}
