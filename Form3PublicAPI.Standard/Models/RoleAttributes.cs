// <copyright file="RoleAttributes.cs" company="APIMatic">
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
    /// RoleAttributes.
    /// </summary>
    public class RoleAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleAttributes"/> class.
        /// </summary>
        public RoleAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleAttributes"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="parentRoleId">parent_role_id.</param>
        public RoleAttributes(
            string name = null,
            Guid? parentRoleId = null)
        {
            this.Name = name;
            this.ParentRoleId = parentRoleId;
        }

        /// <summary>
        /// Name of the role
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Unique resource ID of the parent Role
        /// </summary>
        [JsonProperty("parent_role_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ParentRoleId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RoleAttributes : ({string.Join(", ", toStringOutput)})";
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
            return obj is RoleAttributes other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.ParentRoleId == null && other.ParentRoleId == null) || (this.ParentRoleId?.Equals(other.ParentRoleId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.ParentRoleId = {(this.ParentRoleId == null ? "null" : this.ParentRoleId.ToString())}");
        }
    }
}