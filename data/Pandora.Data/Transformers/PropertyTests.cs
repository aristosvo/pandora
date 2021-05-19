using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Versioning;
using System.Text.Json.Serialization;
using NUnit.Framework;
using Pandora.Data.Models;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Data.Transformers
{
    public static class PropertiesTests
    {
        [TestCase]
        public static void MapShouldFailWithoutJsonArgument()
        {
            foreach (var property in new WithoutArgumentExample().GetType().GetProperties())
            {
                Assert.Throws<NotSupportedException>(() => Property.Map(property));
            }
        }
        
        [TestCase]
        public static void MapMapsProperties()
        {
            foreach (var property in new Foo().GetType().GetProperties())
            {
                var actual = Property.Map(property);
                Assert.NotNull(actual);
                
                switch (property.Name)
                {
                    case "AbstractType":
                    {
                        Assert.AreEqual("AbstractType", actual.Name);
                        Assert.AreEqual("abstractType", actual.JsonName);
                        Assert.AreEqual(PropertyType.Object, actual.PropertyType);
                        Assert.IsTrue(actual.IsTypeHint);
                        Assert.AreEqual(true, actual.Optional);
                        Assert.AreEqual(false, actual.Required);
                        continue;
                    }
                    
                    case "BasicBoolField":
                    {
                        Assert.AreEqual("BasicBoolField", actual.Name);
                        Assert.AreEqual("basicBoolField", actual.JsonName);
                        Assert.AreEqual(PropertyType.Boolean, actual.PropertyType);
                        Assert.AreEqual(true, actual.Optional);
                        Assert.AreEqual(false, actual.Required);
                        continue;
                    }

                    case "BasicDateField":
                    {
                        Assert.AreEqual("BasicDateField", actual.Name);
                        Assert.AreEqual("basicDateField", actual.JsonName);
                        Assert.AreEqual(PropertyType.DateTime, actual.PropertyType);
                        Assert.AreEqual(true, actual.Optional);
                        Assert.AreEqual(false, actual.Required);
                        continue;
                    }

                    case "BasicIntField":
                    {
                        Assert.AreEqual("BasicIntField", actual.Name);
                        Assert.AreEqual("basicIntField", actual.JsonName);
                        Assert.AreEqual(PropertyType.Integer, actual.PropertyType);
                        Assert.AreEqual(true, actual.Optional);
                        Assert.AreEqual(false, actual.Required);
                        continue;
                    }

                    case "BasicLocationField":
                    {
                        Assert.AreEqual("BasicLocationField", actual.Name);
                        Assert.AreEqual("basicLocationField", actual.JsonName);
                        Assert.AreEqual(PropertyType.Location, actual.PropertyType);
                        Assert.AreEqual(true, actual.Optional);
                        Assert.AreEqual(false, actual.Required);
                        continue;
                    }

                    case "BasicObjectField":
                    {
                        Assert.AreEqual("BasicObjectField", actual.Name);
                        Assert.AreEqual("basicObjectField", actual.JsonName);
                        Assert.AreEqual(PropertyType.Object, actual.PropertyType);
                        Assert.IsNull(actual.ConstantReference);
                        Assert.IsNull(actual.ModelReference);
                        Assert.AreEqual(true, actual.Optional);
                        Assert.AreEqual(false, actual.Required);
                        continue;
                    }

                    case "BasicStringField":
                    {
                        Assert.AreEqual("BasicStringField", actual.Name);
                        Assert.AreEqual("basicStringField", actual.JsonName);
                        Assert.AreEqual(PropertyType.String, actual.PropertyType);
                        Assert.AreEqual(true, actual.Optional);
                        Assert.AreEqual(false, actual.Required);
                        continue;
                    }

                    case "BasicTagsField":
                    {
                        Assert.AreEqual("BasicTagsField", actual.Name);
                        Assert.AreEqual("basicTagsField", actual.JsonName);
                        Assert.AreEqual(PropertyType.Tags, actual.PropertyType);
                        Assert.AreEqual(true, actual.Optional);
                        Assert.AreEqual(false, actual.Required);
                        continue;
                    }

                    case "Constant":
                    {
                        Assert.AreEqual("Constant", actual.Name);
                        Assert.AreEqual("constant", actual.JsonName);
                        Assert.AreEqual(PropertyType.Constant, actual.PropertyType);
                        Assert.Null(actual.ListElementType);
                        Assert.AreEqual("SomeEnum", actual.ConstantReference);
                        Assert.Null(actual.ModelReference);
                        Assert.AreEqual(true, actual.Optional);
                        Assert.AreEqual(false, actual.Required);
                        continue;
                    }
                    
                    case "ListOfOtherEnum":
                    {
                        Assert.AreEqual("ListOfOtherEnum", actual.Name);
                        Assert.AreEqual("listOfOtherEnum", actual.JsonName);
                        Assert.AreEqual(PropertyType.List, actual.PropertyType);
                        Assert.AreEqual(PropertyType.Constant, actual.ListElementType);
                        Assert.AreEqual("SomeEnum", actual.ConstantReference);
                        Assert.Null(actual.ModelReference);
                        Assert.AreEqual(true, actual.Optional);
                        Assert.AreEqual(false, actual.Required);
                        continue;
                    }

                    case "ListOfOtherType":
                    {
                        Assert.AreEqual("ListOfOtherType", actual.Name);
                        Assert.AreEqual("listOfOtherType", actual.JsonName);
                        Assert.AreEqual(PropertyType.List, actual.PropertyType);
                        Assert.AreEqual(PropertyType.Object, actual.ListElementType);
                        Assert.AreEqual("SomeOtherType", actual.ModelReference);
                        Assert.Null(actual.ConstantReference);
                        Assert.AreEqual(true, actual.Optional);
                        Assert.AreEqual(false, actual.Required);
                        continue;
                    }

                    case "NestedObject":
                    {
                        Assert.AreEqual("NestedObject", actual.Name);
                        Assert.AreEqual("nestedObject", actual.JsonName);
                        Assert.AreEqual("NestedType", actual.ModelReference);
                        Assert.AreEqual(true, actual.Optional);
                        Assert.AreEqual(false, actual.Required);
                        continue;
                    }

                    case "WithDefaultValueInt":
                    {
                        Assert.AreEqual("WithDefaultValueInt", actual.Name);
                        Assert.AreEqual("withDefaultValueInt", actual.JsonName);
                        Assert.AreEqual(21, actual.Default);
                        Assert.AreEqual(true, actual.Optional);
                        Assert.AreEqual(false, actual.Required);
                        continue;
                    }

                    case "WithDefaultValueString":
                    {
                        Assert.AreEqual("WithDefaultValueString", actual.Name);
                        Assert.AreEqual("withDefaultValueString", actual.JsonName);
                        Assert.AreEqual("Hello", actual.Default);
                        Assert.AreEqual(true, actual.Optional);
                        Assert.AreEqual(false, actual.Required);
                        continue;
                    }

                    case "WithForceNew":
                    {
                        Assert.AreEqual("WithForceNew", actual.Name);
                        Assert.AreEqual("withForceNew", actual.JsonName);
                        Assert.AreEqual(true, actual.Optional);
                        Assert.AreEqual(true, actual.ForceNew);
                        Assert.AreEqual(false, actual.Required);
                        continue;
                    }

                    case "WithOptional":
                    {
                        Assert.AreEqual("WithOptional", actual.Name);
                        Assert.AreEqual("withOptional", actual.JsonName);
                        Assert.AreEqual(true, actual.Optional);
                        Assert.AreEqual(false, actual.Required);
                        continue;
                    }

                    case "WithRequired":
                    {
                        Assert.AreEqual("WithRequired", actual.Name);
                        Assert.AreEqual("withRequired", actual.JsonName);
                        Assert.AreEqual(false, actual.Optional);
                        Assert.AreEqual(true, actual.Required);
                        continue;
                    }

                    case "WithRangeValidation":
                    {
                        Assert.AreEqual("WithRangeValidation", actual.Name);
                        Assert.AreEqual("withRangeValidation", actual.JsonName);
                        Assert.AreEqual(true, actual.Optional);
                        Assert.AreEqual(false, actual.Required);
                        Assert.NotNull(actual.Validation);
                        Assert.AreEqual(ValidationType.Range, actual.Validation.ValidationType);
                        Assert.AreEqual(new List<object>{1, 20}, actual.Validation.Values);
                        continue;
                    }

                    default:
                        throw new NotSupportedException($"unhandled property {property.Name}");
                }
            }
        }

        private class Foo
        {
            [JsonPropertyName("abstractType")]
            [Optional]
            public SomeParentType AbstractType { get; set; }
            
            [JsonPropertyName("basicBoolField")]
            public bool BasicBoolField { get; set; }
            
            [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
            [JsonPropertyName("basicDateField")]
            public DateTime BasicDateField { get; set; }
            
            [JsonPropertyName("basicLocationField")]
            public Location BasicLocationField { get; set; }
            
            [JsonPropertyName("basicIntField")]
            public int BasicIntField { get; set; }
            
            [JsonPropertyName("basicObjectField")]
            public object BasicObjectField { get; set; }

            [JsonPropertyName("basicStringField")]
            public string BasicStringField { get; set; }
            
            [JsonPropertyName("basicTagsField")]
            public Tags BasicTagsField { get; set; }
            
            [JsonPropertyName("constant")]
            [Optional]
            public SomeEnum Constant { get; set; }
            
            [JsonPropertyName("listOfOtherEnum")]
            [Optional]
            public List<SomeEnum> ListOfOtherEnum { get; set; }
            
            [JsonPropertyName("listOfOtherType")]
            [Optional]
            public List<SomeOtherType> ListOfOtherType { get; set; }
            
            [JsonPropertyName("nestedObject")]
            [Optional]
            public NestedType NestedObject { get; set; }
            
            [JsonPropertyName("withDefaultValueInt")]
            [Optional(DefaultValue = 21)]
            public string WithDefaultValueInt { get; set; }
            
            [JsonPropertyName("withDefaultValueString")]
            [Optional(DefaultValue = "Hello")]
            public string WithDefaultValueString { get; set; }
            
            [JsonPropertyName("withForceNew")]
            [Optional]
            [ForceNew]
            public string WithForceNew { get; set; }
            
            [JsonPropertyName("withOptional")]
            [Optional]
            public string WithOptional { get; set; }
            
            [JsonPropertyName("withRequired")]
            [Required]
            public string WithRequired { get; set; }
            
            [FieldValidation(Type = FieldValidationType.Range, StartRange = 1, EndRange = 20)]
            [JsonPropertyName("withRangeValidation")]
            [Optional]
            public int WithRangeValidation { get; set; }
        }

        public enum SomeEnum
        {
            First,
            Second
        }

        public class SomeOtherType
        {
        }

        public class NestedType
        {
            [JsonPropertyName("nestedField")]
            public bool NestedField { get; set; }
        }
        
        private class WithoutArgumentExample
        {
            public bool HasNoArgument { get; set; }
        }
        
        private abstract class SomeParentType
        {
            [JsonPropertyName("objectType")]
            [ProvidesTypeHint]
            public string ObjectType { get; set; }
        }
    }
}