// <copyright file="Attributes64.cs" company="APIMatic">
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
    /// Attributes64.
    /// </summary>
    public class Attributes64
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes64"/> class.
        /// </summary>
        public Attributes64()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes64"/> class.
        /// </summary>
        /// <param name="output">output.</param>
        /// <param name="status">status.</param>
        public Attributes64(
            object output = null,
            Models.ReturnSubmissionTaskStatusEnum? status = null)
        {
            this.Output = output;
            this.Status = status;
        }

        /// <summary>
        /// Key Value map that contains the Task result.
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public object Output { get; set; }

        /// <summary>
        /// status of the return submission task
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReturnSubmissionTaskStatusEnum? Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes64 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes64 other &&                ((this.Output == null && other.Output == null) || (this.Output?.Equals(other.Output) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Output = {(this.Output == null ? "null" : this.Output.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
        }
    }
}