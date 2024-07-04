// <copyright file="MandateSubmissionRelationships.cs" company="APIMatic">
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
    /// MandateSubmissionRelationships.
    /// </summary>
    public class MandateSubmissionRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MandateSubmissionRelationships"/> class.
        /// </summary>
        public MandateSubmissionRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MandateSubmissionRelationships"/> class.
        /// </summary>
        /// <param name="mandate">mandate.</param>
        public MandateSubmissionRelationships(
            Models.Mandate2 mandate = null)
        {
            this.Mandate = mandate;
        }

        /// <summary>
        /// Gets or sets Mandate.
        /// </summary>
        [JsonProperty("mandate", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Mandate2 Mandate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MandateSubmissionRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is MandateSubmissionRelationships other &&                ((this.Mandate == null && other.Mandate == null) || (this.Mandate?.Equals(other.Mandate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Mandate = {(this.Mandate == null ? "null" : this.Mandate.ToString())}");
        }
    }
}