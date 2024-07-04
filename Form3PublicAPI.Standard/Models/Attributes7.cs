// <copyright file="Attributes7.cs" company="APIMatic">
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
    /// Attributes7.
    /// </summary>
    public class Attributes7
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes7"/> class.
        /// </summary>
        public Attributes7()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes7"/> class.
        /// </summary>
        /// <param name="assignee">assignee.</param>
        /// <param name="name">name.</param>
        /// <param name="output">output.</param>
        /// <param name="status">status.</param>
        /// <param name="workflow">workflow.</param>
        public Attributes7(
            Models.PaymentAdmissionTaskAssigneeEnum? assignee = null,
            string name = null,
            object output = null,
            Models.PaymentAdmissionTaskStatusEnum? status = null,
            Guid? workflow = null)
        {
            this.Assignee = assignee;
            this.Name = name;
            this.Output = output;
            this.Status = status;
            this.Workflow = workflow;
        }

        /// <summary>
        /// Helps to identify the owner of the task
        /// </summary>
        [JsonProperty("assignee", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentAdmissionTaskAssigneeEnum? Assignee { get; set; }

        /// <summary>
        /// Identifies the payment admission task to be executed
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Key Value map that contains the Task result.
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public object Output { get; set; }

        /// <summary>
        /// status of the task
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentAdmissionTaskStatusEnum? Status { get; set; }

        /// <summary>
        /// Identifies the workflow for which the task was created
        /// </summary>
        [JsonProperty("workflow", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Workflow { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes7 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes7 other &&                ((this.Assignee == null && other.Assignee == null) || (this.Assignee?.Equals(other.Assignee) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Output == null && other.Output == null) || (this.Output?.Equals(other.Output) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Workflow == null && other.Workflow == null) || (this.Workflow?.Equals(other.Workflow) == true));
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
            toStringOutput.Add($"this.Workflow = {(this.Workflow == null ? "null" : this.Workflow.ToString())}");
        }
    }
}