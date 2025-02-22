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
    /// Adapts a secret into a projected volume.
        /// 
        /// The contents of the target Secret&apos;s Data field will be presented in a projected
        /// volume as files using the keys in the Data field as the file names. Note that
        /// this is identical to a secret volume source without the default mode.
    /// </summary>
    public partial class V1SecretProjection
    {
        /// <summary>
        /// Initializes a new instance of the V1SecretProjection class.
        /// </summary>
        public V1SecretProjection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1SecretProjection class.
        /// </summary>
        /// <param name="items">
        /// If unspecified, each key-value pair in the Data field of the referenced Secret
        /// will be projected into the volume as a file whose name is the key and content is
        /// the value. If specified, the listed keys will be projected into the specified
        /// paths, and unlisted keys will not be present. If a key is specified which is not
        /// present in the Secret, the volume setup will error unless it is marked optional.
        /// Paths must be relative and may not contain the &apos;..&apos; path or start with &apos;..&apos;.
        /// </param>
        /// <param name="name">
        /// Name of the referent. More info:
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </param>
        /// <param name="optional">
        /// Specify whether the Secret or its key must be defined
        /// </param>
        public V1SecretProjection(IList<V1KeyToPath> items = null, string name = null, bool? optional = null)
        {
            Items = items;
            Name = name;
            Optional = optional;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// If unspecified, each key-value pair in the Data field of the referenced Secret
        /// will be projected into the volume as a file whose name is the key and content is
        /// the value. If specified, the listed keys will be projected into the specified
        /// paths, and unlisted keys will not be present. If a key is specified which is not
        /// present in the Secret, the volume setup will error unless it is marked optional.
        /// Paths must be relative and may not contain the &apos;..&apos; path or start with &apos;..&apos;.
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public IList<V1KeyToPath> Items { get; set; }

        /// <summary>
        /// Name of the referent. More info:
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Specify whether the Secret or its key must be defined
        /// </summary>
        [JsonProperty(PropertyName = "optional")]
        public bool? Optional { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            foreach(var obj in Items)
            {
                obj.Validate();
            }
        }
    }
}
