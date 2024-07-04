// <copyright file="ReversalAdmissionUpdateRelationships.cs" company="APIMatic">
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
    /// ReversalAdmissionUpdateRelationships.
    /// </summary>
    public class ReversalAdmissionUpdateRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReversalAdmissionUpdateRelationships"/> class.
        /// </summary>
        public ReversalAdmissionUpdateRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReversalAdmissionUpdateRelationships"/> class.
        /// </summary>
        /// <param name="reversalAdmissionTasks">reversal_admission_tasks.</param>
        public ReversalAdmissionUpdateRelationships(
            List<Models.ReversalAdmissionTask> reversalAdmissionTasks = null)
        {
            this.ReversalAdmissionTasks = reversalAdmissionTasks;
        }

        /// <summary>
        /// Gets or sets ReversalAdmissionTasks.
        /// </summary>
        [JsonProperty("reversal_admission_tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ReversalAdmissionTask> ReversalAdmissionTasks { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReversalAdmissionUpdateRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReversalAdmissionUpdateRelationships other &&                ((this.ReversalAdmissionTasks == null && other.ReversalAdmissionTasks == null) || (this.ReversalAdmissionTasks?.Equals(other.ReversalAdmissionTasks) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ReversalAdmissionTasks = {(this.ReversalAdmissionTasks == null ? "null" : $"[{string.Join(", ", this.ReversalAdmissionTasks)} ]")}");
        }
    }
}