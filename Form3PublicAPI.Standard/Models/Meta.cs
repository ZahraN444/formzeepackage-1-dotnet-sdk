// <copyright file="Meta.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Form3PublicAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using Form3PublicAPI.Standard;
    using Form3PublicAPI.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Meta.
    /// </summary>
    public class Meta
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Meta"/> class.
        /// </summary>
        public Meta()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Meta"/> class.
        /// </summary>
        /// <param name="contentType">content-type.</param>
        public Meta(
            string contentType = null)
        {
            this.ContentType = contentType;
        }

        /// <summary>
        /// Gets or sets ContentType.
        /// </summary>
        [JsonProperty("content-type", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Meta : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is Meta other &&                ((this.ContentType == null && other.ContentType == null) || (this.ContentType?.Equals(other.ContentType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ContentType = {(this.ContentType == null ? "null" : this.ContentType)}");
        }
    }
}