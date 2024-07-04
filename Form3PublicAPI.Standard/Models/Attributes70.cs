// <copyright file="Attributes70.cs" company="APIMatic">
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
    /// Attributes70.
    /// </summary>
    public class Attributes70
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes70"/> class.
        /// </summary>
        public Attributes70()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes70"/> class.
        /// </summary>
        /// <param name="clientCredentialIds">client_credential_ids.</param>
        /// <param name="email">email.</param>
        /// <param name="publicKeyIds">public_key_ids.</param>
        /// <param name="roleIds">role_ids.</param>
        /// <param name="username">username.</param>
        public Attributes70(
            List<string> clientCredentialIds = null,
            string email = null,
            List<Guid> publicKeyIds = null,
            List<Guid> roleIds = null,
            string username = null)
        {
            this.ClientCredentialIds = clientCredentialIds;
            this.Email = email;
            this.PublicKeyIds = publicKeyIds;
            this.RoleIds = roleIds;
            this.Username = username;
        }

        /// <summary>
        /// Gets or sets ClientCredentialIds.
        /// </summary>
        [JsonProperty("client_credential_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ClientCredentialIds { get; set; }

        /// <summary>
        /// Email address
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets PublicKeyIds.
        /// </summary>
        [JsonProperty("public_key_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<Guid> PublicKeyIds { get; set; }

        /// <summary>
        /// List of roles that this user belongs to
        /// </summary>
        [JsonProperty("role_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<Guid> RoleIds { get; set; }

        /// <summary>
        /// User name
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes70 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes70 other &&                ((this.ClientCredentialIds == null && other.ClientCredentialIds == null) || (this.ClientCredentialIds?.Equals(other.ClientCredentialIds) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.PublicKeyIds == null && other.PublicKeyIds == null) || (this.PublicKeyIds?.Equals(other.PublicKeyIds) == true)) &&
                ((this.RoleIds == null && other.RoleIds == null) || (this.RoleIds?.Equals(other.RoleIds) == true)) &&
                ((this.Username == null && other.Username == null) || (this.Username?.Equals(other.Username) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ClientCredentialIds = {(this.ClientCredentialIds == null ? "null" : $"[{string.Join(", ", this.ClientCredentialIds)} ]")}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email)}");
            toStringOutput.Add($"this.PublicKeyIds = {(this.PublicKeyIds == null ? "null" : $"[{string.Join(", ", this.PublicKeyIds)} ]")}");
            toStringOutput.Add($"this.RoleIds = {(this.RoleIds == null ? "null" : $"[{string.Join(", ", this.RoleIds)} ]")}");
            toStringOutput.Add($"this.Username = {(this.Username == null ? "null" : this.Username)}");
        }
    }
}