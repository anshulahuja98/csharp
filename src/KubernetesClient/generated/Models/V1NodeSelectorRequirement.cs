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
    /// A node selector requirement is a selector that contains values, a key, and an
        /// operator that relates the key and values.
    /// </summary>
    public partial class V1NodeSelectorRequirement
    {
        /// <summary>
        /// Initializes a new instance of the V1NodeSelectorRequirement class.
        /// </summary>
        public V1NodeSelectorRequirement()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1NodeSelectorRequirement class.
        /// </summary>
        /// <param name="key">
        /// The label key that the selector applies to.
        /// </param>
        /// <param name="operatorProperty">
        /// Represents a key&apos;s relationship to a set of values. Valid operators are In,
        /// NotIn, Exists, DoesNotExist. Gt, and Lt.
        /// </param>
        /// <param name="values">
        /// An array of string values. If the operator is In or NotIn, the values array must
        /// be non-empty. If the operator is Exists or DoesNotExist, the values array must
        /// be empty. If the operator is Gt or Lt, the values array must have a single
        /// element, which will be interpreted as an integer. This array is replaced during
        /// a strategic merge patch.
        /// </param>
        public V1NodeSelectorRequirement(string key, string operatorProperty, IList<string> values = null)
        {
            Key = key;
            OperatorProperty = operatorProperty;
            Values = values;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// The label key that the selector applies to.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// Represents a key&apos;s relationship to a set of values. Valid operators are In,
        /// NotIn, Exists, DoesNotExist. Gt, and Lt.
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        public string OperatorProperty { get; set; }

        /// <summary>
        /// An array of string values. If the operator is In or NotIn, the values array must
        /// be non-empty. If the operator is Exists or DoesNotExist, the values array must
        /// be empty. If the operator is Gt or Lt, the values array must have a single
        /// element, which will be interpreted as an integer. This array is replaced during
        /// a strategic merge patch.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<string> Values { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
