// <copyright file="NameVerificationAdmissionRelationships.cs" company="APIMatic">
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
    /// NameVerificationAdmissionRelationships.
    /// </summary>
    public class NameVerificationAdmissionRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NameVerificationAdmissionRelationships"/> class.
        /// </summary>
        public NameVerificationAdmissionRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NameVerificationAdmissionRelationships"/> class.
        /// </summary>
        /// <param name="nameVerification">name_verification.</param>
        public NameVerificationAdmissionRelationships(
            Models.NameVerification1 nameVerification = null)
        {
            this.NameVerification = nameVerification;
        }

        /// <summary>
        /// Gets or sets NameVerification.
        /// </summary>
        [JsonProperty("name_verification", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NameVerification1 NameVerification { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NameVerificationAdmissionRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is NameVerificationAdmissionRelationships other &&                ((this.NameVerification == null && other.NameVerification == null) || (this.NameVerification?.Equals(other.NameVerification) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.NameVerification = {(this.NameVerification == null ? "null" : this.NameVerification.ToString())}");
        }
    }
}