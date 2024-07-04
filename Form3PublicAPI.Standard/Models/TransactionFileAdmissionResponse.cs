// <copyright file="TransactionFileAdmissionResponse.cs" company="APIMatic">
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
    /// TransactionFileAdmissionResponse.
    /// </summary>
    public class TransactionFileAdmissionResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionFileAdmissionResponse"/> class.
        /// </summary>
        public TransactionFileAdmissionResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionFileAdmissionResponse"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="links">links.</param>
        public TransactionFileAdmissionResponse(
            Models.TransactionFileAdmission data = null,
            Models.TransactionFileLinks links = null)
        {
            this.Data = data;
            this.Links = links;
        }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TransactionFileAdmission Data { get; set; }

        /// <summary>
        /// Gets or sets Links.
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TransactionFileLinks Links { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TransactionFileAdmissionResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is TransactionFileAdmissionResponse other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
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