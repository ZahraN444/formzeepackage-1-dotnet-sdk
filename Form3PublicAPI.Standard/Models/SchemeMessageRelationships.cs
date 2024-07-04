// <copyright file="SchemeMessageRelationships.cs" company="APIMatic">
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
    /// SchemeMessageRelationships.
    /// </summary>
    public class SchemeMessageRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemeMessageRelationships"/> class.
        /// </summary>
        public SchemeMessageRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemeMessageRelationships"/> class.
        /// </summary>
        /// <param name="schemeMessageAdmission">scheme_message_admission.</param>
        public SchemeMessageRelationships(
            Models.SchemeMessageAdmission2 schemeMessageAdmission = null)
        {
            this.SchemeMessageAdmission = schemeMessageAdmission;
        }

        /// <summary>
        /// Gets or sets SchemeMessageAdmission.
        /// </summary>
        [JsonProperty("scheme_message_admission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SchemeMessageAdmission2 SchemeMessageAdmission { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SchemeMessageRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is SchemeMessageRelationships other &&                ((this.SchemeMessageAdmission == null && other.SchemeMessageAdmission == null) || (this.SchemeMessageAdmission?.Equals(other.SchemeMessageAdmission) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SchemeMessageAdmission = {(this.SchemeMessageAdmission == null ? "null" : this.SchemeMessageAdmission.ToString())}");
        }
    }
}