// <copyright file="ReturnSubmissionUpdateRelationships.cs" company="APIMatic">
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
    /// ReturnSubmissionUpdateRelationships.
    /// </summary>
    public class ReturnSubmissionUpdateRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnSubmissionUpdateRelationships"/> class.
        /// </summary>
        public ReturnSubmissionUpdateRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnSubmissionUpdateRelationships"/> class.
        /// </summary>
        /// <param name="returnSubmissionTasks">return_submission_tasks.</param>
        public ReturnSubmissionUpdateRelationships(
            List<Models.ReturnSubmissionTask> returnSubmissionTasks = null)
        {
            this.ReturnSubmissionTasks = returnSubmissionTasks;
        }

        /// <summary>
        /// Gets or sets ReturnSubmissionTasks.
        /// </summary>
        [JsonProperty("return_submission_tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ReturnSubmissionTask> ReturnSubmissionTasks { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReturnSubmissionUpdateRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReturnSubmissionUpdateRelationships other &&                ((this.ReturnSubmissionTasks == null && other.ReturnSubmissionTasks == null) || (this.ReturnSubmissionTasks?.Equals(other.ReturnSubmissionTasks) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ReturnSubmissionTasks = {(this.ReturnSubmissionTasks == null ? "null" : $"[{string.Join(", ", this.ReturnSubmissionTasks)} ]")}");
        }
    }
}