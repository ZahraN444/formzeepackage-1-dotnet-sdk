# Account Identification

```csharp
AccountIdentificationController accountIdentificationController = client.AccountIdentificationController;
```

## Class Name

`AccountIdentificationController`

## Methods

* [List Account Identifications by Account](../../doc/controllers/account-identification.md#list-account-identifications-by-account)
* [Create an Identification for an Existing Account](../../doc/controllers/account-identification.md#create-an-identification-for-an-existing-account)
* [Delete Account Identification](../../doc/controllers/account-identification.md#delete-account-identification)
* [Get an Account Identification by Id](../../doc/controllers/account-identification.md#get-an-account-identification-by-id)
* [Amend Account Identification](../../doc/controllers/account-identification.md#amend-account-identification)


# List Account Identifications by Account

List Account Identifications by Account

```csharp
ListAccountIdentificationsByAccountAsync(
    Guid accountId,
    string pageNumber = null,
    int? pageSize = null,
    List<Guid> filterOrganisationId = null,
    List<string> filterSecondaryIdentification = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `Guid` | Template, Required | Account Id to which this identification relates to |
| `pageNumber` | `string` | Query, Optional | Which page to select |
| `pageSize` | `int?` | Query, Optional | Number of items to select |
| `filterOrganisationId` | `List<Guid>` | Query, Optional | Filter by organisation id |
| `filterSecondaryIdentification` | `List<string>` | Query, Optional | Filter to only include account identifications with specified secondary_identification |

## Response Type

[`Task<Models.AccountIdentificationListResponse>`](../../doc/models/account-identification-list-response.md)

## Example Usage

```csharp
Guid accountId = new Guid("00001114-0000-0000-0000-000000000000");
Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')try
{
    AccountIdentificationListResponse result = await accountIdentificationController.ListAccountIdentificationsByAccountAsync(accountId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create an Identification for an Existing Account

Create an identification for an existing Account

```csharp
CreateAnIdentificationForAnExistingAccountAsync(
    Guid accountId,
    Models.AccountIdentificationRequest accountIdentificationCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `Guid` | Template, Required | Account Id to which this identification relates to |
| `accountIdentificationCreationRequest` | [`AccountIdentificationRequest`](../../doc/models/account-identification-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.AccountIdentificationResponse>`](../../doc/models/account-identification-response.md)

## Example Usage

```csharp
Guid accountId = new Guid("00001114-0000-0000-0000-000000000000");
AccountIdentificationRequest accountIdentificationCreationRequest = new AccountIdentificationRequest
{
    Data = new AccountIdentification
    {
        Attributes = new AccountIdentificationAttributes
        {
            SecondaryIdentification = "secondary_identification2",
        },
        Id = new Guid("7826c3cb-d6fd-41d0-b187-dc23ba928772"),
        OrganisationId = new Guid("ee2fb143-6dfe-4787-b183-ca8ddd4164d2"),
        Type = "account_identifications",
        Version = 0,
    },
};

try
{
    AccountIdentificationResponse result = await accountIdentificationController.CreateAnIdentificationForAnExistingAccountAsync(
        accountId,
        accountIdentificationCreationRequest
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
| 409 | Account Identification creation error, constraint violation of secondary identification | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Delete Account Identification

Delete account identification

```csharp
DeleteAccountIdentificationAsync(
    Guid accountId,
    Guid identificationId,
    int version)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `Guid` | Template, Required | Account Id |
| `identificationId` | `Guid` | Template, Required | Account Identification Id |
| `version` | `int` | Query, Required | Version |

## Response Type

`Task`

## Example Usage

```csharp
Guid accountId = new Guid("00001114-0000-0000-0000-000000000000");
Guid identificationId = new Guid("000011c0-0000-0000-0000-000000000000");
int version = 172;
try
{
    await accountIdentificationController.DeleteAccountIdentificationAsync(
        accountId,
        identificationId,
        version
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
| 404 | Account Identification not found | `ApiException` |


# Get an Account Identification by Id

Get an account identification by id

```csharp
GetAnAccountIdentificationByIdAsync(
    Guid accountId,
    Guid identificationId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `Guid` | Template, Required | Account Id |
| `identificationId` | `Guid` | Template, Required | Account Identification Id |

## Response Type

[`Task<Models.AccountIdentificationResponse>`](../../doc/models/account-identification-response.md)

## Example Usage

```csharp
Guid accountId = new Guid("00001114-0000-0000-0000-000000000000");
Guid identificationId = new Guid("000011c0-0000-0000-0000-000000000000");
try
{
    AccountIdentificationResponse result = await accountIdentificationController.GetAnAccountIdentificationByIdAsync(
        accountId,
        identificationId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Amend Account Identification

Amend Account Identification

```csharp
AmendAccountIdentificationAsync(
    Guid accountId,
    Guid identificationId,
    Models.AccountIdentificationRequest accountIdentificationAmendRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `Guid` | Template, Required | Account Id |
| `identificationId` | `Guid` | Template, Required | Account Identification Id; Must match id in the payload |
| `accountIdentificationAmendRequest` | [`AccountIdentificationRequest`](../../doc/models/account-identification-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.AccountIdentificationResponse>`](../../doc/models/account-identification-response.md)

## Example Usage

```csharp
Guid accountId = new Guid("00001114-0000-0000-0000-000000000000");
Guid identificationId = new Guid("000011c0-0000-0000-0000-000000000000");
AccountIdentificationRequest accountIdentificationAmendRequest = new AccountIdentificationRequest
{
    Data = new AccountIdentification
    {
        Attributes = new AccountIdentificationAttributes
        {
            SecondaryIdentification = "secondary_identification2",
        },
        Id = new Guid("7826c3cb-d6fd-41d0-b187-dc23ba928772"),
        OrganisationId = new Guid("ee2fb143-6dfe-4787-b183-ca8ddd4164d2"),
        Type = "account_identifications",
        Version = 0,
    },
};

try
{
    AccountIdentificationResponse result = await accountIdentificationController.AmendAccountIdentificationAsync(
        accountId,
        identificationId,
        accountIdentificationAmendRequest
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
| 409 | Account Identification update error, constraint violation of secondary identification | [`ApiErrorException`](../../doc/models/api-error-exception.md) |

