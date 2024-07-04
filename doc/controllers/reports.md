# Reports

```csharp
ReportsController reportsController = client.ReportsController;
```

## Class Name

`ReportsController`

## Methods

* [List Reports](../../doc/controllers/reports.md#list-reports)
* [Get Report](../../doc/controllers/reports.md#get-report)
* [Get Report Admission by ID](../../doc/controllers/reports.md#get-report-admission-by-id)


# List Reports

List reports

```csharp
ListReportsAsync(
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
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pageNumber` | `string` | Query, Optional | Which page to select |
| `pageSize` | `int?` | Query, Optional | Number of items to select |
| `filterOrganisationId` | `List<Guid>` | Query, Optional | Filter by organisation Ids |
| `filterReportType` | `string` | Query, Optional | Filter by ReportType |
| `filterReportTypeDescription` | `string` | Query, Optional | Filter by Report Type Description |
| `filterReportSource` | `string` | Query, Optional | Filter by Report Source |
| `filterCreatedOnAfter` | `DateTime?` | Query, Optional | Request reports created after specific date time |
| `filterCreatedOnBefore` | `DateTime?` | Query, Optional | Request reports created after specific date time |
| `filterModifiedOnAfter` | `DateTime?` | Query, Optional | Request reports modified after specific date time |
| `filterModifiedOnBefore` | `DateTime?` | Query, Optional | Request reports modified before specific date time |
| `filterProcessingDateFrom` | `DateTime?` | Query, Optional | Request reports with processing date from specific date (inclusive) |
| `filterProcessingDateTo` | `DateTime?` | Query, Optional | Request reports with processing date to specific date (inclusive) |

## Response Type

[`Task<Models.ReportDetailsListResponse>`](../../doc/models/report-details-list-response.md)

## Example Usage

```csharp
Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')try
{
    ReportDetailsListResponse result = await reportsController.ListReportsAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Reports bad request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Get Report

Get report by ID

```csharp
GetReportAsync(
    Guid id,
    string accept)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Report ID |
| `accept` | `string` | Header, Required | Acceptable Format |

## Response Type

[`Task<Models.ReportDetailsResponse>`](../../doc/models/report-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
string accept = "Accept0";
try
{
    ReportDetailsResponse result = await reportsController.GetReportAsync(
        id,
        accept
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Report Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 406 | Report not available in acceptable format | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Get Report Admission by ID

Get Report Admission by ID

```csharp
GetReportAdmissionByIDAsync(
    Guid id,
    Guid admissionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Report Id |
| `admissionId` | `Guid` | Template, Required | Report Admission ID |

## Response Type

[`Task<Models.ReportAdmissionDetailsResponse>`](../../doc/models/report-admission-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Guid admissionId = new Guid("00000f44-0000-0000-0000-000000000000");
try
{
    ReportAdmissionDetailsResponse result = await reportsController.GetReportAdmissionByIDAsync(
        id,
        admissionId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 403 | Forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |

