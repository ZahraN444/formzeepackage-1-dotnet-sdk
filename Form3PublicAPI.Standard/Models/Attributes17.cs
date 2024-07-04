// <copyright file="Attributes17.cs" company="APIMatic">
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
    /// Attributes17.
    /// </summary>
    public class Attributes17
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes17"/> class.
        /// </summary>
        public Attributes17()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes17"/> class.
        /// </summary>
        /// <param name="assignee">assignee.</param>
        /// <param name="name">name.</param>
        /// <param name="output">output.</param>
        /// <param name="status">status.</param>
        public Attributes17(
            Models.PaymentSubmissionTaskAssigneeEnum? assignee = null,
            string name = null,
            object output = null,
            Models.PaymentSubmissionTaskStatusEnum? status = null)
        {
            this.Assignee = assignee;
            this.Name = name;
            this.Output = output;
            this.Status = status;
        }

        /// <summary>
        /// Helps to identify the owner of the task
        /// </summary>
        [JsonProperty("assignee", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentSubmissionTaskAssigneeEnum? Assignee { get; set; }

        /// <summary>
        /// Identifies the payment submission task to be executed
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Key Value map that contains the Task result.
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public object Output { get; set; }

        /// <summary>
        /// status of the submission task
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentSubmissionTaskStatusEnum? Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes17 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes17 other &&                ((this.Assignee == null && other.Assignee == null) || (this.Assignee?.Equals(other.Assignee) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Output == null && other.Output == null) || (this.Output?.Equals(other.Output) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Assignee = {(this.Assignee == null ? "null" : this.Assignee.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"Output = {(this.Output == null ? "null" : this.Output.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
        }
    }
}