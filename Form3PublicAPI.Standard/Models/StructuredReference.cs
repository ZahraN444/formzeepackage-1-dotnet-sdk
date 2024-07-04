// <copyright file="StructuredReference.cs" company="APIMatic">
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
    /// StructuredReference.
    /// </summary>
    public class StructuredReference
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredReference"/> class.
        /// </summary>
        public StructuredReference()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredReference"/> class.
        /// </summary>
        /// <param name="issuer">issuer.</param>
        /// <param name="reference">reference.</param>
        public StructuredReference(
            string issuer = null,
            string reference = null)
        {
            this.Issuer = issuer;
            this.Reference = reference;
        }

        /// <summary>
        /// Issuer of remittance reference
        /// </summary>
        [JsonProperty("issuer", NullValueHandling = NullValueHandling.Ignore)]
        public string Issuer { get; set; }

        /// <summary>
        /// Unique reference to unambiguously refer to the payment originated by the creditor, this reference enables reconciliation by the creditor upon receipt of the amount of money.
        /// </summary>
        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public string Reference { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StructuredReference : ({string.Join(", ", toStringOutput)})";
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
            return obj is StructuredReference other &&                ((this.Issuer == null && other.Issuer == null) || (this.Issuer?.Equals(other.Issuer) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Issuer = {(this.Issuer == null ? "null" : this.Issuer)}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
        }
    }
}