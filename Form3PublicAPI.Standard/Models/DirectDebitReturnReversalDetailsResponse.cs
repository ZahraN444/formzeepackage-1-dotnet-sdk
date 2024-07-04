// <copyright file="DirectDebitReturnReversalDetailsResponse.cs" company="APIMatic">
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
    /// DirectDebitReturnReversalDetailsResponse.
    /// </summary>
    public class DirectDebitReturnReversalDetailsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitReturnReversalDetailsResponse"/> class.
        /// </summary>
        public DirectDebitReturnReversalDetailsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitReturnReversalDetailsResponse"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="links">links.</param>
        public DirectDebitReturnReversalDetailsResponse(
            Models.DirectDebitReturnReversal data = null,
            Models.Links links = null)
        {
            this.Data = data;
            this.Links = links;
        }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitReturnReversal Data { get; set; }

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

            return $"DirectDebitReturnReversalDetailsResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is DirectDebitReturnReversalDetailsResponse other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                ((this.Links == null && other.Links == null) || (this.Links?.Equals(other.Links) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data.ToString())}");
            toStringOutput.Add($"this.Links = {(this.Links == null ? "null" : this.Links.ToString())}");
        }
    }
}