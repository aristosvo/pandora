package changes

var _ Change = ResourceIdCommonIdRemoved{}

// ResourceIdCommonIdRemoved defines that a Resource ID which existed previously is no
// longer a Common ID.
type ResourceIdCommonIdRemoved struct {
	// ServiceName specifies the name of the Service which contained this
	// Resource ID.
	ServiceName string

	// ApiVersion specifies the name of the API Version which contained this
	// Resource ID.
	ApiVersion string

	// ResourceName specifies the name of the API Resource which contained this
	// Resource ID.
	ResourceName string

	// ResourceIdName specifies the name of the Resource ID which is no longer a Common ID.
	ResourceIdName string

	// CommonAliasName specifies the name of the Common Alias for this Resource ID.
	CommonAliasName string

	// ResourceIdValue specifies the value used for this Resource ID e.g. `/foo/{bar}`
	ResourceIdValue string
}

// IsBreaking returns whether this Change is considered a Breaking Change.
func (ResourceIdCommonIdRemoved) IsBreaking() bool {
	// If a Resource ID is no longer a Common ID this is going to require code changes
	return true
}
