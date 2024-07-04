# Audit

```csharp
AuditController auditController = client.AuditController;
```

## Class Name

`AuditController`

## Methods

* [List Audit Entries for This Record Type](../../doc/controllers/audit.md#list-audit-entries-for-this-record-type)
* [Fetch Audit Entry List for This Record Type Id](../../doc/controllers/audit.md#fetch-audit-entry-list-for-this-record-type-id)


# List Audit Entries for This Record Type

List audit entries for this record type

```csharp
ListAuditEntriesForThisRecordTypeAsync(
    string recordType,
    int? pageNumber = null,
    int? pageSize = null,
    string pageAfter = null,
    List<Guid> filterOrganisationId = null,
    DateTime? filterActionTimeFrom = null,
    DateTime? filterActionTimeTo = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recordType` | `string` | Template, Required | Record Type |
| `pageNumber` | `int?` | Query, Optional | Which page to select |
| `pageSize` | `int?` | Query, Optional | Number of items to select |
| `pageAfter` | `string` | Query, Optional | Cursor for next page (this is a base64-encoded UUID continuation token returned from the application and should not be manually generated) |
| `filterOrganisationId` | `List<Guid>` | Query, Optional | Filter by organisation id |
| `filterActionTimeFrom` | `DateTime?` | Query, Optional | - |
| `filterActionTimeTo` | `DateTime?` | Query, Optional | - |

## Response Type

[`Task<Models.AuditEntryListResponse>`](../../doc/models/audit-entry-list-response.md)

## Example Usage

```csharp
string recordType = "record_type6";
Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')try
{
    AuditEntryListResponse result = await auditController.ListAuditEntriesForThisRecordTypeAsync(recordType);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Fetch Audit Entry List for This Record Type Id

Fetch audit entry list for this record type/id

```csharp
FetchAuditEntryListForThisRecordTypeIdAsync(
    string recordType,
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recordType` | `string` | Template, Required | Record Type |
| `id` | `Guid` | Template, Required | Record Id |

## Response Type

[`Task<Models.AuditEntryListResponse>`](../../doc/models/audit-entry-list-response.md)

## Example Usage

```csharp
string recordType = "record_type6";
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    AuditEntryListResponse result = await auditController.FetchAuditEntryListForThisRecordTypeIdAsync(
        recordType,
        id
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

