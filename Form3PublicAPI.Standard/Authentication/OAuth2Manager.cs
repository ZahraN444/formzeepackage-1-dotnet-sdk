// <copyright file="OAuth2Manager.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Form3PublicAPI.Standard.Authentication
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using Form3PublicAPI.Standard.Controllers;
    using Form3PublicAPI.Standard.Models;
    using Form3PublicAPI.Standard.Utilities;
    using Form3PublicAPI.Standard.Exceptions;
    using APIMatic.Core.Authentication;
    using APIMatic.Core;

    /// <summary>
    /// OAuth2Manager Class.
    /// </summary>
    public class OAuth2Manager : AuthManager, IOAuth2Credentials
    {
        private Func<OAuthAuthorizationController> oAuthApi;

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2Manager"/> class.
        /// </summary>
        /// <param name="oAuth2"> OAuth 2 Client Cridentials Model.</param>
        internal OAuth2Manager(OAuth2Model oAuth2)
        {
            OAuthClientId = oAuth2?.OAuthClientId;
            OAuthClientSecret = oAuth2?.OAuthClientSecret;
            OAuthToken = oAuth2?.OAuthToken;
            Parameters(authParameter => authParameter
                .Header(headerParameter => headerParameter
                    .Setup("Authorization",
                        OAuthToken?.AccessToken == null ? null : $"Bearer {OAuthToken?.AccessToken}"
                    ).Required()));
        }

        /// <summary>
        /// Gets string value for oAuthClientId.
        /// </summary>
        public string OAuthClientId { get; }

        /// <summary>
        /// Gets string value for oAuthClientSecret.
        /// </summary>
        public string OAuthClientSecret { get; }

        /// <summary>
        /// Gets Models.OAuthToken value for oAuthToken.
        /// </summary>
        public Models.OAuthToken OAuthToken { get; }

        /// <summary>
        /// Check if credentials match.
        /// </summary>
        /// <param name="oAuthClientId"> The string value for credentials.</param>
        /// <param name="oAuthClientSecret"> The string value for credentials.</param>
        /// <param name="oAuthToken"> The Models.OAuthToken value for credentials.</param>
        /// <returns> True if credentials matched.</returns>
        public bool Equals(string oAuthClientId, string oAuthClientSecret, Models.OAuthToken oAuthToken)
        {
            return oAuthClientId.Equals(this.OAuthClientId)
                    && oAuthClientSecret.Equals(this.OAuthClientSecret)
                    && ((oAuthToken == null && this.OAuthToken == null) || (oAuthToken != null && this.OAuthToken != null && oAuthToken.Equals(this.OAuthToken)));
        }

        /// <summary>
        /// Fetch the OAuth token.
        /// </summary>
        /// <param name="additionalParameters">Dictionary of additional parameters.</param>
        /// <returns>Models.OAuthToken.</returns>
        public Models.OAuthToken FetchToken(Dictionary<string, object> additionalParameters = null)
            => ApiHelper.RunTask(FetchTokenAsync(additionalParameters));
       

        /// <summary>
        /// Fetch the OAuth token asynchronously.
        /// </summary>
        /// <param name="additionalParameters">Dictionary of additional parameters.</param>
        /// <returns>Models.OAuthToken.</returns>
        public async Task<Models.OAuthToken> FetchTokenAsync(Dictionary<string, object> additionalParameters = null)
        {
            var token = await oAuthApi?.Invoke().RequestTokenOAuth2Async(BuildBasicAuthHeader(), fieldParameters: additionalParameters);

            if (token.ExpiresIn != null && token.ExpiresIn != 0)
            {
                token.Expiry = (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds + token.ExpiresIn;
            }

            return token;
        }
 
        /// <summary>
        /// Checks if token is expired.
        /// </summary>
        /// <returns> Returns true if token is expired.</returns>
        public bool IsTokenExpired()
        {
           if (this.OAuthToken == null)
           {
               throw new InvalidOperationException("OAuth token is missing.");
           }
        
           return this.OAuthToken.Expiry != null
               && this.OAuthToken.Expiry < (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
        }

        public void ApplyGlobalConfiguration(Func<OAuthAuthorizationController> controllerGetter)
        {
            oAuthApi = controllerGetter;
        }

        /// <summary>
        /// Validates the authentication parameters for the HTTP Request.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (OAuthToken == null)
            {
                throw new ApiException(
                        "Client is not authorized.An OAuth token is needed to make API calls.");
            }

            if (IsTokenExpired())
            {
                throw new ApiException(
                        "OAuth token is expired. A valid token is needed to make API calls.");
            }
        }


        /// <summary>
        /// Build basic auth header.
        /// </summary>
        /// <returns> string. </returns>
        private string BuildBasicAuthHeader()
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(this.OAuthClientId + ':' + this.OAuthClientSecret);
            return "Basic " + Convert.ToBase64String(plainTextBytes);
        }
    }

    public sealed class OAuth2Model
    {
        internal OAuth2Model()
        {
        }

        internal string OAuthClientId { get; set; }

        internal string OAuthClientSecret { get; set; }

        internal Models.OAuthToken OAuthToken { get; set; }

        /// <summary>
        /// Creates an object of the OAuth2Model using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            return new Builder(OAuthClientId, OAuthClientSecret)
                .OAuthToken(OAuthToken);
        }

        /// <summary>
        /// Builder class for OAuth2Model.
        /// </summary>
        public class Builder
        {
            private string oAuthClientId;
            private string oAuthClientSecret;
            private Models.OAuthToken oAuthToken;

            public Builder(string oAuthClientId, string oAuthClientSecret)
            {
                this.oAuthClientId = oAuthClientId ?? throw new ArgumentNullException(nameof(oAuthClientId));
                this.oAuthClientSecret = oAuthClientSecret ?? throw new ArgumentNullException(nameof(oAuthClientSecret));
            }

            /// <summary>
            /// Sets OAuthClientId.
            /// </summary>
            /// <param name="oAuthClientId">OAuthClientId.</param>
            /// <returns>Builder.</returns>
            public Builder OAuthClientId(string oAuthClientId)
            {
                this.oAuthClientId = oAuthClientId ?? throw new ArgumentNullException(nameof(oAuthClientId));
                return this;
            }


            /// <summary>
            /// Sets OAuthClientSecret.
            /// </summary>
            /// <param name="oAuthClientSecret">OAuthClientSecret.</param>
            /// <returns>Builder.</returns>
            public Builder OAuthClientSecret(string oAuthClientSecret)
            {
                this.oAuthClientSecret = oAuthClientSecret ?? throw new ArgumentNullException(nameof(oAuthClientSecret));
                return this;
            }


            /// <summary>
            /// Sets OAuthToken.
            /// </summary>
            /// <param name="oAuthToken">OAuthToken.</param>
            /// <returns>Builder.</returns>
            public Builder OAuthToken(Models.OAuthToken oAuthToken)
            {
                this.oAuthToken = oAuthToken;
                return this;
            }


            /// <summary>
            /// Creates an object of the OAuth2Model using the values provided for the builder.
            /// </summary>
            /// <returns>OAuth2Model.</returns>
            public OAuth2Model Build()
            {
                return new OAuth2Model()
                {
                    OAuthClientId = this.oAuthClientId,
                    OAuthClientSecret = this.oAuthClientSecret,
                    OAuthToken = this.oAuthToken
                };
            }
        }
    }
}