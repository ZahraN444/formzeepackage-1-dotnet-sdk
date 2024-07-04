// <copyright file="ReportsController.cs" company="APIMatic">
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
    using Form3PublicAPI.Standard.Exceptions;
    using Form3PublicAPI.Standard.Http.Client;
    using Form3PublicAPI.Standard.Utilities;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;

    /// <summary>
    /// ReportsController.
    /// </summary>
    public class ReportsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsController"/> class.
        /// </summary>
        internal ReportsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// List reports.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="filterOrganisationId">Optional parameter: Filter by organisation Ids.</param>
        /// <param name="filterReportType">Optional parameter: Filter by ReportType.</param>
        /// <param name="filterReportTypeDescription">Optional parameter: Filter by Report Type Description.</param>
        /// <param name="filterReportSource">Optional parameter: Filter by Report Source.</param>
        /// <param name="filterCreatedOnAfter">Optional parameter: Request reports created after specific date time.</param>
        /// <param name="filterCreatedOnBefore">Optional parameter: Request reports created after specific date time.</param>
        /// <param name="filterModifiedOnAfter">Optional parameter: Request reports modified after specific date time.</param>
        /// <param name="filterModifiedOnBefore">Optional parameter: Request reports modified before specific date time.</param>
        /// <param name="filterProcessingDateFrom">Optional parameter: Request reports with processing date from specific date (inclusive).</param>
        /// <param name="filterProcessingDateTo">Optional parameter: Request reports with processing date to specific date (inclusive).</param>
        /// <returns>Returns the Models.ReportDetailsListResponse response from the API call.</returns>
        public Models.ReportDetailsListResponse ListReports(
                string pageNumber = null,
                int? pageSize = 100,
                List<Guid> filterOrganisationId = null,
                string filterReportType = null,
                string filterReportTypeDescription = null,
                string filterReportSource = null,
                DateTime? filterCreatedOnAfter = null,
                DateTime? filterCreatedOnBefore = null,
                DateTime? filterModifiedOnAfter = null,
                DateTime? filterModifiedOnBefore = null,
                DateTime? filterProcessingDateFrom = null,
                DateTime? filterProcessingDateTo = null)
            => CoreHelper.RunTask(ListReportsAsync(pageNumber, pageSize, filterOrganisationId, filterReportType, filterReportTypeDescription, filterReportSource, filterCreatedOnAfter, filterCreatedOnBefore, filterModifiedOnAfter, filterModifiedOnBefore, filterProcessingDateFrom, filterProcessingDateTo));

        /// <summary>
        /// List reports.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="filterOrganisationId">Optional parameter: Filter by organisation Ids.</param>
        /// <param name="filterReportType">Optional parameter: Filter by ReportType.</param>
        /// <param name="filterReportTypeDescription">Optional parameter: Filter by Report Type Description.</param>
        /// <param name="filterReportSource">Optional parameter: Filter by Report Source.</param>
        /// <param name="filterCreatedOnAfter">Optional parameter: Request reports created after specific date time.</param>
        /// <param name="filterCreatedOnBefore">Optional parameter: Request reports created after specific date time.</param>
        /// <param name="filterModifiedOnAfter">Optional parameter: Request reports modified after specific date time.</param>
        /// <param name="filterModifiedOnBefore">Optional parameter: Request reports modified before specific date time.</param>
        /// <param name="filterProcessingDateFrom">Optional parameter: Request reports with processing date from specific date (inclusive).</param>
        /// <param name="filterProcessingDateTo">Optional parameter: Request reports with processing date to specific date (inclusive).</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReportDetailsListResponse response from the API call.</returns>
        public async Task<Models.ReportDetailsListResponse> ListReportsAsync(
                string pageNumber = null,
                int? pageSize = 100,
                List<Guid> filterOrganisationId = null,
                string filterReportType = null,
                string filterReportTypeDescription = null,
                string filterReportSource = null,
                DateTime? filterCreatedOnAfter = null,
                DateTime? filterCreatedOnBefore = null,
                DateTime? filterModifiedOnAfter = null,
                DateTime? filterModifiedOnBefore = null,
                DateTime? filterProcessingDateFrom = null,
                DateTime? filterProcessingDateTo = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReportDetailsListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/notification/reports")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page[number]", pageNumber))
                      .Query(_query => _query.Setup("page[size]", (pageSize != null) ? pageSize : 100))
                      .Query(_query => _query.Setup("filter[organisation_id]", filterOrganisationId))
                      .Query(_query => _query.Setup("filter[report_type]", filterReportType))
                      .Query(_query => _query.Setup("filter[report_type_description]", filterReportTypeDescription))
                      .Query(_query => _query.Setup("filter[report_source]", filterReportSource))
                      .Query(_query => _query.Setup("filter[created_on_after]", filterCreatedOnAfter.HasValue ? filterCreatedOnAfter.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[created_on_before]", filterCreatedOnBefore.HasValue ? filterCreatedOnBefore.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[modified_on_after]", filterModifiedOnAfter.HasValue ? filterModifiedOnAfter.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[modified_on_before]", filterModifiedOnBefore.HasValue ? filterModifiedOnBefore.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[processing_date_from]", filterProcessingDateFrom.HasValue ? filterProcessingDateFrom.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("filter[processing_date_to]", filterProcessingDateTo.HasValue ? filterProcessingDateTo.Value.ToString("yyyy'-'MM'-'dd") : null))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Reports bad request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get report by ID.
        /// </summary>
        /// <param name="id">Required parameter: Report ID.</param>
        /// <param name="accept">Required parameter: Acceptable Format.</param>
        /// <returns>Returns the Models.ReportDetailsResponse response from the API call.</returns>
        public Models.ReportDetailsResponse GetReport(
                Guid id,
                string accept)
            => CoreHelper.RunTask(GetReportAsync(id, accept));

        /// <summary>
        /// Get report by ID.
        /// </summary>
        /// <param name="id">Required parameter: Report ID.</param>
        /// <param name="accept">Required parameter: Acceptable Format.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReportDetailsResponse response from the API call.</returns>
        public async Task<Models.ReportDetailsResponse> GetReportAsync(
                Guid id,
                string accept,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReportDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/notification/reports/{id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("Accept", accept))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Report Not Found", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("406", CreateErrorCase("Report not available in acceptable format", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get Report Admission by ID.
        /// </summary>
        /// <param name="id">Required parameter: Report Id.</param>
        /// <param name="admissionId">Required parameter: Report Admission ID.</param>
        /// <returns>Returns the Models.ReportAdmissionDetailsResponse response from the API call.</returns>
        public Models.ReportAdmissionDetailsResponse GetReportAdmissionByID(
                Guid id,
                Guid admissionId)
            => CoreHelper.RunTask(GetReportAdmissionByIDAsync(id, admissionId));

        /// <summary>
        /// Get Report Admission by ID.
        /// </summary>
        /// <param name="id">Required parameter: Report Id.</param>
        /// <param name="admissionId">Required parameter: Report Admission ID.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReportAdmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.ReportAdmissionDetailsResponse> GetReportAdmissionByIDAsync(
                Guid id,
                Guid admissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReportAdmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/notification/reports/{id}/admissions/{admissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("admissionId", admissionId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}