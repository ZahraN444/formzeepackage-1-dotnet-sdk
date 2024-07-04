// <copyright file="AccountsController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Form3PublicAPI.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using APIMatic.Core;
    using APIMatic.Core.Types;
    using APIMatic.Core.Utilities;
    using APIMatic.Core.Utilities.Date.Xml;
    using Form3PublicAPI.Standard;
    using Form3PublicAPI.Standard.Http.Client;
    using Form3PublicAPI.Standard.Utilities;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;

    /// <summary>
    /// AccountsController.
    /// </summary>
    public class AccountsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsController"/> class.
        /// </summary>
        internal AccountsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// List accounts.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageBefore">Optional parameter: Cursor value for getting previous page.</param>
        /// <param name="pageAfter">Optional parameter: Cursor value for getting next page.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="filterOrganisationId">Optional parameter: Filter by organisation id.</param>
        /// <param name="filterBankIdCode">Optional parameter: Filter by type of bank id e.g. "GBDSC".</param>
        /// <param name="filterBankId">Optional parameter: Filter by bank id e.g. sort code or bic.</param>
        /// <param name="filterAccountNumber">Optional parameter: Filter by account number.</param>
        /// <param name="filterCountry">Optional parameter: Filter by country e.g. FR,GB.</param>
        /// <param name="filterCustomerId">Optional parameter: Filter by customer_id.</param>
        /// <param name="filterIban">Optional parameter: Filter by IBAN.</param>
        /// <returns>Returns the Models.AccountDetailsListResponse response from the API call.</returns>
        public Models.AccountDetailsListResponse ListAccounts(
                string pageNumber = null,
                string pageBefore = null,
                string pageAfter = null,
                int? pageSize = null,
                List<Guid> filterOrganisationId = null,
                List<string> filterBankIdCode = null,
                List<string> filterBankId = null,
                List<string> filterAccountNumber = null,
                List<string> filterCountry = null,
                List<string> filterCustomerId = null,
                List<string> filterIban = null)
            => CoreHelper.RunTask(ListAccountsAsync(pageNumber, pageBefore, pageAfter, pageSize, filterOrganisationId, filterBankIdCode, filterBankId, filterAccountNumber, filterCountry, filterCustomerId, filterIban));

        /// <summary>
        /// List accounts.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageBefore">Optional parameter: Cursor value for getting previous page.</param>
        /// <param name="pageAfter">Optional parameter: Cursor value for getting next page.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="filterOrganisationId">Optional parameter: Filter by organisation id.</param>
        /// <param name="filterBankIdCode">Optional parameter: Filter by type of bank id e.g. "GBDSC".</param>
        /// <param name="filterBankId">Optional parameter: Filter by bank id e.g. sort code or bic.</param>
        /// <param name="filterAccountNumber">Optional parameter: Filter by account number.</param>
        /// <param name="filterCountry">Optional parameter: Filter by country e.g. FR,GB.</param>
        /// <param name="filterCustomerId">Optional parameter: Filter by customer_id.</param>
        /// <param name="filterIban">Optional parameter: Filter by IBAN.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AccountDetailsListResponse response from the API call.</returns>
        public async Task<Models.AccountDetailsListResponse> ListAccountsAsync(
                string pageNumber = null,
                string pageBefore = null,
                string pageAfter = null,
                int? pageSize = null,
                List<Guid> filterOrganisationId = null,
                List<string> filterBankIdCode = null,
                List<string> filterBankId = null,
                List<string> filterAccountNumber = null,
                List<string> filterCountry = null,
                List<string> filterCustomerId = null,
                List<string> filterIban = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AccountDetailsListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/organisation/accounts")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page[number]", pageNumber))
                      .Query(_query => _query.Setup("page[before]", pageBefore))
                      .Query(_query => _query.Setup("page[after]", pageAfter))
                      .Query(_query => _query.Setup("page[size]", pageSize))
                      .Query(_query => _query.Setup("filter[organisation_id]", filterOrganisationId))
                      .Query(_query => _query.Setup("filter[bank_id_code]", filterBankIdCode))
                      .Query(_query => _query.Setup("filter[bank_id]", filterBankId))
                      .Query(_query => _query.Setup("filter[account_number]", filterAccountNumber))
                      .Query(_query => _query.Setup("filter[country]", filterCountry))
                      .Query(_query => _query.Setup("filter[customer_id]", filterCustomerId))
                      .Query(_query => _query.Setup("filter[iban]", filterIban))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create account.
        /// </summary>
        /// <param name="accountCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.AccountCreationResponse response from the API call.</returns>
        public Models.AccountCreationResponse CreateAccount(
                Models.AccountCreation accountCreationRequest = null)
            => CoreHelper.RunTask(CreateAccountAsync(accountCreationRequest));

        /// <summary>
        /// Create account.
        /// </summary>
        /// <param name="accountCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AccountCreationResponse response from the API call.</returns>
        public async Task<Models.AccountCreationResponse> CreateAccountAsync(
                Models.AccountCreation accountCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AccountCreationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/organisation/accounts")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(accountCreationRequest))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete account.
        /// </summary>
        /// <param name="id">Required parameter: Account Id.</param>
        /// <param name="version">Required parameter: Version.</param>
        public void DeleteAccount(
                Guid id,
                int version)
            => CoreHelper.RunVoidTask(DeleteAccountAsync(id, version));

        /// <summary>
        /// Delete account.
        /// </summary>
        /// <param name="id">Required parameter: Account Id.</param>
        /// <param name="version">Required parameter: Version.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteAccountAsync(
                Guid id,
                int version,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/organisation/accounts/{id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Query(_query => _query.Setup("version", version))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch account.
        /// </summary>
        /// <param name="id">Required parameter: Account Id.</param>
        /// <returns>Returns the Models.AccountDetailsResponse response from the API call.</returns>
        public Models.AccountDetailsResponse FetchAccount(
                Guid id)
            => CoreHelper.RunTask(FetchAccountAsync(id));

        /// <summary>
        /// Fetch account.
        /// </summary>
        /// <param name="id">Required parameter: Account Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AccountDetailsResponse response from the API call.</returns>
        public async Task<Models.AccountDetailsResponse> FetchAccountAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AccountDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/organisation/accounts/{id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Amend account.
        /// </summary>
        /// <param name="id">Required parameter: Account Id.</param>
        /// <param name="accountAmendRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.AccountDetailsResponse response from the API call.</returns>
        public Models.AccountDetailsResponse AmendAccount(
                Guid id,
                Models.AccountAmendment accountAmendRequest = null)
            => CoreHelper.RunTask(AmendAccountAsync(id, accountAmendRequest));

        /// <summary>
        /// Amend account.
        /// </summary>
        /// <param name="id">Required parameter: Account Id.</param>
        /// <param name="accountAmendRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AccountDetailsResponse response from the API call.</returns>
        public async Task<Models.AccountDetailsResponse> AmendAccountAsync(
                Guid id,
                Models.AccountAmendment accountAmendRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AccountDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/organisation/accounts/{id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(accountAmendRequest))
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch account events.
        /// </summary>
        /// <param name="id">Required parameter: Account Id.</param>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <returns>Returns the Models.AccountEventListResponse response from the API call.</returns>
        public Models.AccountEventListResponse FetchAccountEvents(
                Guid id,
                string pageNumber = null,
                int? pageSize = null)
            => CoreHelper.RunTask(FetchAccountEventsAsync(id, pageNumber, pageSize));

        /// <summary>
        /// Fetch account events.
        /// </summary>
        /// <param name="id">Required parameter: Account Id.</param>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AccountEventListResponse response from the API call.</returns>
        public async Task<Models.AccountEventListResponse> FetchAccountEventsAsync(
                Guid id,
                string pageNumber = null,
                int? pageSize = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AccountEventListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/organisation/accounts/{id}/events")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Query(_query => _query.Setup("page[number]", pageNumber))
                      .Query(_query => _query.Setup("page[size]", pageSize))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}