// <copyright file="Self.cs" company="APIMatic">
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
    /// Self.
    /// </summary>
    public class Self
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Self"/> class.
        /// </summary>
        public Self()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Self"/> class.
        /// </summary>
        /// <param name="selfProp">self.</param>
        public Self(
            string selfProp = null)
        {
            this.SelfProp = selfProp;
        }

        /// <summary>
        /// Gets or sets SelfProp.
        /// </summary>
        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public string SelfProp { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Self : ({string.Join(", ", toStringOutput)})";
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
            return obj is Self other &&                ((this.SelfProp == null && other.SelfProp == null) || (this.SelfProp?.Equals(other.SelfProp) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SelfProp = {(this.SelfProp == null ? "null" : this.SelfProp)}");
        }
    }
}