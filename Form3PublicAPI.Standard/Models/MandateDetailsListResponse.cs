// <copyright file="MandateDetailsListResponse.cs" company="APIMatic">
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
    /// MandateDetailsListResponse.
    /// </summary>
    public class MandateDetailsListResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MandateDetailsListResponse"/> class.
        /// </summary>
        public MandateDetailsListResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MandateDetailsListResponse"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="links">links.</param>
        public MandateDetailsListResponse(
            List<Models.Mandate> data = null,
            Models.Links links = null)
        {
            this.Data = data;
            this.Links = links;
        }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Mandate> Data { get; set; }

        /// <summary>
        /// Gets or sets Links.
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Links Links { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MandateDetailsListResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is MandateDetailsListResponse other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                ((this.Links == null && other.Links == null) || (this.Links?.Equals(other.Links) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : $"[{string.Join(", ", this.Data)} ]")}");
            toStringOutput.Add($"this.Links = {(this.Links == null ? "null" : this.Links.ToString())}");
        }
    }
}