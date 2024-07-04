// <copyright file="IConfiguration.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Form3PublicAPI.Standard
{
    using System;
    using System.Net;
    using Form3PublicAPI.Standard.Authentication;
    using Form3PublicAPI.Standard.Models;

    /// <summary>
    /// IConfiguration.
    /// </summary>
    public interface IConfiguration
    {
        /// <summary>
        /// Gets Current API environment.
        /// </summary>
        Environment Environment { get; }

        /// <summary>
        /// Gets the credentials to use with Basic.
        /// </summary>
        IBasicCredentials BasicCredentials { get; }

        /// <summary>
        /// Gets the credentials model to use with Basic.
        /// </summary>
        BasicModel BasicModel { get; }

        /// <summary>
        /// Gets the credentials to use with OAuth2.
        /// </summary>
        IOAuth2Credentials OAuth2Credentials { get; }

        /// <summary>
        /// Gets the credentials model to use with OAuth2.
        /// </summary>
        OAuth2Model OAuth2Model { get; }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        string GetBaseUri(Server alias = Server.Default);
    }
}