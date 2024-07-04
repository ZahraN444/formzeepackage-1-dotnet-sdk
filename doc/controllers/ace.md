# ACE

```csharp
ACEController aCEController = client.ACEController;
```

## Class Name

`ACEController`

## Methods

* [List All Access Controls for Role](../../doc/controllers/ace.md#list-all-access-controls-for-role)
* [Create Access Control Entry](../../doc/controllers/ace.md#create-access-control-entry)
* [Delete Access Control Entry](../../doc/controllers/ace.md#delete-access-control-entry)
* [Fetch Access Control Entry](../../doc/controllers/ace.md#fetch-access-control-entry)


# List All Access Controls for Role

List all Access Controls for role

```csharp
ListAllAccessControlsForRoleAsync(
    Guid roleId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `roleId` | `Guid` | Template, Required | Role Id |

## Response Type

[`Task<Models.AceDetailsListResponse>`](../../doc/models/ace-details-list-response.md)

## Example Usage

```csharp
Guid roleId = new Guid("000010c8-0000-0000-0000-000000000000");
try
{
    AceDetailsListResponse result = await aCEController.ListAllAccessControlsForRoleAsync(roleId);
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
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Create Access Control Entry

Create Access Control Entry

```csharp
CreateAccessControlEntryAsync(
    Guid roleId,
    Models.AceCreation aCECreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `roleId` | `Guid` | Template, Required | Role Id |
| `aCECreationRequest` | [`AceCreation`](../../doc/models/ace-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.AceCreationResponse>`](../../doc/models/ace-creation-response.md)

## Example Usage

```csharp
Guid roleId = new Guid("000010c8-0000-0000-0000-000000000000");
AceCreation aCECreationRequest = new AceCreation
{
    Data = new Ace
    {
        Attributes = new Attributes2
        {
            Action = "CREATE",
            RecordType = "User",
            RoleId = new Guid("813e371b-c16c-4b86-adbf-82bcda159b27"),
        },
        Id = new Guid("7826c3cb-d6fd-41d0-b187-dc23ba928772"),
        OrganisationId = new Guid("ee2fb143-6dfe-4787-b183-ca8ddd4164d2"),
        Type = "ace",
        Version = 0,
    },
};

try
{
    AceCreationResponse result = await aCEController.CreateAccessControlEntryAsync(
        roleId,
        aCECreationRequest
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
| 400 | Bad request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 409 | Conflict | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Delete Access Control Entry

Delete Access Control Entry

```csharp
DeleteAccessControlEntryAsync(
    Guid roleId,
    Guid aceId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `roleId` | `Guid` | Template, Required | Role Id |
| `aceId` | `Guid` | Template, Required | Ace Id |

## Response Type

`Task`

## Example Usage

```csharp
Guid roleId = new Guid("000010c8-0000-0000-0000-000000000000");
Guid aceId = new Guid("00000806-0000-0000-0000-000000000000");
try
{
    await aCEController.DeleteAccessControlEntryAsync(
        roleId,
        aceId
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
| 400 | Bad request | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Fetch Access Control Entry

Fetch Access Control Entry

```csharp
FetchAccessControlEntryAsync(
    Guid roleId,
    Guid aceId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `roleId` | `Guid` | Template, Required | Role Id |
| `aceId` | `Guid` | Template, Required | Ace Id |

## Response Type

[`Task<Models.AceDetailsResponse>`](../../doc/models/ace-details-response.md)

## Example Usage

```csharp
Guid roleId = new Guid("000010c8-0000-0000-0000-000000000000");
Guid aceId = new Guid("00000806-0000-0000-0000-000000000000");
try
{
    AceDetailsResponse result = await aCEController.FetchAccessControlEntryAsync(
        roleId,
        aceId
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
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |

