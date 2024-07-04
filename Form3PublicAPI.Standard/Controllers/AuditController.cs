// <copyright file="AuditController.cs" company="APIMatic">
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
    /// AuditController.
    /// </summary>
    public class AuditController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditController"/> class.
        /// </summary>
        internal AuditController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// List audit entries for this record type.
        /// </summary>
        /// <param name="recordType">Required parameter: Record Type.</param>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="pageAfter">Optional parameter: Cursor for next page (this is a base64-encoded UUID continuation token returned from the application and should not be manually generated).</param>
        /// <param name="filterOrganisationId">Optional parameter: Filter by organisation id.</param>
        /// <param name="filterActionTimeFrom">Optional parameter: Example: .</param>
        /// <param name="filterActionTimeTo">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.AuditEntryListResponse response from the API call.</returns>
        public Models.AuditEntryListResponse ListAuditEntriesForThisRecordType(
                string recordType,
                int? pageNumber = null,
                int? pageSize = null,
                string pageAfter = null,
                List<Guid> filterOrganisationId = null,
                DateTime? filterActionTimeFrom = null,
                DateTime? filterActionTimeTo = null)
            => CoreHelper.RunTask(ListAuditEntriesForThisRecordTypeAsync(recordType, pageNumber, pageSize, pageAfter, filterOrganisationId, filterActionTimeFrom, filterActionTimeTo));

        /// <summary>
        /// List audit entries for this record type.
        /// </summary>
        /// <param name="recordType">Required parameter: Record Type.</param>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="pageAfter">Optional parameter: Cursor for next page (this is a base64-encoded UUID continuation token returned from the application and should not be manually generated).</param>
        /// <param name="filterOrganisationId">Optional parameter: Filter by organisation id.</param>
        /// <param name="filterActionTimeFrom">Optional parameter: Example: .</param>
        /// <param name="filterActionTimeTo">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AuditEntryListResponse response from the API call.</returns>
        public async Task<Models.AuditEntryListResponse> ListAuditEntriesForThisRecordTypeAsync(
                string recordType,
                int? pageNumber = null,
                int? pageSize = null,
                string pageAfter = null,
                List<Guid> filterOrganisationId = null,
                DateTime? filterActionTimeFrom = null,
                DateTime? filterActionTimeTo = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AuditEntryListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/audit/entries/{record_type}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("record_type", recordType))
                      .Query(_query => _query.Setup("page[number]", pageNumber))
                      .Query(_query => _query.Setup("page[size]", pageSize))
                      .Query(_query => _query.Setup("page[after]", pageAfter))
                      .Query(_query => _query.Setup("filter[organisation_id]", filterOrganisationId))
                      .Query(_query => _query.Setup("filter[action_time_from]", filterActionTimeFrom.HasValue ? filterActionTimeFrom.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[action_time_to]", filterActionTimeTo.HasValue ? filterActionTimeTo.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch audit entry list for this record type/id.
        /// </summary>
        /// <param name="recordType">Required parameter: Record Type.</param>
        /// <param name="id">Required parameter: Record Id.</param>
        /// <returns>Returns the Models.AuditEntryListResponse response from the API call.</returns>
        public Models.AuditEntryListResponse FetchAuditEntryListForThisRecordTypeId(
                string recordType,
                Guid id)
            => CoreHelper.RunTask(FetchAuditEntryListForThisRecordTypeIdAsync(recordType, id));

        /// <summary>
        /// Fetch audit entry list for this record type/id.
        /// </summary>
        /// <param name="recordType">Required parameter: Record Type.</param>
        /// <param name="id">Required parameter: Record Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AuditEntryListResponse response from the API call.</returns>
        public async Task<Models.AuditEntryListResponse> FetchAuditEntryListForThisRecordTypeIdAsync(
                string recordType,
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AuditEntryListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/audit/entries/{record_type}/{id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("record_type", recordType))
                      .Template(_template => _template.Setup("id", id))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}