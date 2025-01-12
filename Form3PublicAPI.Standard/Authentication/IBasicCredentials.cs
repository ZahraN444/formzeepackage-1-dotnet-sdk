// <copyright file="IBasicCredentials.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Form3PublicAPI.Standard.Authentication
{
    using System;

    /// <summary>
    /// Authentication configuration interface for Basic.
    /// </summary>
    public interface IBasicCredentials
    {
        /// <summary>
        /// Gets string value for username.
        /// </summary>
        string Username { get; }

        /// <summary>
        /// Gets string value for password.
        /// </summary>
        string Password { get; }

        /// <summary>
        ///  Returns true if credentials matched.
        /// </summary>
        /// <param name="username"> The string value for credentials.</param>
        /// <param name="password"> The string value for credentials.</param>
        /// <returns>True if credentials matched.</returns>
        bool Equals(string username, string password);
    }
}