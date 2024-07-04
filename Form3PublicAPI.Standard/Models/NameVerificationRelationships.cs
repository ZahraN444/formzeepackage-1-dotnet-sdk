// <copyright file="NameVerificationRelationships.cs" company="APIMatic">
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
    /// NameVerificationRelationships.
    /// </summary>
    public class NameVerificationRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NameVerificationRelationships"/> class.
        /// </summary>
        public NameVerificationRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NameVerificationRelationships"/> class.
        /// </summary>
        /// <param name="nameVerificationAdmission">name_verification_admission.</param>
        /// <param name="nameVerificationSubmission">name_verification_submission.</param>
        public NameVerificationRelationships(
            Models.NameVerificationAdmission2 nameVerificationAdmission = null,
            Models.NameVerificationSubmission2 nameVerificationSubmission = null)
        {
            this.NameVerificationAdmission = nameVerificationAdmission;
            this.NameVerificationSubmission = nameVerificationSubmission;
        }

        /// <summary>
        /// Gets or sets NameVerificationAdmission.
        /// </summary>
        [JsonProperty("name_verification_admission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NameVerificationAdmission2 NameVerificationAdmission { get; set; }

        /// <summary>
        /// Gets or sets NameVerificationSubmission.
        /// </summary>
        [JsonProperty("name_verification_submission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NameVerificationSubmission2 NameVerificationSubmission { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NameVerificationRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is NameVerificationRelationships other &&                ((this.NameVerificationAdmission == null && other.NameVerificationAdmission == null) || (this.NameVerificationAdmission?.Equals(other.NameVerificationAdmission) == true)) &&
                ((this.NameVerificationSubmission == null && other.NameVerificationSubmission == null) || (this.NameVerificationSubmission?.Equals(other.NameVerificationSubmission) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.NameVerificationAdmission = {(this.NameVerificationAdmission == null ? "null" : this.NameVerificationAdmission.ToString())}");
            toStringOutput.Add($"this.NameVerificationSubmission = {(this.NameVerificationSubmission == null ? "null" : this.NameVerificationSubmission.ToString())}");
        }
    }
}