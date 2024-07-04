// <copyright file="BasicManager.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Form3PublicAPI.Standard.Authentication
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using Form3PublicAPI.Standard.Http.Request;
    using APIMatic.Core.Authentication;

    /// <summary>
    /// BasicManager Class.
    /// </summary>
    internal class BasicManager : AuthManager, IBasicCredentials
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BasicManager"/> class.
        /// </summary>
        /// <param name="basic"> BasicModel.</param>
        internal BasicManager(BasicModel basicAuth)
        {
            Username = basicAuth?.Username;
            Password = basicAuth?.Password;
            Parameters(paramBuilder => paramBuilder
                .Header(header => header.Setup("Authorization", GetBasicAuthHeader()).Required()));
        }

        /// <summary>
        /// Gets string value for username.
        /// </summary>
        public string Username { get; }

        /// <summary>
        /// Gets string value for password.
        /// </summary>
        public string Password { get; }

        /// <summary>
        /// Check if credentials match.
        /// </summary>
        /// <param name="username"> The string value for credentials.</param>
        /// <param name="password"> The string value for credentials.</param>
        /// <returns> True if credentials matched.</returns>
        public bool Equals(string username, string password)
        {
            return username.Equals(this.Username)
                    && password.Equals(this.Password);
        }

        private string GetBasicAuthHeader()
        {
            if (this.Username == null || this.Password == null)
                return null;

            string authCredentials = this.Username + ":" + this.Password;
            byte[] data = Encoding.ASCII.GetBytes(authCredentials);
            return "Basic " + Convert.ToBase64String(data);
        }
    }

    public sealed class BasicModel
    {
        internal BasicModel()
        {
        }

        internal string Username { get; set; }

        internal string Password { get; set; }

        /// <summary>
        /// Creates an object of the BasicModel using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            return new Builder(Username, Password);
        }

        /// <summary>
        /// Builder class for BasicModel.
        /// </summary>
        public class Builder
        {
            private string username;
            private string password;

            public Builder(string username, string password)
            {
                this.username = username ?? throw new ArgumentNullException(nameof(username));
                this.password = password ?? throw new ArgumentNullException(nameof(password));
            }

            /// <summary>
            /// Sets Username.
            /// </summary>
            /// <param name="username">Username.</param>
            /// <returns>Builder.</returns>
            public Builder Username(string username)
            {
                this.username = username ?? throw new ArgumentNullException(nameof(username));
                return this;
            }


            /// <summary>
            /// Sets Password.
            /// </summary>
            /// <param name="password">Password.</param>
            /// <returns>Builder.</returns>
            public Builder Password(string password)
            {
                this.password = password ?? throw new ArgumentNullException(nameof(password));
                return this;
            }


            /// <summary>
            /// Creates an object of the BasicModel using the values provided for the builder.
            /// </summary>
            /// <returns>BasicModel.</returns>
            public BasicModel Build()
            {
                return new BasicModel()
                {
                    Username = this.username,
                    Password = this.password
                };
            }
        }
    }
}