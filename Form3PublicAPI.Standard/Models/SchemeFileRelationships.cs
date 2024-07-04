// <copyright file="SchemeFileRelationships.cs" company="APIMatic">
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
    /// SchemeFileRelationships.
    /// </summary>
    public class SchemeFileRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemeFileRelationships"/> class.
        /// </summary>
        public SchemeFileRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemeFileRelationships"/> class.
        /// </summary>
        /// <param name="schemeFileAdmissions">scheme_file_admissions.</param>
        /// <param name="schemeFileSubmission">scheme_file_submission.</param>
        public SchemeFileRelationships(
            Models.SchemeFileAdmissions schemeFileAdmissions = null,
            Models.SchemeFileSubmission2 schemeFileSubmission = null)
        {
            this.SchemeFileAdmissions = schemeFileAdmissions;
            this.SchemeFileSubmission = schemeFileSubmission;
        }

        /// <summary>
        /// Gets or sets SchemeFileAdmissions.
        /// </summary>
        [JsonProperty("scheme_file_admissions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SchemeFileAdmissions SchemeFileAdmissions { get; set; }

        /// <summary>
        /// Gets or sets SchemeFileSubmission.
        /// </summary>
        [JsonProperty("scheme_file_submission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SchemeFileSubmission2 SchemeFileSubmission { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SchemeFileRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is SchemeFileRelationships other &&                ((this.SchemeFileAdmissions == null && other.SchemeFileAdmissions == null) || (this.SchemeFileAdmissions?.Equals(other.SchemeFileAdmissions) == true)) &&
                ((this.SchemeFileSubmission == null && other.SchemeFileSubmission == null) || (this.SchemeFileSubmission?.Equals(other.SchemeFileSubmission) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SchemeFileAdmissions = {(this.SchemeFileAdmissions == null ? "null" : this.SchemeFileAdmissions.ToString())}");
            toStringOutput.Add($"this.SchemeFileSubmission = {(this.SchemeFileSubmission == null ? "null" : this.SchemeFileSubmission.ToString())}");
        }
    }
}