# Platformsecurityapi

```csharp
PlatformsecurityapiController platformsecurityapiController = client.PlatformsecurityapiController;
```

## Class Name

`PlatformsecurityapiController`

## Methods

* [Get a List of Signing Keys](../../doc/controllers/platformsecurityapi.md#get-a-list-of-signing-keys)
* [Fetch a Signing Key](../../doc/controllers/platformsecurityapi.md#fetch-a-signing-key)


# Get a List of Signing Keys

Get a list of Signing Keys

```csharp
GetAListOfSigningKeysAsync()
```

## Response Type

[`Task<Models.SigningKeysListResponse>`](../../doc/models/signing-keys-list-response.md)

## Example Usage

```csharp
try
{
    SigningKeysListResponse result = await platformsecurityapiController.GetAListOfSigningKeysAsync();
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
| 403 | Action Forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 502 | Bad Gateway | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| Default | Unexpected Error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |


# Fetch a Signing Key

Fetch a Signing Key

```csharp
FetchASigningKeyAsync(
    Guid signingkeyId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `signingkeyId` | `Guid` | Template, Required | Signing Key ID |

## Response Type

[`Task<Models.SigningKeysResponse>`](../../doc/models/signing-keys-response.md)

## Example Usage

```csharp
Guid signingkeyId = new Guid("0000096e-0000-0000-0000-000000000000");
try
{
    SigningKeysResponse result = await platformsecurityapiController.FetchASigningKeyAsync(signingkeyId);
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
| 403 | Action Forbidden | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 404 | Not Found | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| 502 | Bad Gateway | [`ApiErrorException`](../../doc/models/api-error-exception.md) |
| Default | Unexpected Error | [`ApiErrorException`](../../doc/models/api-error-exception.md) |

