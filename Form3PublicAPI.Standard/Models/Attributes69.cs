// <copyright file="Attributes69.cs" company="APIMatic">
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
    /// Attributes69.
    /// </summary>
    public class Attributes69
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes69"/> class.
        /// </summary>
        public Attributes69()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes69"/> class.
        /// </summary>
        /// <param name="errorCategory">error_category.</param>
        /// <param name="errorMessage">error_message.</param>
        /// <param name="occurredOn">occurred_on.</param>
        public Attributes69(
            string errorCategory = null,
            string errorMessage = null,
            DateTime? occurredOn = null)
        {
            this.ErrorCategory = errorCategory;
            this.ErrorMessage = errorMessage;
            this.OccurredOn = occurredOn;
        }

        /// <summary>
        /// Gets or sets ErrorCategory.
        /// </summary>
        [JsonProperty("error_category", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCategory { get; set; }

        /// <summary>
        /// Gets or sets ErrorMessage.
        /// </summary>
        [JsonProperty("error_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets OccurredOn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("occurred_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? OccurredOn { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes69 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes69 other &&                ((this.ErrorCategory == null && other.ErrorCategory == null) || (this.ErrorCategory?.Equals(other.ErrorCategory) == true)) &&
                ((this.ErrorMessage == null && other.ErrorMessage == null) || (this.ErrorMessage?.Equals(other.ErrorMessage) == true)) &&
                ((this.OccurredOn == null && other.OccurredOn == null) || (this.OccurredOn?.Equals(other.OccurredOn) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ErrorCategory = {(this.ErrorCategory == null ? "null" : this.ErrorCategory)}");
            toStringOutput.Add($"this.ErrorMessage = {(this.ErrorMessage == null ? "null" : this.ErrorMessage)}");
            toStringOutput.Add($"this.OccurredOn = {(this.OccurredOn == null ? "null" : this.OccurredOn.ToString())}");
        }
    }
}