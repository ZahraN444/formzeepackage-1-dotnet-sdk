// <copyright file="Relationships17.cs" company="APIMatic">
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
    /// Relationships17.
    /// </summary>
    public class Relationships17
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships17"/> class.
        /// </summary>
        public Relationships17()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships17"/> class.
        /// </summary>
        /// <param name="mandate">mandate.</param>
        /// <param name="mandateReturnSubmission">mandate_return_submission.</param>
        public Relationships17(
            Models.Mandate2 mandate = null,
            Models.MandateReturnSubmission2 mandateReturnSubmission = null)
        {
            this.Mandate = mandate;
            this.MandateReturnSubmission = mandateReturnSubmission;
        }

        /// <summary>
        /// Gets or sets Mandate.
        /// </summary>
        [JsonProperty("mandate", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Mandate2 Mandate { get; set; }

        /// <summary>
        /// Gets or sets MandateReturnSubmission.
        /// </summary>
        [JsonProperty("mandate_return_submission", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MandateReturnSubmission2 MandateReturnSubmission { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships17 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships17 other &&                ((this.Mandate == null && other.Mandate == null) || (this.Mandate?.Equals(other.Mandate) == true)) &&
                ((this.MandateReturnSubmission == null && other.MandateReturnSubmission == null) || (this.MandateReturnSubmission?.Equals(other.MandateReturnSubmission) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Mandate = {(this.Mandate == null ? "null" : this.Mandate.ToString())}");
            toStringOutput.Add($"this.MandateReturnSubmission = {(this.MandateReturnSubmission == null ? "null" : this.MandateReturnSubmission.ToString())}");
        }
    }
}