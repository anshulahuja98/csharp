// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Collections;
    using System.Linq;

    /// <summary>
    /// CustomResourceValidation is a list of validation methods for CustomResources.
    /// </summary>
    public partial class V1CustomResourceValidation
    {
        /// <summary>
        /// Initializes a new instance of the V1CustomResourceValidation class.
        /// </summary>
        public V1CustomResourceValidation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1CustomResourceValidation class.
        /// </summary>
        /// <param name="openAPIV3Schema">
        /// openAPIV3Schema is the OpenAPI v3 schema to use for validation and pruning.
        /// </param>
        public V1CustomResourceValidation(V1JSONSchemaProps openAPIV3Schema = null)
        {
            OpenAPIV3Schema = openAPIV3Schema;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// openAPIV3Schema is the OpenAPI v3 schema to use for validation and pruning.
        /// </summary>
        [JsonProperty(PropertyName = "openAPIV3Schema")]
        public V1JSONSchemaProps OpenAPIV3Schema { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            OpenAPIV3Schema?.Validate();
        }
    }
}
