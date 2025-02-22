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
    /// Represents a projected volume source
    /// </summary>
    public partial class V1ProjectedVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the V1ProjectedVolumeSource class.
        /// </summary>
        public V1ProjectedVolumeSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1ProjectedVolumeSource class.
        /// </summary>
        /// <param name="defaultMode">
        /// Mode bits used to set permissions on created files by default. Must be an octal
        /// value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts
        /// both octal and decimal values, JSON requires decimal values for mode bits.
        /// Directories within the path are not affected by this setting. This might be in
        /// conflict with other options that affect the file mode, like fsGroup, and the
        /// result can be other mode bits set.
        /// </param>
        /// <param name="sources">
        /// list of volume projections
        /// </param>
        public V1ProjectedVolumeSource(int? defaultMode = null, IList<V1VolumeProjection> sources = null)
        {
            DefaultMode = defaultMode;
            Sources = sources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Mode bits used to set permissions on created files by default. Must be an octal
        /// value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts
        /// both octal and decimal values, JSON requires decimal values for mode bits.
        /// Directories within the path are not affected by this setting. This might be in
        /// conflict with other options that affect the file mode, like fsGroup, and the
        /// result can be other mode bits set.
        /// </summary>
        [JsonProperty(PropertyName = "defaultMode")]
        public int? DefaultMode { get; set; }

        /// <summary>
        /// list of volume projections
        /// </summary>
        [JsonProperty(PropertyName = "sources")]
        public IList<V1VolumeProjection> Sources { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            foreach(var obj in Sources)
            {
                obj.Validate();
            }
        }
    }
}
