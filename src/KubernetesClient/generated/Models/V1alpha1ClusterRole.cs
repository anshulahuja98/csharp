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
    /// ClusterRole is a cluster level, logical grouping of PolicyRules that can be
        /// referenced as a unit by a RoleBinding or ClusterRoleBinding. Deprecated in v1.17
        /// in favor of rbac.authorization.k8s.io/v1 ClusterRole, and will no longer be
        /// served in v1.22.
    /// </summary>
    public partial class V1alpha1ClusterRole
    {
        /// <summary>
        /// Initializes a new instance of the V1alpha1ClusterRole class.
        /// </summary>
        public V1alpha1ClusterRole()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1alpha1ClusterRole class.
        /// </summary>
        /// <param name="aggregationRule">
        /// AggregationRule is an optional field that describes how to build the Rules for
        /// this ClusterRole. If AggregationRule is set, then the Rules are controller
        /// managed and direct changes to Rules will be stomped by the controller.
        /// </param>
        /// <param name="apiVersion">
        /// APIVersion defines the versioned schema of this representation of an object.
        /// Servers should convert recognized schemas to the latest internal value, and may
        /// reject unrecognized values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </param>
        /// <param name="kind">
        /// Kind is a string value representing the REST resource this object represents.
        /// Servers may infer this from the endpoint the client submits requests to. Cannot
        /// be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </param>
        /// <param name="metadata">
        /// Standard object&apos;s metadata.
        /// </param>
        /// <param name="rules">
        /// Rules holds all the PolicyRules for this ClusterRole
        /// </param>
        public V1alpha1ClusterRole(V1alpha1AggregationRule aggregationRule = null, string apiVersion = null, string kind = null, V1ObjectMeta metadata = null, IList<V1alpha1PolicyRule> rules = null)
        {
            AggregationRule = aggregationRule;
            ApiVersion = apiVersion;
            Kind = kind;
            Metadata = metadata;
            Rules = rules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// AggregationRule is an optional field that describes how to build the Rules for
        /// this ClusterRole. If AggregationRule is set, then the Rules are controller
        /// managed and direct changes to Rules will be stomped by the controller.
        /// </summary>
        [JsonProperty(PropertyName = "aggregationRule")]
        public V1alpha1AggregationRule AggregationRule { get; set; }

        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object.
        /// Servers should convert recognized schemas to the latest internal value, and may
        /// reject unrecognized values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object represents.
        /// Servers may infer this from the endpoint the client submits requests to. Cannot
        /// be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Standard object&apos;s metadata.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public V1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Rules holds all the PolicyRules for this ClusterRole
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<V1alpha1PolicyRule> Rules { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            AggregationRule?.Validate();
            Metadata?.Validate();
            foreach(var obj in Rules)
            {
                obj.Validate();
            }
        }
    }
}
