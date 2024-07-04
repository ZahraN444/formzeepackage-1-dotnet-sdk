// <copyright file="MandateRelationships.cs" company="APIMatic">
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
    /// MandateRelationships.
    /// </summary>
    public class MandateRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MandateRelationships"/> class.
        /// </summary>
        public MandateRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MandateRelationships"/> class.
        /// </summary>
        /// <param name="mandateAdmission">mandate_admission.</param>
        /// <param name="mandateReturn">mandate_return.</param>
        /// <param name="mandateSubmission">mandate_submission.</param>
        /// <param name="mostRecentCollection">most_recent_collection.</param>
        public MandateRelationships(
            Models.MandateAdmission2 mandateAdmission = null,
            Models.MandateReturn2 mandateReturn = null,
            Models.MandateSubmission2 mandateSubmission = null,
            Models.MostRecentCollection2 mostRecentCollection = null)
        {
            this.MandateAdmission = mandateAdmission;
            this.MandateReturn = mandateReturn;
            this.MandateSubmission = mandateSubmission;
            this.MostRecentCollection = mostRecentCollection;
        }

        /// <summary>
        /// Gets or sets MandateAdmission.
        /// </summary>
        [JsonProperty("mandate_admission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MandateAdmission2 MandateAdmission { get; set; }

        /// <summary>
        /// Gets or sets MandateReturn.
        /// </summary>
        [JsonProperty("mandate_return", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MandateReturn2 MandateReturn { get; set; }

        /// <summary>
        /// Gets or sets MandateSubmission.
        /// </summary>
        [JsonProperty("mandate_submission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MandateSubmission2 MandateSubmission { get; set; }

        /// <summary>
        /// Gets or sets MostRecentCollection.
        /// </summary>
        [JsonProperty("most_recent_collection", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MostRecentCollection2 MostRecentCollection { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MandateRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is MandateRelationships other &&                ((this.MandateAdmission == null && other.MandateAdmission == null) || (this.MandateAdmission?.Equals(other.MandateAdmission) == true)) &&
                ((this.MandateReturn == null && other.MandateReturn == null) || (this.MandateReturn?.Equals(other.MandateReturn) == true)) &&
                ((this.MandateSubmission == null && other.MandateSubmission == null) || (this.MandateSubmission?.Equals(other.MandateSubmission) == true)) &&
                ((this.MostRecentCollection == null && other.MostRecentCollection == null) || (this.MostRecentCollection?.Equals(other.MostRecentCollection) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MandateAdmission = {(this.MandateAdmission == null ? "null" : this.MandateAdmission.ToString())}");
            toStringOutput.Add($"this.MandateReturn = {(this.MandateReturn == null ? "null" : this.MandateReturn.ToString())}");
            toStringOutput.Add($"this.MandateSubmission = {(this.MandateSubmission == null ? "null" : this.MandateSubmission.ToString())}");
            toStringOutput.Add($"this.MostRecentCollection = {(this.MostRecentCollection == null ? "null" : this.MostRecentCollection.ToString())}");
        }
    }
}