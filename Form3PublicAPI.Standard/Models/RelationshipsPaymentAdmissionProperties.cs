// <copyright file="RelationshipsPaymentAdmissionProperties.cs" company="APIMatic">
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
    /// RelationshipsPaymentAdmissionProperties.
    /// </summary>
    public class RelationshipsPaymentAdmissionProperties
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelationshipsPaymentAdmissionProperties"/> class.
        /// </summary>
        public RelationshipsPaymentAdmissionProperties()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelationshipsPaymentAdmissionProperties"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="type">type.</param>
        public RelationshipsPaymentAdmissionProperties(
            Guid id,
            string type)
        {
            this.Id = id;
            this.Type = type;
        }

        /// <summary>
        /// The payment admission associated with this query
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RelationshipsPaymentAdmissionProperties : ({string.Join(", ", toStringOutput)})";
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
            return obj is RelationshipsPaymentAdmissionProperties other &&                this.Id.Equals(other.Id) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
        }
    }
}