# Accounts

```csharp
AccountsController accountsController = client.AccountsController;
```

## Class Name

`AccountsController`

## Methods

* [List Accounts](../../doc/controllers/accounts.md#list-accounts)
* [Create Account](../../doc/controllers/accounts.md#create-account)
* [Delete Account](../../doc/controllers/accounts.md#delete-account)
* [Fetch Account](../../doc/controllers/accounts.md#fetch-account)
* [Amend Account](../../doc/controllers/accounts.md#amend-account)
* [Fetch Account Events](../../doc/controllers/accounts.md#fetch-account-events)


# List Accounts

List accounts

```csharp
ListAccountsAsync(
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
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pageNumber` | `string` | Query, Optional | Which page to select |
| `pageBefore` | `string` | Query, Optional | Cursor value for getting previous page |
| `pageAfter` | `string` | Query, Optional | Cursor value for getting next page |
| `pageSize` | `int?` | Query, Optional | Number of items to select |
| `filterOrganisationId` | `List<Guid>` | Query, Optional | Filter by organisation id |
| `filterBankIdCode` | `List<string>` | Query, Optional | Filter by type of bank id e.g. "GBDSC" |
| `filterBankId` | `List<string>` | Query, Optional | Filter by bank id e.g. sort code or bic |
| `filterAccountNumber` | `List<string>` | Query, Optional | Filter by account number |
| `filterCountry` | `List<string>` | Query, Optional | Filter by country e.g. FR,GB |
| `filterCustomerId` | `List<string>` | Query, Optional | Filter by customer_id |
| `filterIban` | `List<string>` | Query, Optional | Filter by IBAN |

## Response Type

[`Task<Models.AccountDetailsListResponse>`](../../doc/models/account-details-list-response.md)

## Example Usage

```csharp
Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')try
{
    AccountDetailsListResponse result = await accountsController.ListAccountsAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create Account

Create account

```csharp
CreateAccountAsync(
    Models.AccountCreation accountCreationRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountCreationRequest` | [`AccountCreation`](../../doc/models/account-creation.md) | Body, Optional | - |

## Response Type

[`Task<Models.AccountCreationResponse>`](../../doc/models/account-creation-response.md)

## Example Usage

```csharp
AccountCreation accountCreationRequest = new AccountCreation
{
    Data = new Account
    {
        Attributes = new AccountAttributes
        {
            Country = "GB",
            AccountClassification = AccountClassification1Enum.Personal,
            AccountMatchingOptOut = false,
            AccountNumber = "41426819",
            BankId = "400300",
            BankIdCode = "GBDSC",
            BaseCurrency = "GBP",
            Bic = "NWBKGB22",
            CustomerId = "12345",
            Iban = "GB11NWBK40030041426819",
            JointAccount = false,
            NameMatchingStatus = NameMatchingStatusEnum.Supported,
            ReferenceMask = "4929############",
            StatusReason = StatusReasonEnum.Transferred,
            Switched = false,
            Title = "Ms",
        },
        Id = new Guid("7826c3cb-d6fd-41d0-b187-dc23ba928772"),
        OrganisationId = new Guid("ee2fb143-6dfe-4787-b183-ca8ddd4164d2"),
        Type = "accounts",
        Version = 0,
    },
};

try
{
    AccountCreationResponse result = await accountsController.CreateAccountAsync(accountCreationRequest);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Delete Account

Delete account

```csharp
DeleteAccountAsync(
    Guid id,
    int version)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Account Id |
| `version` | `int` | Query, Required | Version |

## Response Type

`Task`

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
int version = 172;
try
{
    await accountsController.DeleteAccountAsync(
        id,
        version
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Fetch Account

Fetch account

```csharp
FetchAccountAsync(
    Guid id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Account Id |

## Response Type

[`Task<Models.AccountDetailsResponse>`](../../doc/models/account-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    AccountDetailsResponse result = await accountsController.FetchAccountAsync(id);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Amend Account

Amend account

```csharp
AmendAccountAsync(
    Guid id,
    Models.AccountAmendment accountAmendRequest = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Account Id |
| `accountAmendRequest` | [`AccountAmendment`](../../doc/models/account-amendment.md) | Body, Optional | - |

## Response Type

[`Task<Models.AccountDetailsResponse>`](../../doc/models/account-details-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
try
{
    AccountDetailsResponse result = await accountsController.AmendAccountAsync(id);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Fetch Account Events

Fetch account events

```csharp
FetchAccountEventsAsync(
    Guid id,
    string pageNumber = null,
    int? pageSize = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `Guid` | Template, Required | Account Id |
| `pageNumber` | `string` | Query, Optional | Which page to select |
| `pageSize` | `int?` | Query, Optional | Number of items to select |

## Response Type

[`Task<Models.AccountEventListResponse>`](../../doc/models/account-event-list-response.md)

## Example Usage

```csharp
Guid id = new Guid("00001770-0000-0000-0000-000000000000");
Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')try
{
    AccountEventListResponse result = await accountsController.FetchAccountEventsAsync(id);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

